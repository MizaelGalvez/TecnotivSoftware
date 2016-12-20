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
using InterfaceTIV.Controladores;
using System.IO.Ports;
using InterfaceTIV.Model;

namespace InterfaceTIV.Vista
{
    public partial class Home : Form
    {

        int cambio = 0;                                                            //Variable para el Swicheo de diadema, ratos, silla etc...
        int cambioPanel = 0;                                                       //variable para controlar el panel automatico, si regresara atras o al de alimentos segun sea necesario
        public Home()
        {
            InitializeComponent();
            focus();
            
        }

        public void focus(){ txtComando.Text = ""; txtComando.Select();}           //Metodo Llamado en Cada Accion para regresar al Focus donde se reciben los parametros de la diadema
        public void enviar() {

                string valor = txtComando.Text;
                Console.WriteLine(valor);
                LecturaSerial enviardatos = new LecturaSerial();
                enviardatos.sensor = cambio;
                enviardatos.valor = valor;
                enviardatos.Lectura();

                focus();
        }                                                   //Evento para enviar los datos recividos por Diadema y canalizarlos a movimiento mause o impresion Serial
        public void ocultarVentana(ref Panel Abrir, ref Panel Cerrar)
        {
            Cerrar.Hide();
            Abrir.Show();
            Abrir.Location = new Point(2, 55);
            focus();

        }           //Evento para ocultar Ventana Home y Mostrar la Deseada            
        private void txtComando_TextChanged(object sender, EventArgs e)
        {
            enviar();
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



        

        //entrar a la ventana de configuracion
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
          
            Configuracion VistaConfiguracion = new Configuracion();

            VistaConfiguracion.Show();

        }         //Creando la Ventana de Configuracion



        ///////////////////////////////////////////////////ABRIR/CERRAR VENTANAS//////////////////////////////////////////////////////////////
        //
        //
        //
        //
        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelAlimentos, ref panelHome);
        }
        //
        //
        // eventos de panel de Alimentos para Abrir otros Paneles
        private void btnRegresarAlimentos_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelHome, ref panelAlimentos);
            focus();
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
        // Eventos de los botones Regresar de cada Panel
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
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////




        //
        //
        //
        // eventos del panel HOME

        private void btnActividades_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelAutomatico, ref panelHome);

        }

        private void btnEntretenimiento_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelAutomatico, ref panelHome);
        }

        private void btnControlRemoto_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelControlRemoto, ref panelHome);
        }

        private void btnSilla_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelSilla, ref panelHome);
            cambio = 1;                                                           //cambio especial del swich para cambia a impresion Serial
        }                   //aqui el evento para cambiar a impresion serial

        
        //
        //
        //
        //eventos del panel Actividades
        
        //
        //
        //
        //eventos del panel de Entretenimiento
        
        //
        //
        //
        //Eventos del Panel Control Remoto
        
        //
        //
        //
        //Eventos del panel de  la silla






        /////////////////////////////////////////////////////ANIMACIONES//////////////////////////////////////////////////////////////
        //
        //
        //Eventos de Animacion del Sistema
        //
        public static void CambiarTamañoControl(ref Button c)
        {
            c.Height = c.Size.Height + 20;
            c.Width = c.Size.Width + 20;
            c.Location = new Point(c.Location.X - 10, c.Location.Y - 10);
            
        }                   //Animacion para acer mas grande el boton con el Hover
        public static void RegresarTamañoControl(ref Button c)
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
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
