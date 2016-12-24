package com.tecnotiv.notificador;

import android.app.Notification;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.os.AsyncTask;
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
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;

import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.DefaultHttpClient;
import org.json.JSONArray;
import org.json.JSONException;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.UnsupportedEncodingException;
import java.util.Timer;
import java.util.TimerTask;
import java.util.logging.Handler;
import java.util.logging.LogRecord;


public class MainActivity extends AppCompatActivity {

    private Button btnAtendido, btnapagarEnceder;
    private TextView lbltextocabesera, lblencenderapagar;
    private ImageView imgImagen;
    private int Valor = 1;
    private String idActividad = "";
    private String txtActividad="";
    private String txtDescripcion="";
    private int lanzador = 0;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);



        btnAtendido = (Button) findViewById(R.id.btnAtendido);
        btnapagarEnceder = (Button) findViewById(R.id.encenderApagar);
        lbltextocabesera = (TextView) findViewById(R.id.lblTexto);
        lblencenderapagar = (TextView) findViewById(R.id.lblNonotificar);
        imgImagen = (ImageView) findViewById(R.id.imagen);


        btnapagarEnceder.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View view) {
                if (Valor == 1){
                    Valor = 0;
                    btnapagarEnceder.setBackgroundColor(getResources().getColor(R.color.btnancendodo));
                    btnapagarEnceder.setText("ON");
                    lblencenderapagar.setText("Notificaciones");
                    lblencenderapagar.setTextSize(25);
                    if (lanzador==0) {
                        llamado();
                        lanzador=1;
                    }
                }
                else
                {
                    Valor = 1;
                    btnapagarEnceder.setBackgroundColor(getResources().getColor(R.color.colorAtencion));
                    btnapagarEnceder.setText("!!!");
                    lblencenderapagar.setText("No Detener Avisos ");
                    lblencenderapagar.setTextSize(18);
                    imgImagen.setImageDrawable(getResources().getDrawable(R.drawable.logo));
                }
            }
        });

        btnAtendido.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                Toast.makeText(MainActivity.this, txtDescripcion, Toast.LENGTH_LONG).show();
                btnAtendido.setVisibility(View.GONE);
            }
        });


    }



    public void llamado() {

            new peticionHttp().execute("http://138.197.144.25/gets/getByid.php?id=Mizael");

    }


    public void notificaciones(String id, String texto) {


            switch (idActividad) {
                case "1":
                    Intent intent = new Intent(MainActivity.this, MainActivity.class);
                    PendingIntent pendingIntent = PendingIntent.getActivity(this, 0, intent, 0);
                    NotificationCompat.Builder builder = new NotificationCompat.Builder(MainActivity.this);

                    builder.setContentTitle("Nesesito Algo !!!")
                            .setContentText("Me Gustaria lo Siguente : "+texto+ ". Muchas Gracias Por Tu Atencion !!!")
                            .setSmallIcon(R.drawable.logo)
                            .setVibrate(new long[]{100, 100, 400})
                            .setAutoCancel(true);

                    builder.setContentIntent(pendingIntent);
                    builder.setDefaults(Notification.DEFAULT_SOUND);

                    NotificationManager manager = (NotificationManager) getSystemService(MainActivity.this.NOTIFICATION_SERVICE);
                    manager.notify(0, builder.build());

                    imgImagen.setImageDrawable(getResources().getDrawable(R.drawable.hola));
                    lbltextocabesera.setText(texto);
                    btnAtendido.setVisibility(View.VISIBLE);
                    break;
                case "2":
                    Intent intent1 = new Intent(MainActivity.this, MainActivity.class);
                    PendingIntent pendingIntent1 = PendingIntent.getActivity(MainActivity.this, 0, intent1, 0);
                    NotificationCompat.Builder builder1 = new NotificationCompat.Builder(MainActivity.this);

                    builder1.setContentTitle(texto)
                            .setContentText("Hola, necesito "+texto)
                            .setSmallIcon(R.drawable.logo)
                            .setVibrate(new long[]{100, 100, 100, 400})
                            .setAutoCancel(true);

                    builder1.setContentIntent(pendingIntent1);
                    builder1.setDefaults(Notification.DEFAULT_SOUND);

                    NotificationManager manager1 = (NotificationManager) getSystemService(MainActivity.this.NOTIFICATION_SERVICE);
                    manager1.notify(0, builder1.build());

                    imgImagen.setImageDrawable(getResources().getDrawable(R.drawable.bebidas));
                    lbltextocabesera.setText("Menu Bebidas");
                    break;
                case "3":
                    Intent intent2 = new Intent(MainActivity.this, MainActivity.class);
                    PendingIntent pendingIntent2 = PendingIntent.getActivity(MainActivity.this, 0, intent2, 0);
                    NotificationCompat.Builder builder2 = new NotificationCompat.Builder(MainActivity.this);

                    builder2.setContentTitle(texto)
                            .setContentText("Hola, necesito "+texto)
                            .setSmallIcon(R.drawable.logo)
                            .setVibrate(new long[]{100, 100, 100, 400})
                            .setAutoCancel(true);

                    builder2.setContentIntent(pendingIntent2);
                    builder2.setDefaults(Notification.DEFAULT_SOUND);

                    NotificationManager manager2 = (NotificationManager) getSystemService(MainActivity.this.NOTIFICATION_SERVICE);
                    manager2.notify(0, builder2.build());


                    imgImagen.setImageDrawable(getResources().getDrawable(R.drawable.postres));
                    lbltextocabesera.setText("Menu Postres");
                    break;

            }



    }





    private class peticionHttp extends AsyncTask<String,Void,String>{

        InputStream is = null;
        String Json = "";

        @Override
        protected String doInBackground(String... urls) {

            String result = "";
            try{
                DefaultHttpClient httpClient =new DefaultHttpClient();
                HttpGet httpget = new HttpGet(urls[0]);

                HttpResponse httpResponse = httpClient.execute(httpget);
                HttpEntity httpEntity= httpResponse.getEntity();
                is=httpEntity.getContent();
            } catch (UnsupportedEncodingException e){
                e.printStackTrace();
            } catch (ClientProtocolException e){
                e.printStackTrace();
            } catch (IOException e) {
                e.printStackTrace();
            }
            try{
                BufferedReader reader = new BufferedReader(new InputStreamReader( is, "iso-8859-1"),8);
                StringBuilder sb= new StringBuilder();
                String line = null;
                while ((line = reader.readLine())!= null){
                    sb.append(line + "\n");
                }
                is.close();
                result= sb.toString();
            } catch (Exception e){
                Log.e("Butter Error", "Error converting result " + e.toString());
            }
            return result;
        }

        @Override
        protected void onPostExecute(String result) {
            //PARSEO
            try {
                JSONArray JArrayObject = new JSONArray(result);

                idActividad = JArrayObject.getJSONObject(0).getString("idActividad");
                txtActividad = JArrayObject.getJSONObject(0).getString("txtActividad");
                txtDescripcion = JArrayObject.getJSONObject(0).getString("txtTecto");

                if (idActividad.equals("0")){
                    new CountDownTimer(3000, 1000) {
                        public void onFinish() {
                            // When timer is finished
                            // Execute your code here
                            llamado();

                        }

                        public void onTick(long millisUntilFinished) {
                            // millisUntilFinished    The amount of time until finished.
                        }
                    }.start();


                }else {
                    notificaciones(idActividad, txtActividad);
                    new peticionHttp().execute("http://138.197.144.25/inserts/updateVacante.php?txtUsuario=Mizael&idAlimento=0&txtAlimento=&idActividad=0&txtActividad=&idTexto=0&txttexto=");
                    new CountDownTimer(5000, 1000) {
                        public void onFinish() {
                            // When timer is finished
                            // Execute your code here
                            llamado();

                        }

                        public void onTick(long millisUntilFinished) {
                            // millisUntilFinished    The amount of time until finished.
                        }
                    }.start();
                }


            } catch (JSONException e){
                Log.e("JSON Parser", "Error parsing data " + e.toString() );
            }
        }
    }

}

