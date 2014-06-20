package com.nhnnext.goznauk.phonetracker.app;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.util.Log;


/**
 * Created by goznauk on 2014. 6. 12..
 */
public class autoStartService extends BroadcastReceiver {

    @Override
    public void onReceive(Context context, Intent intent) {
        // TODO Auto-generated method stub
        Intent i = new Intent(context, CollectService.class);
        context.startService(i);
//		Log.i("Autostart", "started");
    }
}
