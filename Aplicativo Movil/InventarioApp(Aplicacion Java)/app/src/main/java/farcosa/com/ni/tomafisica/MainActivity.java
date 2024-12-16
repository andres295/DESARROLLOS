package farcosa.com.ni.tomafisica;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.app.DatePickerDialog;
import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.ColorDrawable;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.google.zxing.integration.android.IntentIntegrator;
import com.google.zxing.integration.android.IntentResult;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class MainActivity extends AppCompatActivity {
    //Instancias
    //login
    /*private EditText mEditTextName;
    private EditText mEditTextEmail;
    private EditText mEditTextPassword;*/
    private List<String> ListaUbicaciones;
    private List<String> ListaLotes;
    private List<String> ListaRacks;
    private List<String> ListaBodegas;
    private List<String> ListaUsuarios;
    private List<String> ListaConteos;

    EditText txtCodigo,txtDescripcion,txtLote,txtCantidad,txtVencimiento,txtProveedor,txtTipo,txtUm;
    Button btnGuardar, btnBuscar,btnCancelar;
    TextView  txtbo,txtco, txtracks,txtUsuarios;
    AutoCompleteTextView txtUserAutoCompleteTextView;
    Spinner spinenerUbicacion, spinnerConteo,spinnerRacks,spinnerUsuario,spinnerLotes,spinnerBodegas;
    RequestQueue requestQueue;
    private static final String BASE_URL = "http://83.147.36.30:8081/";

    //Date Picker dialog
    DatePickerDialog.OnDateSetListener onDateSetListener;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        ListaUbicaciones = new ArrayList<>();
        ListaLotes = new ArrayList<>();
        ListaRacks = new ArrayList<>();
        ListaBodegas = new ArrayList<>();
        ListaUsuarios = new ArrayList<>();
        ListaConteos = new ArrayList<>();
        cargarRacks();
        cargarBodegas();
        cargarUsuarios();
        cargarConteos();






        //VARIABLES CALENDAR
        final Calendar calendar = Calendar.getInstance();
        int year = calendar.get(Calendar.YEAR);
        int month = calendar.get(Calendar.MONTH);
        int day = calendar.get(Calendar.DAY_OF_MONTH);
        //INSTANCIANDO COMPONENTES XML
        spinenerUbicacion =  findViewById(R.id.spinnerUbicaciones);
        spinnerUsuario =     findViewById(R.id.spinnerUsuarios);
        spinnerConteo= findViewById(R.id.spinnerConteos);
        spinnerRacks= findViewById(R.id.spinnerRacks);
        spinnerLotes = findViewById(R.id.spinnerLotes);
        spinnerBodegas= findViewById(R.id.spinnerBodegas);
        txtCodigo = (EditText) findViewById(R.id.txtCodigo);
        txtDescripcion = (EditText)findViewById(R.id.txtDescripcion);
        txtDescripcion.setEnabled(false);

        //txtLote.setEnabled(false);
        txtCantidad = (EditText)findViewById(R.id.txtCantidad);
        txtVencimiento = (EditText)findViewById(R.id.txtVencimiento);
        //txtVencimiento.setEnabled(false);
        txtProveedor = (EditText)findViewById(R.id.txtProveedor);
        txtTipo = (EditText)findViewById(R.id.txtTipo);
        txtUm = (EditText)findViewById(R.id.txtum);
        btnGuardar = (Button) findViewById(R.id.btnGuardar);
        btnBuscar = (Button) findViewById(R.id.btnBuscar);
        btnCancelar = (Button) findViewById(R.id.btnLimpiarCampos);
        txtVencimiento.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                DatePickerDialog datePickerDialog = new DatePickerDialog(
                        MainActivity.this, android.R.style.Theme_Holo_Light_Dialog_MinWidth,
                        onDateSetListener,year,month,day);
                datePickerDialog.getWindow().setBackgroundDrawable(new ColorDrawable(Color.TRANSPARENT));
                datePickerDialog.show();
            }
        });
        onDateSetListener = new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker view, int year, int month, int dayOfMonth) {
                month = month + 1;
                /*String date = dayOfMonth+"-"+month+"-"+year;*/
                String date = year+"-"+month+"-"+dayOfMonth; //aca va
                txtVencimiento.setText(date);
            }
        };

        btnGuardar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //ejecutarServicioRetrofit2();
               ejecutarServicio("http://83.147.36.30:8081/api/Articulo/");
                dbutton();
                //ejecutarServicio("http://192.168.1.7:9095/api/Inventa");
            }
        });
        btnBuscar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                buscarProducto("http://83.147.36.30:8081/api/Articulo/"+txtCodigo.getText()+"");
                cargarUbicaciones();
                cargarLotes();
                //buscarProducto("http://192.168.0.9:9095/api/Inventa/"+txtCodigo.getText()+"");
            }
        });
        btnCancelar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                hbutton();
                clear();
            }
        });

    }

    /*METODO PARA CARGAR LAS UBICACIONES EN EL SPINNER*/
    private void cargarUbicaciones() {
        String url = "http://83.147.36.30:8081/api/Ubicaciones/"+txtCodigo.getText()+"";

        JsonArrayRequest request = new JsonArrayRequest(
                Request.Method.GET,
                url,
                null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        try {
                            // Limpiar la lista antes de agregar nuevos elementos
                            ListaUbicaciones.clear();

                            // Recorrer la respuesta JSON y agregar las opciones a la lista
                            for (int i = 0; i < response.length(); i++) {
                                JSONObject opcion = response.getJSONObject(i);
                                String UBICACION = opcion.getString("UBICACION");
                                ListaUbicaciones.add(UBICACION);

                            }

                            // Configurar el adaptador para el Spinner
                            ArrayAdapter<String> adapter = new ArrayAdapter<>(
                                    MainActivity.this,
                                    android.R.layout.simple_spinner_item,
                                    ListaUbicaciones

                            );

                            adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                            spinenerUbicacion.setAdapter(adapter);


                        } catch (JSONException e) {
                            e.printStackTrace();
                            Log.e("Volley", "Error al procesar la respuesta JSON");
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Log.e("Volley", "Error en la solicitud a la API: " + error.getMessage());
                    }
                });

        // Obtener la cola de solicitudes Volley y agregar la solicitud a la cola
        RequestQueue requestQueue = Volley.newRequestQueue(this);
        requestQueue.add(request);
    }

    /*METODO PARA CARGAR LOS LOTES EN EL SPINNER*/
    private void cargarLotes() {
        String url = "http://83.147.36.30:8081/api/Lotes/"+txtCodigo.getText()+"";

        JsonArrayRequest request = new JsonArrayRequest(
                Request.Method.GET,
                url,
                null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        try {
                            // Limpiar la lista antes de agregar nuevos elementos
                            ListaLotes.clear();

                            // Recorrer la respuesta JSON y agregar las opciones a la lista
                            for (int i = 0; i < response.length(); i++) {
                                JSONObject opcion = response.getJSONObject(i);
                                String LOTE = opcion.getString("LOTE");
                                ListaLotes.add(LOTE);
                            }

                            // Configurar el adaptador para el Spinner
                            ArrayAdapter<String> adapter = new ArrayAdapter<>(
                                    MainActivity.this,
                                    android.R.layout.simple_spinner_item,
                                    ListaLotes
                            );

                            adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                            spinnerLotes.setAdapter(adapter);


                        } catch (JSONException e) {
                            e.printStackTrace();
                            Log.e("Volley", "Error al procesar la respuesta JSON");
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Log.e("Volley", "Error en la solicitud a la API: " + error.getMessage());
                    }
                });

        // Obtener la cola de solicitudes Volley y agregar la solicitud a la cola
        RequestQueue requestQueue = Volley.newRequestQueue(this);
        requestQueue.add(request);
    }


    /*METODO PARA CARGAR LOS RACKS EN EL SPINNER*/
    private void cargarRacks() {
        String url = "http://83.147.36.30:8081/api/RACKS/";

        JsonArrayRequest request = new JsonArrayRequest(
                Request.Method.GET,
                url,
                null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        try {
                            // Limpiar la lista antes de agregar nuevos elementos
                            ListaRacks.clear();

                            // Recorrer la respuesta JSON y agregar las opciones a la lista
                            for (int i = 0; i < response.length(); i++) {
                                JSONObject opcion = response.getJSONObject(i);
                                String RACK = opcion.getString("RACK");
                                ListaRacks.add(RACK);
                            }

                            // Configurar el adaptador para el Spinner
                            ArrayAdapter<String> adapter = new ArrayAdapter<>(
                                    MainActivity.this,
                                    android.R.layout.simple_spinner_item,
                                    ListaRacks
                            );

                            adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                            spinnerRacks.setAdapter(adapter);


                        } catch (JSONException e) {
                            e.printStackTrace();
                            Log.e("Volley", "Error al procesar la respuesta JSON");
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Log.e("Volley", "Error en la solicitud a la API: " + error.getMessage());
                    }
                });

        // Obtener la cola de solicitudes Volley y agregar la solicitud a la cola
        RequestQueue requestQueue = Volley.newRequestQueue(this);
        requestQueue.add(request);
    }

    /*METODO PARA CARGAR LAS BODEGAS EN EL SPINNER*/
    private void cargarBodegas() {
        String url = "http://83.147.36.30:8081/api/BODEGAS/";

        JsonArrayRequest request = new JsonArrayRequest(
                Request.Method.GET,
                url,
                null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        try {
                            // Limpiar la lista antes de agregar nuevos elementos
                            ListaBodegas.clear();

                            // Recorrer la respuesta JSON y agregar las opciones a la lista
                            for (int i = 0; i < response.length(); i++) {
                                JSONObject opcion = response.getJSONObject(i);
                                String CODIGO = opcion.getString("CODIGO");
                                ListaBodegas.add(CODIGO);
                            }

                            // Configurar el adaptador para el Spinner
                            ArrayAdapter<String> adapter = new ArrayAdapter<>(
                                    MainActivity.this,
                                    android.R.layout.simple_spinner_item,
                                    ListaBodegas
                            );

                            adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                            spinnerBodegas.setAdapter(adapter);


                        } catch (JSONException e) {
                            e.printStackTrace();
                            Log.e("Volley", "Error al procesar la respuesta JSON");
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Log.e("Volley", "Error en la solicitud a la API: " + error.getMessage());
                    }
                });

        // Obtener la cola de solicitudes Volley y agregar la solicitud a la cola
        RequestQueue requestQueue = Volley.newRequestQueue(this);
        requestQueue.add(request);
    }

    /*METODO PARA CARGAR LOS USUARIOS EN EL SPINNER*/
    private void cargarUsuarios() {
        String url = "http://83.147.36.30:8081/api/USUARIOS/";

        JsonArrayRequest request = new JsonArrayRequest(
                Request.Method.GET,
                url,
                null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        try {
                            // Limpiar la lista antes de agregar nuevos elementos
                            ListaUsuarios.clear();

                            // Recorrer la respuesta JSON y agregar las opciones a la lista
                            for (int i = 0; i < response.length(); i++) {
                                JSONObject opcion = response.getJSONObject(i);
                                String NOMBRE = opcion.getString("NOMBRE");
                                ListaUsuarios.add(NOMBRE);
                            }

                            // Configurar el adaptador para el Spinner
                            ArrayAdapter<String> adapter = new ArrayAdapter<>(
                                    MainActivity.this,
                                    android.R.layout.simple_spinner_item,
                                    ListaUsuarios
                            );

                            adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                            spinnerUsuario.setAdapter(adapter);


                        } catch (JSONException e) {
                            e.printStackTrace();
                            Log.e("Volley", "Error al procesar la respuesta JSON");
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Log.e("Volley", "Error en la solicitud a la API: " + error.getMessage());
                    }
                });

        // Obtener la cola de solicitudes Volley y agregar la solicitud a la cola
        RequestQueue requestQueue = Volley.newRequestQueue(this);
        requestQueue.add(request);
    }
    private void cargarConteos() {
        String url = "http://83.147.36.30:8081/api/CONTEOS/";

        JsonArrayRequest request = new JsonArrayRequest(
                Request.Method.GET,
                url,
                null,
                new Response.Listener<JSONArray>() {
                    @Override
                    public void onResponse(JSONArray response) {
                        try {
                            // Limpiar la lista antes de agregar nuevos elementos
                            ListaConteos.clear();

                            // Recorrer la respuesta JSON y agregar las opciones a la lista
                            for (int i = 0; i < response.length(); i++) {
                                JSONObject opcion = response.getJSONObject(i);
                                String CONTEO = opcion.getString("CONTEO");
                                ListaConteos.add(CONTEO);
                            }

                            // Configurar el adaptador para el Spinner
                            ArrayAdapter<String> adapter = new ArrayAdapter<>(
                                    MainActivity.this,
                                    android.R.layout.simple_spinner_item,
                                    ListaConteos
                            );

                            adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
                            spinnerConteo.setAdapter(adapter);


                        } catch (JSONException e) {
                            e.printStackTrace();
                            Log.e("Volley", "Error al procesar la respuesta JSON");
                        }
                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        Log.e("Volley", "Error en la solicitud a la API: " + error.getMessage());
                    }
                });

        // Obtener la cola de solicitudes Volley y agregar la solicitud a la cola
        RequestQueue requestQueue = Volley.newRequestQueue(this);
        requestQueue.add(request);
    }


    //ENVIAR POST
    private void ejecutarServicio(String URL){
        StringRequest stringRequest = new StringRequest(Request.Method.POST, URL, new Response.Listener<String>() {
            @Override
           public void onResponse(String response) {
                Toast.makeText(getApplicationContext(), "Registro Ingresado", Toast.LENGTH_SHORT).show();
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
              Toast.makeText(getApplicationContext(), error.toString(), Toast.LENGTH_SHORT).show();
                Log.e("Volly Error", error.toString());
            }
        }){
            @Override
            protected Map<String, String> getParams() throws AuthFailureError {
                Map<String ,String> parametros = new HashMap<String, String>();
                parametros.put("conteo", spinnerConteo.getSelectedItem().toString());
                parametros.put("bodega", spinnerBodegas.getSelectedItem().toString());
                parametros.put("codigo", txtCodigo.getText().toString());
                parametros.put("lote", spinnerLotes.getSelectedItem().toString());
                parametros.put("fecha", txtVencimiento.getText().toString());
                parametros.put("descripcion", txtDescripcion.getText().toString());
                parametros.put("cantidad", txtCantidad.getText().toString());
                parametros.put("proveedor", txtProveedor.getText().toString());
                parametros.put("tipo", txtTipo.getText().toString());
                parametros.put("ubicacion", spinenerUbicacion.getSelectedItem().toString());
                //parametros.put("ubicacion", txtUbicaciones.getText().toString());
                parametros.put("rack", spinnerRacks.getSelectedItem().toString());
                parametros.put("um", txtUm.getText().toString());
                parametros.put("user", spinnerUsuario.getSelectedItem().toString());
                return parametros;
           }
        };
        requestQueue= Volley.newRequestQueue(this);
       requestQueue.add(stringRequest);
    }


    /*Metodo para buscar articulo Json(Objeto)*/
    private void buscarProducto(String URL)
    {
        StringRequest postResquest = new StringRequest(Request.Method.GET, URL, new Response.Listener<String>() {
            @Override
            public void onResponse(String response) {
                /*for (int i = 0; i < response.length(); i++)*/
                try {
                    JSONObject jsonObject = new JSONObject(response);
                    txtCodigo.setText(jsonObject.getString("ARTICULO"));
                    txtDescripcion.setText(jsonObject.getString("DESCRIPCION"));
                    txtProveedor.setText(jsonObject.getString("PROVEEDOR"));
                    txtTipo.setText(jsonObject.getString("TIPO"));
                    txtUm.setText(jsonObject.getString("UM"));

                } catch (JSONException e) {
                    e.printStackTrace();

                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
            }
        });
        Volley.newRequestQueue(this).add(postResquest);
    }
    //Metodo para scanear código de barra
    public void Onclick(View view) {
        if (view.getId() == R.id.btnScanner){
            new IntentIntegrator(this).initiateScan();
        }
    }

    //Llamar metodo result
    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        //llamar la informacion
        IntentResult result = IntentIntegrator.parseActivityResult(requestCode, resultCode,data);
        //obtener la informacion en un string
        String datos = result.getContents();
        txtCodigo.setText(datos);
    }
    //Metodo Clear
    private void clear(){

        txtCodigo.setText("");
        txtDescripcion.setText("");
        txtProveedor.setText("");
        txtTipo.setText("");
        txtUm.setText("");
        txtVencimiento.setText("");
        txtCantidad.setText("");
        txtCodigo.requestFocus();
        spinenerUbicacion.setSelection(0);
        spinnerLotes.setSelection(0);
    }
    //Deshabilitar boton guardar al presionar guardar
    private void dbutton(){
        btnGuardar.setEnabled(false);
    }
    //Habilitar boton guardar al presionar Nuevo
    private void hbutton(){
        btnGuardar.setEnabled(true);
    }

    //Validar que los autocomplete se llenen.
    private void validarAutocmplete(){
        Button btnGuardar = findViewById(R.id.btnGuardar);
        btnGuardar.setVisibility(View.INVISIBLE);

        if (txtUserAutoCompleteTextView.isSelected()){
            btnGuardar.setVisibility(View.VISIBLE);
        }
        else{
            btnGuardar.setVisibility(View.INVISIBLE);
        }

    }

}
