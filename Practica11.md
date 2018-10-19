package com.google.android.instantapps.samples.hello.feature;

import android.content.Intent;
import android.os.Bundle;
import android.provider.MediaStore;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.TextView;

/**
 * This Activity displays a simple hello world text and a button to open the GoodbyeActivity.
 */
public class HelloActivity extends AppCompatActivity {

    private EditText editText1;
    private EditText editText2;
    private TextView textView1;
    private RadioButton rBurron1;
    private RadioButton rBuutton2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_hello);
        findViewById(R.id.button).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                startActivity(new Intent(HelloActivity.this, GoodbyeActivity.class));
            }
        });

        editText1 = (EditText)findViewById(R.id.txt_num1);
        editText2 = (EditText)findViewById(R.id.txt_num2);
        textView1 = (TextView)findViewById(R.id.txt_Resultado);
        rBurron1 = (RadioButton)findViewById(R.id.radioButtonResta);
        rBuutton2 = (RadioButton)findViewById(R.id.radioButtonSuma);
    }

    public void Suma(View view)
    {

            String Val1T = editText1.getText().toString();
            String Val2T = editText2.getText().toString();

            double Val1Int = Double.parseDouble(Val1T);
            double Val2Int = Double.parseDouble(Val2T);

            double Result = 0;

            if(Val1Int>=999||Val2Int>=999)
            {
                String ResStrig = "3 dígitos máximo, prro";

                textView1.setText(ResStrig);
            }
            else if(Val1Int<=-999||Val2Int<=-999)
            {
                String ResStrig = "3 dígitos máximo, prro";

                textView1.setText(ResStrig);
            }

            else
                {


                if (rBuutton2.isChecked() == true) {
                    Result = Val1Int + Val2Int;

                } else {
                    Result = Val1Int - Val2Int;
                }
                String ResStrig = String.valueOf(Result);

                textView1.setText(ResStrig);
                }
    }

    public void Quitar(View view)
    {
        editText1.setText(null);
        editText2.setText(null);

        String ResStrig = "";

        textView1.setText(ResStrig);

    }

}
