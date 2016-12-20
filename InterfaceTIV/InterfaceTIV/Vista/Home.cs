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

        int cambio = 0;
        public Home()
        {
            InitializeComponent();
            focus();
            
        }

        public void focus(){ txtComando.Text = ""; txtComando.Select();}
        public void enviar() {

                string valor = txtComando.Text;
                Console.WriteLine(valor);
                LecturaSerial enviardatos = new LecturaSerial();
                enviardatos.sensor = cambio;
                enviardatos.valor = valor;
                enviardatos.Lectura();

                focus();
        }
        public void ocultarVentana(ref Panel control)
        {
            panelHome.Hide();
            control.Show();
            control.Location = new Point(42, 90);
            focus();

        }




        //entrar a la ventana de configuracion
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
          
            Configuracion VistaConfiguracion = new Configuracion();

            VistaConfiguracion.Show();

        }

        //
        //
        //
        // eventos del panel HOME
        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelAlimentos);
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelActividades);

        }

        private void btnEntretenimiento_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelEntretenimiento);
        }

        private void btnControlRemoto_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelControlRemoto);
        }

        private void btnSilla_Click(object sender, EventArgs e)
        {
            ocultarVentana(ref panelSilla);
            cambio = 1;
        }
        
        //
        //
        //
        // eventos de panel de Alimentos
        private void btnRegresarAlimentos_Click(object sender, EventArgs e)
        {
            panelAlimentos.Hide();
            panelHome.Show();
            focus();
        }
        private void btnComidas_Click(object sender, EventArgs e)
        {
            alimentoNotificador(1, btnComidas.Text);
        }
        private void btnBebidas_Click(object sender, EventArgs e)
        {
            alimentoNotificador(2, btnBebidas.Text);
        }
        private void btnPostres_Click(object sender, EventArgs e)
        {
            alimentoNotificador(3, btnPostres.Text);
        }
        //
        //
        //
        //eventos del panel Actividades
        private void btnRegresarPanelActividades_Click(object sender, EventArgs e)
        {
            panelActividades.Hide();
            panelHome.Show();

            focus();
        }
        
        //
        //
        //
        //eventos del panel de Entretenimiento
        private void btnRegresarEntretenimiento_Click(object sender, EventArgs e)
        {
            panelEntretenimiento.Hide();
            panelHome.Show();

            focus();
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelWeb.Show();
            panelWeb.Location = new Point(12, 13);

            focus();
        }
        
        //
        //
        //
        //Eventos del Panel Control Remoto
        private void btnRegresarRemoto_Click(object sender, EventArgs e)
        {
            panelControlRemoto.Hide();
            panelHome.Show();

            focus();
        }
        
        //
        //
        //
        //Eventos del panel de  la silla
        private void btnRegresarSilla_Click(object sender, EventArgs e)
        {
            panelSilla.Hide();
            panelHome.Show();
            cambio = 0;

            focus();
        }


        //
        //
        //
        //Eventos de enviar comandos recibidos
       
        private void txtComando_TextChanged(object sender, EventArgs e)
        {
            enviar();
        }
        
        //
        //
        //
        //Eventos de focus al elemento necesario

        private void Home_Click(object sender, EventArgs e)
        {
            focus();
        }
        //
        //
        //
        //metodo para enviar el datos del texto del boton.
        private void alimentoNotificador(int activo, string Texto) {

            MetodosHTTP datos = new MetodosHTTP();
            datos.user = Acciones.usuario(1);
            datos.idAlimento = 0;
            datos.txtAlimento = "";
            datos.idActividad = activo;
            datos.txtActividad = Texto;
            datos.idtexto = 0;
            datos.txtTecto = "";
            datos.EnviarNotificacion();

        }



        //
        //
        //
        //Eventos de Animacion del Sistema

        public static void CambiarTamañoControl(ref Button c)
        {
            c.Height = c.Size.Height + 20;
            c.Width = c.Size.Width + 20;
            c.Location = new Point(c.Location.X - 10, c.Location.Y - 10);
            
        }
        public static void RegresarTamañoControl(ref Button c)
        {
            c.Height = c.Size.Height - 20;
            c.Width = c.Size.Width - 20;
            c.Location = new Point(c.Location.X + 10, c.Location.Y + 10);

        }


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
            btnSeleccion.Height = 112;
            btnSeleccion.Width = 128;
            btnSeleccion.Location =  new Point(659, 282);


            btnSeleccion.BackgroundImage = InterfaceTIV.Properties.Resources.btnMensajeClick;

        }

        private void btnSeleccion_MouseLeave(object sender, EventArgs e)
        {
            btnSeleccion.Height = 92;
            btnSeleccion.Width = 108;
            btnSeleccion.Location = new Point(669, 292);



            btnSeleccion.BackgroundImage = InterfaceTIV.Properties.Resources.btnimgMensaje;
        }
    }
}
