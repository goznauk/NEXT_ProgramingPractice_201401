package com.nhnnext.goznauk.phonetracker.app;

import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.util.Log;

/**
 * Created by goznauk on 2014. 6. 12..
 */
public class ScreenReceiver extends BroadcastReceiver {

    public static boolean isScreenOn = true;

    @Override
    public void onReceive(Context context, Intent intent) {
        String action = intent.getAction();
//		Log.i("screenReceiver", action);
        if (action.equals(Intent.ACTION_SCREEN_ON)) {
            isScreenOn = true;
        } else if (action.equals(Intent.ACTION_SCREEN_OFF)) {
            isScreenOn = false;
        }

    }
}
