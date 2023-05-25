package com.example.thema.smartfridge;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.Dictionary;
import java.util.Enumeration;
import java.util.List;

public class OpenFridge extends AppCompatActivity implements AdapterView.OnItemClickListener{

    ListView list;

    String []products = {"Coca Cola", "Κοτόπουλο", "Μοσχαράκι", "Κρεμμύδι", "Μήλο", "Μπανάνα", "Γάλα άσπρο", "Γραβιέρα", "Σπαγγέτι", "Ζαμπόν", "Αυγά", "Κέτσαπ"};
    public Dictionary<String, String> dict = new Dictionary<String, String>() {
        @Override
        public int size() {
            return 0;
        }

        @Override
        public boolean isEmpty() {
            return false;
        }

        @Override
        public Enumeration<String> keys() {
            return null;
        }

        @Override
        public Enumeration<String> elements() {
            return null;
        }

        @Override
        public String get(Object o) {
            return null;
        }

        @Override
        public String put(String s, String s2) {
            return null;
        }

        @Override
        public String remove(Object o) {
            return null;
        }
    };
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_open_fridge);

        list = (ListView)findViewById(R.id.list);
        dict.put("Coca Cola", "4");
        dict.put("Κοτόπουλο", "2");
        dict.put("Μοσχαράκι", "4");
        dict.put("Κρεμμύδι", "3");
        dict.put("Μήλο", "3");
        dict.put("Μπανάνα", "2");
        dict.put("Γάλα άσπρο", "3");
        dict.put("Γραβιέρα", "1");
        dict.put("Σπαγγέτι", "2");
        dict.put("Ζαμπόν", "3");
        dict.put("Αυγά", "6");
        dict.put("Κέτσαπ", "1");
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, products);
        list.setAdapter(adapter);
        list.setOnItemClickListener(this);
    }

    @Override
    public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
        TextView tv = (TextView)view;
        Toast.makeText(this, "Έχεις " + dict.get(tv.getText()) + " " + tv.getText() + " στο ψυγείο σου", Toast.LENGTH_LONG).show();
    }
}
