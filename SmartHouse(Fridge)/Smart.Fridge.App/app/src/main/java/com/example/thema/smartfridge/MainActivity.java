package com.example.thema.smartfridge;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;

public class MainActivity extends AppCompatActivity {


    public ImageButton calendar;
    public ImageButton shop;
    public ImageButton products;
    public ImageButton settings;
    public ImageButton temprature;
    public ImageButton fridge;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        init();
    }

    public void init(){
        calendar = (ImageButton) findViewById(R.id.ib_calendar);
        shop = (ImageButton) findViewById(R.id.ib_shop);
        products = (ImageButton) findViewById(R.id.ib_products);
        settings = (ImageButton) findViewById(R.id.ib_settings);
        temprature = (ImageButton) findViewById(R.id.ib_temptature);
        fridge = (ImageButton) findViewById(R.id.ib_fridge);

        calendar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent calendar = new Intent(MainActivity.this, Calendar.class);
                startActivity(calendar);
            }
        });

        fridge.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent open_fridge = new Intent(MainActivity.this, OpenFridge.class);
                startActivity(open_fridge);
            }
        });

        temprature.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent temprature = new Intent(MainActivity.this, FridgeTemprature.class);
                startActivity(temprature);
            }
        });

        settings.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent settings = new Intent(MainActivity.this, Settings.class);
                startActivity(settings);
            }
        });
    }
}
