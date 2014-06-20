package com.nhnnext.goznauk.phonetracker.app;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.text.DateFormat;
import java.util.Calendar;
import java.util.Date;

import android.app.ActivityManager;
import android.app.ActivityManager.RunningTaskInfo;
import android.app.Service;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.content.pm.PackageManager.NameNotFoundException;
import android.os.Environment;
import android.os.IBinder;
import android.os.PowerManager;
import android.util.Log;
import android.widget.Toast;
/**
 * Created by goznauk on 2014. 6. 12..
 */
public class CollectService extends Service {

    @Override
    public int onStartCommand(Intent i, int flags, int startId){
        Toast.makeText(getApplicationContext(), "Collecting service started", Toast.LENGTH_SHORT).show();
        ScreenReceiver sr = new ScreenReceiver();
        ScreenReceiver.isScreenOn = ((PowerManager) getSystemService(Context.POWER_SERVICE)).isScreenOn();
        registerReceiver(sr, new IntentFilter(Intent.ACTION_SCREEN_ON));
        registerReceiver(sr, new IntentFilter(Intent.ACTION_SCREEN_OFF));
        (new Thread(){
            public void run() {
                try{
                    while(true)
                    {
//						Log.i("isScreenOn", String.valueOf(ScreenReceiver.isScreenOn));
                        if(ScreenReceiver.isScreenOn)
                        {
                            ActivityManager am = (ActivityManager) CollectService.this.getSystemService(ACTIVITY_SERVICE);
                            RunningTaskInfo foregroundTaskInfo = am.getRunningTasks(1).get(0);

                            String packageName = foregroundTaskInfo.topActivity.getPackageName();
                            ApplicationInfo mApplicationInfo;
                            PackageManager mPackageManager = getPackageManager();
                            try{
                                mApplicationInfo = mPackageManager.getApplicationInfo(packageName, 0);
                            } catch(NameNotFoundException e){
                                mApplicationInfo = null;
                                e.printStackTrace();
                            }
                            String appName = (String) (mApplicationInfo != null ?
                                    mPackageManager.getApplicationLabel(mApplicationInfo) : "(unknown)");

                            File logFile = new File(getFilesDir().getPath() + "/ptracker.txt");
                            if(!logFile.exists()){
                                try
                                {
                                    logFile.createNewFile();
                                } catch (IOException e)
                                {
                                    e.printStackTrace();
                                }
                            }
                            try {
//								Log.i("file save", "started " + getFilesDir().getPath() + "/ptracker.txt");
                                String timestamp = String.valueOf(Calendar.getInstance().getTimeInMillis());
                                BufferedWriter buf = new BufferedWriter(new FileWriter(logFile, true));
                                buf.append(timestamp + " : " + appName);
                                buf.newLine();
                                buf.flush();
                                buf.close();
//								Log.i("file save", "finished");
                            } catch (IOException e) {
                                e.printStackTrace();
                            }
                        }

                        Thread.sleep(3000L);
                    }
                } catch(InterruptedException localInterruptedException) {
                    localInterruptedException.printStackTrace();
                }
            }
        }).start();

        return Service.START_STICKY;
    }

    @Override
    public IBinder onBind(Intent intent) {
        // TODO Auto-generated method stub
        return null;
    }

    @Override
    public void onDestroy(){
        Toast.makeText(getApplicationContext(), "Collecting service died", Toast.LENGTH_SHORT).show();
        super.onDestroy();
    }

}
