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
using System.IO.Ports;
using InterfaceTIV.Model;

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
        int cambioPanel = 0;                                                       //variable para controlar el panel automatico, si regresara atras o al de alimentos segun sea necesario
        //
        //
        //
        int altoBTNregresar=0;
        int anchoBTNregresar=0;

        int altoBTNautomatico=0;
        int anchoBTNautomatico=0;

        int altoBTNmostrarmas=0;
        int anchoBTNmostrarmas=0;

        int altoBTNagregar=0;
        int anchoBTNagragar=0;
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
            obtenerTamaños();

        }
        public void focus(){ txtComando.Text = ""; txtComando.Select();}           //Metodo Llamado en Cada Accion para regresar al Focus donde se reciben los parametros de la diadema
        public void enviar(string valor) {
            
                Console.WriteLine(valor);
                LecturaSerial enviardatos = new LecturaSerial();
                enviardatos.sensor = cambio;
                enviardatos.valor = valor;
                enviardatos.Lectura();
                focus();
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
        }         //Eventos de enviar comandos recibidos cuando el txt cambia de Valor.
        private void Home_Click(object sender, EventArgs e)
        {
            focus();
        }                     //Eventos de focus al elemento necesario, cuando da click en otra area de la ventana
        private void alimentoNotificador(int activo, string Texto)
        {

            MetodosHTTP datos = new MetodosHTTP();
            datos.user = Acciones.usuario(1);
            datos.idAlimento = 0;
            datos.txtAlimento = "";
            datos.idActividad = activo;
            datos.txtActividad = Texto;
            datos.idtexto = 0;
            datos.txtTecto = "";
            datos.EnviarNotificacion();

        }              //metodo para enviar el datos del texto del boton. sera necesario adaptarlo para utilizar como modificador 
        public void ventanaAUTOMATICA(ref Panel Abrir, ref Panel Cerrar)
        {
            Cerrar.Hide();
            Abrir.Show();
            Abrir.Location = new Point(2, 55);
            focus();

        }           //Abrir Ventana Automatica con los valores necesarios para llenarla            
        //
        //
        //
        //PRUEBAAAAA TENER Y REGRESAR TAMAÑOS
        public void obtenerTamaños() {
            this.altoBTNregresar = btnRegresarAutomatico.Height;
            this.anchoBTNregresar = btnRegresarAutomatico.Width;

            this.altoBTNautomatico = btnUNO.Height;
            this.anchoBTNautomatico = btnUNO.Width;

            this.altoBTNmostrarmas = btnMostrarMasDER.Height;
            this.anchoBTNmostrarmas = btnMostrarMasDER.Width;

            this.altoBTNagregar = btnAgregarMAS.Height;
            this.anchoBTNagragar = btnAgregarMAS.Width;
        }
        public void ajustarTamaños()
        {
            btnAgregarMAS.Height=altoBTNagregar;
            btnAgregarMAS.Width=anchoBTNagragar;
        }
        //PRUEBAAAAAA
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
          
            Configuracion VistaConfiguracion = new Configuracion();

            VistaConfiguracion.Show();

        }         //Creando la Ventana de Configuracion
        //
        //
        //
        //
        //
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
        }
        private void btnComidas_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelAutomatico, ref panelAlimentos);
            // alimentoNotificador(1, btnComidas.Text);
            cambioPanel = 1;
        }
        private void btnBebidas_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelAutomatico, ref panelAlimentos);
            //alimentoNotificador(2, btnBebidas.Text);
            cambioPanel = 1;
        }
        private void btnPostres_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelAutomatico, ref panelAlimentos);
            //alimentoNotificador(3, btnPostres.Text);
            cambioPanel = 1;
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
            ocultarVentana(ref panelHome, ref panelAlimentos);
            focus();
        }
        private void btnRegresarPanelActividades_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelHome, ref panelActividades);
            focus();
        }
        private void btnRegresarEntretenimiento_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelHome, ref panelEntretenimiento);
            focus();
        }
        private void btnRegresarRemoto_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelHome, ref panelControlRemoto);
            focus();
        }
        private void btnRegresarSilla_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelHome, ref panelSilla);
            cambio = 0;
            focus();
        }
        private void btnRegresarAutomatico_Click(object sender, EventArgs e)
        {
            if (cambioPanel==1)
            {
                ocultarVentana(ref panelAlimentos, ref panelAutomatico);
                cambioPanel = 0;
                focus();
            }
            else
            {
                ocultarVentana(ref panelHome, ref panelAutomatico);
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
            ventanaAUTOMATICA(ref panelAutomatico, ref panelHome);

        }
        private void btnEntretenimiento_Click(object sender, EventArgs e)
        {
            ventanaAUTOMATICA(ref panelAutomatico, ref panelHome);
        }
        private void btnControlRemoto_Click(object sender, EventArgs e)
        {
            ventanaAUTOMATICA(ref panelControlRemoto, ref panelHome);
        }
        private void btnSilla_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelSilla, ref panelHome);
            cambio = 1;

            try
            {
                Cursor.Position = new Point(830, 89);
            }
            catch
            {
                Console.Write("Error clase MovimientoInterface al Mover Mause");
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
        //eventos del panel Actividades
        //
        //
        //
        //
        //
        //
        //
        //eventos del panel de Entretenimiento
        //
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
            c.Height = c.Size.Height + 20;
            c.Width = c.Size.Width + 20;
            c.Location = new Point(c.Location.X - 10, c.Location.Y - 10);
            
        }                   //Animacion para acer mas grande el boton con el Hover
        public  void RegresarTamañoControl(ref Button c)
        {
            c.Height = c.Size.Height - 20;
            c.Width = c.Size.Width - 20;
            c.Location = new Point(c.Location.X + 10, c.Location.Y + 10);
            

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
            btnMostrarMasDER.BackgroundImage = InterfaceTIV.Properties.Resources.btnCargarMasDER;
        }
        private void btnMostrarMasDER_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnMostrarMasDER);
            btnMostrarMasDER.BackgroundImage = InterfaceTIV.Properties.Resources.btnCargarMasDER;
        }
        private void btnMostrarMenosIZQ_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnMostrarMenosIZQ);
            btnMostrarMenosIZQ.BackgroundImage = InterfaceTIV.Properties.Resources.btnCargarMenosIZQ;
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
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
