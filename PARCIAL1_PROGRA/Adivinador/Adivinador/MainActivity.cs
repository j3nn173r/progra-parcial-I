using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Adivinador
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        ScrollView scrollPrincipal;

        TextView tvSaludo;
        TextView tvMostrarResultado;

        EditText txtNombre;
        EditText txtResultado;

        EditText txtPensarResp;

        LinearLayout layMenuBotones;

        LinearLayout layDiaNac;
        LinearLayout layMultiplicar20;
        LinearLayout laySumar73;
        LinearLayout layMultiplicar5;
        LinearLayout layAgregarMesNac;
        LinearLayout layIngresaResultado;
        LinearLayout layMostrarRespuesta;

        LinearLayout layPensarNum;
        LinearLayout layPensarMult2;
        LinearLayout layPensarSum8;
        LinearLayout layPensarMult5;
        LinearLayout layPensarIngresaResp;

        Button btnAgregarNombre;
        Button btnAgregarDiaNac;
        Button btnMultiplicar20;
        Button btnSumar73;
        Button btnMultiplicar5;
        Button btnAgregarMesNac;
        Button btnIngresaResultado;
        Button btnFinalizar;

        Button btnAdivinaCumple;
        Button btnAdivinaNumero;

        Button btnPensarNum;
        Button btnPensarMult2;
        Button btnPensarSum8;
        Button btnPensarMult5;
        Button btnPensarIngresaResp;

        int resultado;
        int posX;
        int posY;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            scrollPrincipal = FindViewById<ScrollView>(Resource.Id.scroll_principal);

            layMenuBotones = FindViewById<LinearLayout>(Resource.Id.lay_menu_botones);

            layDiaNac = FindViewById<LinearLayout>(Resource.Id.lay_dia_nac);
            layMultiplicar20 = FindViewById<LinearLayout>(Resource.Id.lay_mult_20);
            laySumar73 = FindViewById<LinearLayout>(Resource.Id.lay_sumar73);
            layMultiplicar5 = FindViewById<LinearLayout>(Resource.Id.lay_multiplicar5);
            layAgregarMesNac = FindViewById<LinearLayout>(Resource.Id.lay_mes_nac);
            layIngresaResultado = FindViewById<LinearLayout>(Resource.Id.lay_ingresa_resultado);
            layMostrarRespuesta = FindViewById<LinearLayout>(Resource.Id.lay_mostrar);

            layPensarNum = FindViewById<LinearLayout>(Resource.Id.lay_pensar_num);
            layPensarMult2 = FindViewById<LinearLayout>(Resource.Id.lay_pensar_mult2);
            layPensarSum8 = FindViewById<LinearLayout>(Resource.Id.lay_pensar_sum8);
            layPensarMult5 = FindViewById<LinearLayout>(Resource.Id.lay_pensar_mult5);
            layPensarIngresaResp = FindViewById<LinearLayout>(Resource.Id.lay_pensar_ingresa_resultado);

            tvSaludo = FindViewById<TextView>(Resource.Id.tv_dia_nac_saludo);
            tvMostrarResultado = FindViewById<TextView>(Resource.Id.tv_mostrar);

            txtNombre = FindViewById<EditText>(Resource.Id.et_nombre);
            txtResultado = FindViewById<EditText>(Resource.Id.et_ingresa_resultado);
            txtPensarResp = FindViewById<EditText>(Resource.Id.et_pensar_ingresa_resultado);

            btnAdivinaCumple = FindViewById<Button>(Resource.Id.btn_adivina_cumple);
            btnAdivinaNumero = FindViewById<Button>(Resource.Id.btn_adivina_numero);

            btnAgregarNombre = FindViewById<Button>(Resource.Id.btn_agregar_nombre);
            btnAgregarDiaNac = FindViewById<Button>(Resource.Id.btn_dia_nac);
            btnMultiplicar20 = FindViewById<Button>(Resource.Id.btn_mult_20);
            btnSumar73 = FindViewById<Button>(Resource.Id.btn_sumar73);
            btnMultiplicar5 = FindViewById<Button>(Resource.Id.btn_multiplicar5);
            btnAgregarMesNac = FindViewById<Button>(Resource.Id.btn_mes_nac);
            btnIngresaResultado = FindViewById<Button>(Resource.Id.btn_ingresa_resultado);
            btnFinalizar = FindViewById<Button>(Resource.Id.btn_finalizar);

            btnPensarNum = FindViewById<Button>(Resource.Id.btn_pensar_num);
            btnPensarMult2 = FindViewById<Button>(Resource.Id.btn_pensar_mult2);
            btnPensarSum8 = FindViewById<Button>(Resource.Id.btn_pensar_sum8);
            btnPensarMult5 = FindViewById<Button>(Resource.Id.btn_pensar_mult5);

            btnPensarIngresaResp = FindViewById<Button>(Resource.Id.btn_pensar_ingresa_resultado);

            resultado = 0;
            posX = 0;
            posY = 0;


            btnAgregarNombre.Click += (sender, e) =>
            {
                posX = int.Parse(layMenuBotones.GetX().ToString());
                posY = int.Parse(layMenuBotones.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);


                tvSaludo.Text = "Bienvenido " + txtNombre.Text + " ¿Qué deseas jugar?";
            };

            btnAdivinaCumple.Click += (sender, e) =>
            {
                posX = int.Parse(layDiaNac.GetX().ToString());
                posY = int.Parse(layDiaNac.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);
            };

            btnAdivinaNumero.Click += (sender, e) =>
            {
                posX = int.Parse(layPensarNum.GetX().ToString());
                posY = int.Parse(layPensarNum.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);
            };


            btnAgregarDiaNac.Click += (sender, e) =>
            {
                posX = int.Parse(layMultiplicar20.GetX().ToString());
                posY = int.Parse(layMultiplicar20.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);
            };


            btnMultiplicar20.Click += (sender, e) =>
            {
                posX = int.Parse(laySumar73.GetX().ToString());
                posY = int.Parse(laySumar73.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);
            };

            btnSumar73.Click += (sender, e) =>
            {
                posX = int.Parse(layMultiplicar5.GetX().ToString());
                posY = int.Parse(layMultiplicar5.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);
            };

            btnMultiplicar5.Click += (sender, e) =>
            {
                posX = int.Parse(layAgregarMesNac.GetX().ToString());
                posY = int.Parse(layAgregarMesNac.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);
            };

            btnAgregarMesNac.Click += (sender, e) =>
            {
                txtResultado.Text = "";
                posX = int.Parse(layIngresaResultado.GetX().ToString());
                posY = int.Parse(layIngresaResultado.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);
            };

            btnIngresaResultado.Click += (sender, e) =>
            {
                resultado = int.Parse(txtResultado.Text) - 365;

                posX = int.Parse(layMostrarRespuesta.GetX().ToString());
                posY = int.Parse(layMostrarRespuesta.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);

                var dia = resultado.ToString().Substring(0, 2);
                var mes = resultado.ToString().Substring(2, 2);

                tvMostrarResultado.Text = "Tu cumpleaños es el " + dia + " del " + mes;
            };

            btnPensarNum.Click += (sender, e) =>
            {
                posX = int.Parse(layPensarMult2.GetX().ToString());
                posY = int.Parse(layPensarMult2.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);
            };

            btnPensarMult2.Click += (sender, e) =>
            {
                posX = int.Parse(layPensarSum8.GetX().ToString());
                posY = int.Parse(layPensarSum8.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);
            };

            btnPensarSum8.Click += (sender, e) =>
            {
                posX = int.Parse(layPensarMult5.GetX().ToString());
                posY = int.Parse(layPensarMult5.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);
            };

            btnPensarMult5.Click += (sender, e) =>
            {
                txtPensarResp.Text = "";
                posX = int.Parse(layPensarIngresaResp.GetX().ToString());
                posY = int.Parse(layPensarIngresaResp.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);
            };

            btnPensarIngresaResp.Click += (sender, e) =>
            {


                posX = int.Parse(layMostrarRespuesta.GetX().ToString());
                posY = int.Parse(layMostrarRespuesta.GetY().ToString());
                scrollPrincipal.ScrollTo(posX, posY);

                resultado = int.Parse(txtPensarResp.Text);
                var size = resultado.ToString().Length;
                resultado = int.Parse(resultado.ToString().Substring(0, (size - 1)));


                resultado = resultado - 4;

                tvMostrarResultado.Text = "El número que pensaste es el: " + resultado;
            };

            btnFinalizar.Click += (sender, e) =>
            {
                txtNombre.Text = "";
                scrollPrincipal.ScrollTo(0, 0);
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}