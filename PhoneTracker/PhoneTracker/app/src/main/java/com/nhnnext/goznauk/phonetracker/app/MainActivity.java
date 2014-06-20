package com.nhnnext.goznauk.phonetracker.app;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;

import android.support.v7.app.ActionBarActivity;
import android.support.v4.app.Fragment;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import android.widget.Toast;



/**
 * Created by goznauk on 2014. 6. 12..
 */
public class MainActivity extends ActionBarActivity {

    private PlaceholderFragment main_fragment = new PlaceholderFragment();
    private static Context mContext;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        mContext = this;

        if (savedInstanceState == null) {
            getSupportFragmentManager().beginTransaction()
                    .add(R.id.container, main_fragment).commit();
        }

        Intent i = new Intent(MainActivity.this, CollectService.class);
        startService(i);
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();
        if (id == R.id.action_refresh) {
            main_fragment.update_main_text();
            return true;
        }
        else if(id == R.id.action_clear_log)
        {
            clear_log();
            main_fragment.update_main_text();
            return true;
        }
        return super.onOptionsItemSelected(item);
    }

    private boolean clear_log()
    {
        File logFile = new File(mContext.getFilesDir().getPath() + "/ptracker.txt");
        if(logFile.delete())
        {
            try {
                logFile.createNewFile();
                Toast.makeText(mContext, "log cleard.", Toast.LENGTH_SHORT).show();
                return true;
            } catch (IOException e) {
                // TODO Auto-generated catch block
                e.printStackTrace();
            }
            return false;
        }
        else
            return false;
    }

    /**
     * A placeholder fragment containing a simple view.
     */
    public static class PlaceholderFragment extends Fragment {
        private View rootView;
        public PlaceholderFragment() {
        }

        @Override
        public View onCreateView(LayoutInflater inflater, ViewGroup container,
                                 Bundle savedInstanceState) {
            rootView = inflater.inflate(R.layout.fragment_main, container,
                    false);
            update_main_text();
            return rootView;
        }

        private int update_main_text()
        {
            File logFile = new File(mContext.getFilesDir().getPath() + "/ptracker.txt");
            if(logFile.exists()){
                try {
//					Log.i("file read", "started");
                    BufferedReader buf = new BufferedReader(new FileReader(logFile));
                    String textbuf = new String();
                    TextView main_text = (TextView) rootView.findViewById(R.id.logtext);
                    main_text.setText("");
                    String prevAppName="";
                    String appName="";
                    Long prevTime=0L;
                    Long time=0L;
                    String dateFormatter = "yyyy.MM.dd HH:mm:ss";

                    // 1st time exception
                    textbuf = buf.readLine();
                    if(textbuf !=null){
                        prevTime = Long.parseLong(textbuf.split(" : ")[0]);
                        prevAppName = textbuf.split(" : ")[1];
                        main_text.append((new SimpleDateFormat(dateFormatter, Locale.KOREA)).format(new Date(prevTime)) + "\n");
                    }

                    while(true)
                    {
                        textbuf = buf.readLine();
                        if(textbuf == null) break;
                        time = Long.parseLong(textbuf.split(" : ")[0]);
                        appName = textbuf.split(" : ")[1];
                        if(!appName.equals(prevAppName) || time-prevTime > 5000)
                            main_text.append("~ " + (new SimpleDateFormat(dateFormatter, Locale.KOREA)).format(new Date(prevTime)) + " "
                                    + prevAppName + "\n\n" + (new SimpleDateFormat(dateFormatter, Locale.KOREA)).format(new Date(time)) + "\n");
                        prevTime=time;
                        prevAppName = appName;
                    }
                    main_text.append("~ " + (new SimpleDateFormat(dateFormatter, Locale.KOREA)).format(new Date(time)) + " " + appName);
                    buf.close();
//					Log.i("file read", "finished");
                    Toast.makeText(mContext, "Refreshed", Toast.LENGTH_SHORT).show();
                    return 1;
                } catch (IOException e) {
                    Toast.makeText(mContext, "Error on reading log", Toast.LENGTH_SHORT).show();
                    e.printStackTrace();
                    return -1;
                }
            }
            Toast.makeText(mContext, "No Log File", Toast.LENGTH_SHORT).show();
            return 0;
        }
    }

}
