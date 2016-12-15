package com.tecnotiv.notificador;

import android.app.Notification;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.CountDownTimer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.app.NotificationCompat;
import android.support.v7.widget.SearchView;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.TextView;


public class MainActivity extends AppCompatActivity {

    private Button btnAtendido, btnapagarEnceder;
    private TextView lbltextocabesera, lblencenderapagar;
    private ImageView imgImagen;
    private int Valor = 1;
    private int actividad = 1;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);



        btnAtendido = (Button) findViewById(R.id.btnAtendido);
        btnapagarEnceder = (Button) findViewById(R.id.encenderApagar);
        lbltextocabesera = (TextView) findViewById(R.id.lblTexto);
        lblencenderapagar = (TextView) findViewById(R.id.lblNonotificar);
        imgImagen = (ImageView) findViewById(R.id.imagen);



        switch (actividad){
            case 1:
                Intent intent = new Intent(this, MainActivity.class);
                PendingIntent pendingIntent = PendingIntent.getActivity(this,0,intent,0);
                NotificationCompat.Builder builder = new NotificationCompat.Builder(this);

                builder.setContentTitle("Comida")
                        .setContentText("quiero Comer Papas Fritas")
                        .setSmallIcon(R.drawable.comidas)
                        .setVibrate(new long[]{100,100,100,400})
                        .setAutoCancel(true);

                builder.setContentIntent(pendingIntent);
                builder.setDefaults(Notification.DEFAULT_SOUND);

                NotificationManager manager = (NotificationManager)getSystemService(this.NOTIFICATION_SERVICE);
                manager.notify(0,builder.build());
                break;
            case 2:
                Intent intent1 = new Intent(this, MainActivity.class);
                PendingIntent pendingIntent1 = PendingIntent.getActivity(this,0,intent1,0);
                NotificationCompat.Builder builder1 = new NotificationCompat.Builder(this);

                builder1.setContentTitle("Comida")
                        .setContentText("quiero Comer Papas Fritas")
                        .setSmallIcon(R.drawable.comidas)
                        .setVibrate(new long[]{100,100,100,400})
                        .setAutoCancel(true);

                builder1.setContentIntent(pendingIntent1);
                builder1.setDefaults(Notification.DEFAULT_SOUND);

                NotificationManager manager1 = (NotificationManager)getSystemService(this.NOTIFICATION_SERVICE);
                manager1.notify(0,builder1.build());
                break;
            case 3:
                Intent intent2 = new Intent(this, MainActivity.class);
                PendingIntent pendingIntent2 = PendingIntent.getActivity(this,0,intent2,0);
                NotificationCompat.Builder builder2 = new NotificationCompat.Builder(this);

                builder2.setContentTitle("Comida")
                        .setContentText("quiero Comer Papas Fritas")
                        .setSmallIcon(R.drawable.comidas)
                        .setVibrate(new long[]{100,100,100,400})
                        .setAutoCancel(true);

                builder2.setContentIntent(pendingIntent2);
                builder2.setDefaults(Notification.DEFAULT_SOUND);

                NotificationManager manager2 = (NotificationManager)getSystemService(this.NOTIFICATION_SERVICE);
                manager2.notify(0,builder2.build());
                break;

        }

        btnapagarEnceder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (Valor == 1){
                    Valor = 0;
                    btnapagarEnceder.setBackgroundColor(getResources().getColor(R.color.btnancendodo));
                    btnapagarEnceder.setText("ON");
                }
                else
                {
                    Valor = 1;
                    btnapagarEnceder.setBackgroundColor(getResources().getColor(R.color.btnApagado));
                    btnapagarEnceder.setText("OFF");
                }
            }
        });

        btnAtendido.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                lbltextocabesera.setText("Gracias !!!!");
                imgImagen.setImageDrawable(getResources().getDrawable(R.drawable.ok));
            }
        });




    }

}
