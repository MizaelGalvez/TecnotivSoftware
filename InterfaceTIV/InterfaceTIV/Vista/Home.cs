using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceTIV.Vista;
using InterfaceTIV.Controladores;
using Emotiv;
using System.IO.Ports;  // crear los parametros en esta clase principal
using InterfaceTIV.Model;
using System.Diagnostics;

namespace InterfaceTIV.Vista
{
    public partial class Home : Form
    {


        
        ///////////////////////////////////////////////////VARIABLES LOCALES///////////////////////////////////////////////////////
        //
        //
        //
        //
        int cambio = 0;                                                            //Variable para el Swicheo de diadema, ratos, silla etc...
        public string cambioPanel = "home";                                                   //variable para controlar el panel automatico, si regresara atras o al de alimentos segun sea necesario
        int contador=0;
        int restaLongitud= 0;
        int Vlongitud = 0;
        string[,] Datos;
        string URL = "";
        string URL1 = "";
        string URL2 = "";
        string URL3 = "";
        string URL4 = "";
        string URL5 = "";
        string URL6 = "";
        //
        //
        string descripUNO = "";
        string descripDOS = "";
        string descripTRES = "";
        string descripCUATRO = "";
        string descripCINCO = "";
        string descripSEIS = "";
        //
        //
        int ancho;
        int alto;
        int X;
        int Y;
        //
        int animacion;
        int tipoGuardado = 0;
        //
        //
        //
        //
        //
        //
        //
        //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            



        ///////////////////////////////////////////////////METODOS Y CREACION DE OBJETOS///////////////////////////////////////////////////////
        //
        //
        //
        //
        public Home()
        {
            InitializeComponent();
            focus();
            int a = DateTime.Now.Hour;
            if (a >= 12)
            {
                Hora.Text = DateTime.Now.Hour - 12 + ":" + DateTime.Now.Minute.ToString("D2") + " PM";
            }
            else
            {
                Hora.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + " AM";
            }

            
        }
        public void focus(){
            txtComando.Text = "";
            txtComando.Select();  
        }                                                     //Metodo Llamado en Cada Accion para regresar al Focus donde se reciben los parametros de la diadema
        public void ReiniciarContador() {
            switch (cambioPanel)
            {
                case "home":
                    if (contador==14)
                    {
                        contador = 0;
                    }
                    break;
                case "alimentos":
                    if (contador == 8)
                    {
                        contador = 0;
                    }
                    break;
                case "comidas":
                    if (contador == 18)
                    {
                        contador = 0;
                    }
                    break;
                case "bebidas":
                    if (contador == 18)
                    {
                        contador = 0;
                    }
                    break;
                case "postres":
                    if (contador == 18)
                    {
                        contador = 0;
                    }
                    break;
                case "actividades":
                    if (contador == 18)
                    {
                        contador = 0;
                    }
                    break;
                case"entretenimiento":
                    if (contador == 18)
                    {
                        contador = 0;
                    }
                    break;
                case "silla":
                    if (contador == 10)
                    {
                        contador = 0;
                    }
                    break;
                case "rutas":
                    if (contador == 16)
                    {
                        contador = 0;
                    }
                    break;
                default:
                    break;
            }

        }

        public void enviar(string valor) {

            if (contador == Vlongitud)
            {
                contador = contador + restaLongitud;
            }
                
                Console.WriteLine(valor);
                LecturaSerial enviardatos = new LecturaSerial();
                enviardatos.sensor = cambio;
                enviardatos.valor = valor;
                enviardatos.contador = contador;
                enviardatos.panelReferencia = cambioPanel;
                enviardatos.Lectura();
                focus();
                contador++;
                ReiniciarContador();
        }                                       //Evento para enviar los datos recividos por Diadema y canalizarlos a movimiento mause o impresion Serial
        public void pintarMovimiento(string valor) {
            switch (valor)
            {
                case "N":
                    btnFlechaArriba.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaArriba;
                    btnFlechaIzquierda.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaIzquierda;
                    btnFlechaDerecha.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaDerecha;
                    break;
                case "W":
                    btnFlechaArriba.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaArribaClick;//arriba
                    btnFlechaIzquierda.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaIzquierda;
                    btnFlechaDerecha.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaDerecha;

                    break;
                case "A":
                    btnFlechaIzquierda.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaIzquierdaClick;//Izquierda
                    btnFlechaArriba.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaArriba;
                    btnFlechaDerecha.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaDerecha;
                    break;
                case "D":
                    btnFlechaDerecha.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaDerechaClick;//derecha
                    btnFlechaArriba.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaArriba;
                    btnFlechaIzquierda.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaIzquierda;
                    break;
                case "C":
                    break;
                default:
                    break;
            }

        }
        public void ocultarVentana(ref Panel Abrir, ref Panel Cerrar)
        {
            Cerrar.Hide();
            Abrir.Show();
            Abrir.Location = new Point(2, 55);
            focus();

        }           //Evento para ocultar Ventana Home y Mostrar la Deseada            
        private void txtComando_TextChanged(object sender, EventArgs e)
        {
            string valor = txtComando.Text;
            if (cambio==1)
            {
                pintarMovimiento(valor);
            }
            
            enviar(valor);
            Thread.Sleep(100);
        }         //Eventos de enviar comandos recibidos cuando el txt cambia de Valor.
        private void Home_Click(object sender, EventArgs e)
        {
            focus();
        }                     //Eventos de focus al elemento necesario, cuando da click en otra area de la ventana
        private void Notificador(int tipo, string Texto, string Descripcion, String URL)
        {
            switch (cambioPanel)
            {
                case "home":

                    break;
                case "alimentos":
                   
                    break;
                case "comidas":
                    MetodosHTTP datos = new MetodosHTTP();
                    datos.user = Acciones.usuario(1);
                    datos.idAlimento = 0;
                    datos.txtAlimento = URL;
                    datos.idActividad = 1;
                    datos.txtActividad = Texto;
                    datos.idtexto = tipo;
                    datos.txtTecto = Descripcion;
                    datos.EnviarNotificacion();
                    break;
                case "bebidas":
                    Console.WriteLine(URL);
                    MetodosHTTP datos2 = new MetodosHTTP();
                    datos2.user = Acciones.usuario(1);
                    datos2.idAlimento = 0;
                    datos2.txtAlimento = URL;
                    datos2.idActividad = 1;
                    datos2.txtActividad = Texto;
                    datos2.idtexto = tipo;
                    datos2.txtTecto = Descripcion;
                    datos2.EnviarNotificacion();
                    break;
                case "postres":
                    MetodosHTTP datos3 = new MetodosHTTP();
                    datos3.user = Acciones.usuario(1);
                    datos3.idAlimento = 0;
                    datos3.txtAlimento = URL;
                    datos3.idActividad = 1;
                    datos3.txtActividad = Texto;
                    datos3.idtexto = tipo;
                    datos3.txtTecto = Descripcion;
                    datos3.EnviarNotificacion();
                    break;
                case "actividades":
                    MetodosHTTP datos4 = new MetodosHTTP();
                    datos4.user = Acciones.usuario(1);
                    datos4.idAlimento = 0;
                    datos4.txtAlimento = URL;
                    datos4.idActividad = 2;
                    datos4.txtActividad = Texto;
                    datos4.idtexto = tipo;
                    datos4.txtTecto = Descripcion;
                    datos4.EnviarNotificacion();
                    break;
                case "entretenimiento":
                    abrirNavgador(Descripcion);
                    break;
                case "silla":
                   
                    break;
                case "rutas":
                   
                    break;
                default:
                    break;
            }
            focus();


           

        }  //metodo para enviar el datos del texto del boton. sera necesario adaptarlo para utilizar como modificador 
        public void ventanaAUTOMATICA(ref Panel Abrir, ref Panel Cerrar)
        {
            Cerrar.Hide();
            Abrir.Show();
            Abrir.Location = new Point(2, 55);
            focus();

        }        //Abrir Ventana Automatica con los valores necesarios para llenarla            
        public void BuscarDatosRecargar(string cambioPanel) {
            switch (cambioPanel)
            {
                case "comidas":
                    Datos = Acciones.ObtenerComidas();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "bebidas":
                    Datos = Acciones.ObtenerBebidas();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "postres":
                    Datos = Acciones.ObtenerPostres();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "actividades":
                    Datos = Acciones.ObtenerActividades();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "entretenimiento":
                    Datos = Acciones.ObtenerEntretenimiento();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "":
                    break;
                default:
                    break;
            }
        }
        public void abrirNavgador(string url)
        {
            try
            {
                Cursor.Show();
            }
            catch (Exception)
            {
                throw;
            }
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", url);

            WebNavegador web = new WebNavegador();
            web.Show();
            web.SetDesktopLocation(0, 0);
            web.Activate();


        }
        //
        //
        //
        //
        //
        //
        //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////LLenar el PANEL AUTOMATICO///////////////////////////////////////////////////////
        //
        //
        //
        //
        public void llenadoAUTOMATICO(string[,] Datos) {

            
            Vlongitud = (Datos.GetLength(0) * 2);
            string img;
            int longitud = Datos.GetLength(0);
            restaLongitud = 12 - Vlongitud;
            int incremento = 0;

            btnUNO.Hide();
            imgUNO.Hide();
            btnDOS.Hide();
            imgDOS.Hide();
            btnTRES.Hide();
            imgTRES.Hide();
            btnCUATRO.Hide();
            imgCUATRO.Hide();
            btnCINCO.Hide();
            imgCINCO.Hide();
            btnSEIS.Hide();
            imgSEIS.Hide();
            
            
            if (longitud>=1)
            {
                btnUNO.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgUNO.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img+ ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    btnUNO.Show();
                    imgUNO.Show();
                    descripUNO = Datos[incremento, 2];
                    URL1 = Datos[incremento, 1];
                }
                catch (Exception)
                {

                    throw;
                }
                incremento++;
            }
            if (longitud >= 2)
            {
                btnDOS.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgDOS.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    btnDOS.Show();
                    imgDOS.Show();
                    descripDOS = Datos[incremento, 2];
                    URL2 = Datos[incremento, 1];
                }
                catch (Exception)
                {

                    throw;
                }
                incremento++;
            }
            if (longitud >= 3)
            {
                btnTRES.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgTRES.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    btnTRES.Show();
                    imgTRES.Show();
                    descripTRES = Datos[incremento, 2];
                    URL3 = Datos[incremento, 1];
                }
                catch (Exception)
                {

                    throw;
                }
                incremento++;
            }
            if (longitud >= 4)
            {
                btnCUATRO.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgCUATRO.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    btnCUATRO.Show();
                    imgCUATRO.Show();
                    descripCUATRO = Datos[incremento, 2];
                    URL4 = Datos[incremento, 1];
                }
                catch (Exception)
                {

                    throw;
                }
                incremento++;
            }
            if (longitud >= 5)
            {
                btnCINCO.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgCINCO.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    btnCINCO.Show();
                    imgCINCO.Show();
                    descripCINCO = Datos[incremento, 2];
                    URL5 = Datos[incremento, 1];
                }
                catch (Exception)
                {

                    throw;
                }
                incremento++;
            }
            if (longitud >= 6)
            {
                btnSEIS.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgSEIS.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    btnSEIS.Show();
                    imgSEIS.Show();
                    descripSEIS = Datos[incremento, 2];
                    URL6 = Datos[incremento, 1];
                }
                catch (Exception)
                {

                    throw;
                }
                incremento++;
            }




        }
        public void vaciarAUTOMATICO() {
            try
            {
                btnUNO.Text = "";
                imgUNO.BackgroundImage = InterfaceTIV.Properties.Resources.imgNO;
                btnDOS.Text = "";
                imgDOS.BackgroundImage = InterfaceTIV.Properties.Resources.imgNO;
                btnTRES.Text = "";
                imgTRES.BackgroundImage = InterfaceTIV.Properties.Resources.imgNO;
                btnCUATRO.Text = "";
                imgCUATRO.BackgroundImage = InterfaceTIV.Properties.Resources.imgNO;
                btnCINCO.Text = "";
                imgCINCO.BackgroundImage = InterfaceTIV.Properties.Resources.imgNO;
                btnSEIS.Text = "";
                imgSEIS.BackgroundImage = InterfaceTIV.Properties.Resources.imgNO;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //
        //
        //
        //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////ABRIR VENTANAS NUEVAS///////////////////////////////////////////////////////
        //
        //
        //
        //
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
           
            
           Cursor.Show();
            
            Configuracion VistaConfiguracion = new Configuracion();

            VistaConfiguracion.Show();

        }         //Creando la Ventana de Configuracion
        private void btnAgregarMAS_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Show();
            }
            catch (Exception)
            {
                throw;
            }
            AgregarContenido agregarContenido = new AgregarContenido();
            agregarContenido.TipoGuardado = tipoGuardado;
            agregarContenido.Show();
            agregarContenido.panelReferencia = cambioPanel;
            
        }            //Creando la Ventana Para AGREGAR nuevos Registros

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Show();
            }
            catch (Exception)
            {
                throw;
            }
            BorrarContenido borrarContenido = new BorrarContenido();
            borrarContenido.panelReferencia = cambioPanel;
            borrarContenido.TraerDatos();
            borrarContenido.Show();
        }

        private void btnHablar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Show();
            }
            catch (Exception)
            {
                throw;
            }
            Process.Start(@"C:\Intel\ACAT\ACATTalk");
        }                //Abriendo la Aplicacion de ACAT
       
        //
        //
        //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////ABRIR/CERRAR PANELES////////////////////////////////////////////////////////
        //
        //
        //
        //
        //
        //
        //
        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelAlimentos, ref panelHome);
            cambioPanel = "alimentos";
            contador = 0;
        }
        private void btnComidas_Click(object sender, EventArgs e)
        {
            string[,] Datos =  Acciones.ObtenerComidas();
            llenadoAUTOMATICO(Datos);
            ocultarVentana(ref panelAutomatico, ref panelAlimentos);
            cambioPanel = "comidas";
            contador = 0;
        }
        private void btnBebidas_Click(object sender, EventArgs e)
        {
            string[,] Datos = Acciones.ObtenerBebidas();
            llenadoAUTOMATICO(Datos);
            ocultarVentana(ref panelAutomatico, ref panelAlimentos);
            cambioPanel = "bebidas";
            contador = 0;
        }
        private void btnPostres_Click(object sender, EventArgs e)
        {
            string[,] Datos = Acciones.ObtenerPostres();
            llenadoAUTOMATICO(Datos);
            ocultarVentana(ref panelAutomatico, ref panelAlimentos);
            cambioPanel = "postres";
            contador = 0;
        }
        //
        //
        //
        //
        //
        //
        //
        // Eventos de los botones Regresar de cada Panel
        private void btnRegresarAlimentos_Click(object sender, EventArgs e)
        {
            Vlongitud = 0;
            restaLongitud = 0;
            cambioPanel = "home";
            contador = 0;
            ocultarVentana(ref panelHome, ref panelAlimentos);
            focus();
        }
        private void btnRegresarPanelActividades_Click(object sender, EventArgs e)
        {
            Vlongitud = 0;
            restaLongitud = 0;
            cambioPanel = "home";
            contador = 0;
            ocultarVentana(ref panelHome, ref panelActividades);
            focus();
        }
        private void btnRegresarEntretenimiento_Click(object sender, EventArgs e)
        {
            Vlongitud = 0;
            restaLongitud = 0;
            cambioPanel = "silla";
            contador = 0;
            cambio = 1;
            ocultarVentana(ref panelSilla, ref panelRUTA);
            focus();
        } //regresar del panel Rutas
        private void btnRegresarRemoto_Click(object sender, EventArgs e)
        {
            Vlongitud = 0;
            restaLongitud = 0;
            cambioPanel = "home";
            contador = 0;
            ocultarVentana(ref panelHome, ref panelControlRemoto);
            focus();
        }
        private void btnRegresarSilla_Click(object sender, EventArgs e)
        {
            Vlongitud = 0;
            restaLongitud = 0;
            cambioPanel = "home";
            contador = 0;
            ocultarVentana(ref panelHome, ref panelSilla);
            cambio = 0;
            focus();
        }
        private void btnRegresarAutomatico_Click(object sender, EventArgs e)
        {
            Vlongitud = 0;
            restaLongitud = 0;
            if (cambioPanel.Equals("comidas") || cambioPanel.Equals("bebidas") || cambioPanel.Equals("postres"))
            {
                cambioPanel = "alimentos";
                contador = 0;
                ocultarVentana(ref panelAlimentos, ref panelAutomatico);
                vaciarAUTOMATICO();
                focus();
            }
            else
            {
                cambioPanel = "home";
                contador = 0;
                ocultarVentana(ref panelHome, ref panelAutomatico);
                vaciarAUTOMATICO();
                focus();
            }
        }
        //
        //
        //
        //
        //
        //
        //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        //////////////////////////////////////ENEVNTOS DE BOTONES SEGUN EN PANEL DONDE SE ENCUENTRAN /////////////////////////////////
        //
        //
        //
        //
        //
        //
        //
        // eventos del panel HOME
        private void btnActividades_Click(object sender, EventArgs e)
        {
            string[,] Datos = Acciones.ObtenerActividades();
            llenadoAUTOMATICO(Datos);
            ventanaAUTOMATICA(ref panelAutomatico, ref panelHome);
            cambioPanel = "actividades";
            contador = 0;

        }
        private void btnEntretenimiento_Click(object sender, EventArgs e)
        {
            string[,] Datos = Acciones.ObtenerEntretenimiento();
            llenadoAUTOMATICO(Datos);
            ventanaAUTOMATICA(ref panelAutomatico, ref panelHome);
            cambioPanel = "entretenimiento";
            contador = 0;
        }
        private void btnControlRemoto_Click(object sender, EventArgs e)
        {
            ventanaAUTOMATICA(ref panelControlRemoto, ref panelHome);
            cambioPanel = "controlremoto";
            contador = 0;
        }
        public async void btnSilla_Click(object sender, EventArgs e)
        {
            

            //String X = await leerAsync();

            Electrodos_Carga_señal hola = new Electrodos_Carga_señal();
            hola.Show();

            //Console.WriteLine(X);

            ocultarVentana(ref panelSilla, ref panelHome);
            cambio = 1;
            cambioPanel = "silla";
            contador = 0;


            try
            {
                Cursor.Position = new Point(830, 89);
            }
            catch
            {
            }

            //cambio especial del swich para cambia a impresion Serial
        }                   //aqui el evento para cambiar a impresion serial
        //
        //
        //
        //
        //
        //
        //
        //eventos del panel AUTOMATICO
        private void imgUNO_Click(object sender, EventArgs e)
        {

            Notificador(0, btnUNO.Text, descripUNO, URL1);
        }

        private void btnUNO_Click(object sender, EventArgs e)
        {
            Notificador(0, btnUNO.Text, descripUNO, URL1);
        }

        private void imgDOS_Click(object sender, EventArgs e)
        {
            Notificador(2, btnDOS.Text, descripDOS, URL2);
        }

        private void btnDOS_Click(object sender, EventArgs e)
        {
            Notificador(2, btnDOS.Text, descripDOS, URL2);
        }

        private void imgTRES_Click(object sender, EventArgs e)
        {
            Notificador(0, btnTRES.Text, descripTRES, URL3);
        }

        private void btnTRES_Click(object sender, EventArgs e)
        {
            Notificador(0, btnTRES.Text, descripTRES, URL3);
        }

        private void imgCUATRO_Click(object sender, EventArgs e)
        {
            Notificador(1, btnCUATRO.Text, descripCUATRO, URL4);
        }

        private void btnCUATRO_Click(object sender, EventArgs e)
        {
            Notificador(1, btnCUATRO.Text, descripCUATRO, URL4);
        }

        private void imgCINCO_Click(object sender, EventArgs e)
        {
            Notificador(0, btnCINCO.Text, descripCINCO, URL5);
        }

        private void btnCINCO_Click(object sender, EventArgs e)
        {
            Notificador(0, btnCINCO.Text, descripCINCO, URL5);
        }

        private void imgSEIS_Click(object sender, EventArgs e)
        {
            Notificador(0, btnSEIS.Text, descripSEIS, URL6);
        }

        private void btnSEIS_Click(object sender, EventArgs e)
        {
            Notificador(0, btnSEIS.Text, descripSEIS, URL6);
        }
        //
        //
        //
        //
        //
        //
        //Eventos del Panel Control Remoto
        //
        //
        //
        //
        //
        //
        //
        //Eventos del panel de  la silla
        private void btnFlechaArriba_Click(object sender, EventArgs e)
        {

        }
        private void btnFlechaDerecha_Click(object sender, EventArgs e)
        {

        }
        private void btnFlechaIzquierda_Click(object sender, EventArgs e)
        {

        }
        private void btnRutas_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelRUTA, ref panelSilla);
            cambio = 0;
            cambioPanel = "rutas";
            contador = 0;
        }
        //
        //
        //
        //
        //
        //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        /////////////////////////////////////////////////////ANIMACIONES//////////////////////////////////////////////////////////////
        //
        //
        //
        //
        //
        //
        //
        //Eventos de Animacion del Sistema
        public  void CambiarTamañoControl(ref Button c)
        {
            animacion = 1;
            alto = c.Height;
            ancho = c.Width;
            X = c.Location.X;
            Y = c.Location.Y;
            c.Height = c.Size.Height + 20;
            c.Width = c.Size.Width + 20;
            c.Location = new Point(c.Location.X - 10, c.Location.Y - 10);
            
        }                   //Animacion para acer mas grande el boton con el Hover
        public  void RegresarTamañoControl(ref Button c)
        {
            if (animacion==1)
            {
                c.Height = alto;
                c.Width = ancho;
                c.Location = new Point(X, Y);
                animacion = 0;
            }
            
            
        }                  //Animacion para regresar el tamano al boton al perder el Hover
        //
        //
        //
        //
        //
        //
        //
        //ANIMACIONES DEL PANEL HOME
        private void btnAlimentos_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnAlimentos);
            btnAlimentos.BackgroundImage = InterfaceTIV.Properties.Resources.btnAlimentosClick;
        }

        private void btnAlimentos_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnAlimentos);
            btnAlimentos.BackgroundImage = InterfaceTIV.Properties.Resources.btnimgAlimentos;
        }

        private void btnActividades_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnActividades);
            btnActividades.BackgroundImage = InterfaceTIV.Properties.Resources.btnActividadesClick;
        }

        private void btnActividades_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnActividades);
            btnActividades.BackgroundImage = InterfaceTIV.Properties.Resources.btnimgActividades;
        }

        private void btnEntretenimiento_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnEntretenimiento);
            btnEntretenimiento.BackgroundImage = InterfaceTIV.Properties.Resources.btnEntretenimientoClick;
        }

        private void btnEntretenimiento_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnEntretenimiento);
            btnEntretenimiento.BackgroundImage = InterfaceTIV.Properties.Resources.btnimgEntretenimiento;
        }

        private void btnControlRemoto_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnControlRemoto);
            btnControlRemoto.BackgroundImage = InterfaceTIV.Properties.Resources.btnControlRemotoClick;
        }

        private void btnControlRemoto_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnControlRemoto);
            btnControlRemoto.BackgroundImage = InterfaceTIV.Properties.Resources.btnimgControl;
        }

        private void btnHablar_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnHablar);
            btnHablar.BackgroundImage = InterfaceTIV.Properties.Resources.btnHablarClick;
        }

        private void btnHablar_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnHablar);
            btnHablar.BackgroundImage = InterfaceTIV.Properties.Resources.btnimgHablar;
        }

        private void btnSilla_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnSilla);
            btnSilla.BackgroundImage = InterfaceTIV.Properties.Resources.btnSillaClick;
        }

        private void btnSilla_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnSilla);
            btnSilla.BackgroundImage = InterfaceTIV.Properties.Resources.btnimgSilla;
        }

        private void btnSeleccion_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnSeleccion);
            btnSeleccion.BackgroundImage = InterfaceTIV.Properties.Resources.btnMensajeClick;

        }

        private void btnSeleccion_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnSeleccion);
            btnSeleccion.BackgroundImage = InterfaceTIV.Properties.Resources.btnimgMensaje;
        }
        //
        //
        //
        //
        //
        //
        //
        //
        //ANIMACION DEL PANEL ALIMENTOS
        private void btnRegresarAlimentos_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnRegresarAlimentos);
            btnRegresarAlimentos.BackgroundImage = InterfaceTIV.Properties.Resources.btnRegresar;
        }

        private void btnRegresarAlimentos_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnRegresarAlimentos);
            btnRegresarAlimentos.BackgroundImage = InterfaceTIV.Properties.Resources.btnRegresar;
        }

        private void btnComidas_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnComidas);
            btnComidas.BackgroundImage = InterfaceTIV.Properties.Resources.btnComidaclick;
        }

        private void btnComidas_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnComidas);
            btnComidas.BackgroundImage = InterfaceTIV.Properties.Resources.btnComida;
        }

        private void btnBebidas_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnBebidas);
            btnBebidas.BackgroundImage = InterfaceTIV.Properties.Resources.btnBebidaClick;
        }

        private void btnBebidas_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnBebidas);
            btnBebidas.BackgroundImage = InterfaceTIV.Properties.Resources.btnBebida;
        }

        private void btnPostres_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnPostres);
            btnPostres.BackgroundImage = InterfaceTIV.Properties.Resources.btnPostreClick;
        }

        private void btnPostres_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnPostres);
            btnPostres.BackgroundImage = InterfaceTIV.Properties.Resources.btnPostre;
        }
        //
        //
        //
        //
        //
        //
        //
        //ANIMACION PANEL DE SILLA
        private void btnRegresarSilla_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnRegresarSilla);
            btnRegresarSilla.BackgroundImage = InterfaceTIV.Properties.Resources.btnRegresar;
        }

        private void btnRegresarSilla_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnRegresarSilla);
            btnRegresarSilla.BackgroundImage = InterfaceTIV.Properties.Resources.btnRegresar;
        }

        private void btnFlechaArriba_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnFlechaArriba);
            btnFlechaArriba.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaArribaClick;
        }

        private void btnFlechaArriba_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnFlechaArriba);
            btnFlechaArriba.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaArriba;
        }

        private void btnFlechaDerecha_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnFlechaDerecha);
            btnFlechaDerecha.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaDerechaClick;
        }

        private void btnFlechaDerecha_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnFlechaDerecha);
            btnFlechaDerecha.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaDerecha;
        }

        private void btnFlechaIzquierda_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnFlechaIzquierda);
            btnFlechaIzquierda.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaIzquierdaClick;
        }

        private void btnFlechaIzquierda_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnFlechaIzquierda);
            btnFlechaIzquierda.BackgroundImage = InterfaceTIV.Properties.Resources.btnFlechaIzquierda;
        }
        private void btnRutas_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnRutas);
        }
        private void btnRutas_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnRutas);
        }
        //
        //
        //
        //
        //
        //
        //
        //ANIMACION DEL PANEL AUTOMATICO
        private void btnRegresarAutomatico_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnRegresarAutomatico);
            btnRegresarAutomatico.BackgroundImage = InterfaceTIV.Properties.Resources.btnRegresar;
        }
        private void btnRegresarAutomatico_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnRegresarAutomatico);
            btnRegresarAutomatico.BackgroundImage = InterfaceTIV.Properties.Resources.btnRegresar;
        }
        private void btnMostrarMasDER_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnMostrarMasDER);
            btnMostrarMasDER.BackgroundImage = InterfaceTIV.Properties.Resources.btnagrgarmasClick;
        }
        private void btnMostrarMasDER_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnMostrarMasDER);
            btnMostrarMasDER.BackgroundImage = InterfaceTIV.Properties.Resources.btnCargarMasDER;
        }
        private void btnMostrarMenosIZQ_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnMostrarMenosIZQ);
            btnMostrarMenosIZQ.BackgroundImage = InterfaceTIV.Properties.Resources.btnRegresarClick;
        }
        private void btnMostrarMenosIZQ_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnMostrarMenosIZQ);
            btnMostrarMenosIZQ.BackgroundImage = InterfaceTIV.Properties.Resources.btnCargarMenosIZQ;
        }
        private void btnAgregarMAS_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnAgregarMAS);
            btnAgregarMAS.BackgroundImage = InterfaceTIV.Properties.Resources.btnAgregar;
        }
        private void btnAgregarMAS_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnAgregarMAS);
            btnAgregarMAS.BackgroundImage = InterfaceTIV.Properties.Resources.btnAgregar;
        }
        private void btnBorrar_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnBorrar);
        }
        private void btnBorrar_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnBorrar);
        }
        private void imgUNO_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnUNO);
            btnUNO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void imgUNO_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnUNO);
            btnUNO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        private void btnUNO_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnUNO);
            btnUNO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void btnUNO_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnUNO);
            btnUNO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        private void imgDOS_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnDOS);
            btnDOS.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void imgDOS_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnDOS);
            btnDOS.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        private void btnDOS_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnDOS);
            btnDOS.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void btnDOS_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnDOS);
            btnDOS.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        private void imgTRES_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnTRES);
            btnTRES.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void imgTRES_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnTRES);
            btnTRES.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        private void btnTRES_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnTRES);
            btnTRES.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void btnTRES_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnTRES);
            btnTRES.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        private void imgCUATRO_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnCUATRO);
            btnCUATRO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void imgCUATRO_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnCUATRO);
            btnCUATRO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        private void btnCUATRO_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnCUATRO);
            btnCUATRO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void btnCUATRO_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnCUATRO);
            btnCUATRO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        private void imgCINCO_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnCINCO);
            btnCINCO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void imgCINCO_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnCINCO);
            btnCINCO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        private void btnCINCO_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnCINCO);
            btnCINCO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void btnCINCO_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnCINCO);
            btnCINCO.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        private void imgSEIS_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnSEIS);
            btnSEIS.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void imgSEIS_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnSEIS);
            btnSEIS.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        private void btnSEIS_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnSEIS);
            btnSEIS.BackgroundImage = InterfaceTIV.Properties.Resources.btnGrisClick;
        }
        private void btnSEIS_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnSEIS);
            btnSEIS.BackgroundImage = InterfaceTIV.Properties.Resources.btnGris;
        }
        //
        //
        //
        //
        //
        //Animacion panel RUTAS
        private void btnRegresarRutas_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnRegresarRutas);
        }

        private void btnRegresarRutas_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnRegresarRutas);
        }

        private void btnIRbaño_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnIRbaño);
        }

        private void btnIRbaño_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnIRbaño);
        }

        private void btnIRhabitacion_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnIRhabitacion);
        }

        private void btnIRhabitacion_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnIRhabitacion);
        }
        private void btnRuta3_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnRuta3);
        }

        private void btnRuta3_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnRuta3);
        }

        private void btnRuta4_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnRuta4);
        }

        private void btnRuta4_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnRuta4);
        }

        private void btnRuta5_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnRuta5);
        }

        private void btnRuta5_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnRuta5);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            BuscarDatosRecargar(cambioPanel);
            focus();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////

        private void btnRuta3_Click(object sender, EventArgs e)
        {
            AgregarRuta();
        }

        private void btnRuta4_Click(object sender, EventArgs e)
        {
            AgregarRuta();
        }

        private void btnRuta5_Click(object sender, EventArgs e)
        {
            AgregarRuta();
        }
        public void AgregarRuta() {

            GuardarRuta guardarruta = new GuardarRuta();
            guardarruta.Show();
            guardarruta.Activate();

        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            Hora.Refresh();
            int a = DateTime.Now.Hour;
            if (a >= 12)
            {
                Hora.Text = DateTime.Now.Hour -12 + ":" + DateTime.Now.Minute.ToString("D2") + " PM";
            }
            else
            {
                Hora.Text = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + " AM";
            }
            
        }

        //
        //
        //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
