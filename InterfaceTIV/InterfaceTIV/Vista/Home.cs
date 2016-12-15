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
            panelHome.Hide();
            panelAlimentos.Show();
            panelAlimentos.Location = new Point(42, 90);
            focus();
            
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelActividades.Show();
            panelActividades.Location = new Point(42, 90);

            focus();

        }

        private void btnEntretenimiento_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelEntretenimiento.Show();
            panelEntretenimiento.Location = new Point(42, 90);

            focus();
        }

        private void btnControlRemoto_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelControlRemoto.Show();
            panelControlRemoto.Location = new Point(42, 90);

            focus();
        }

        private void btnSilla_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelSilla.Show();
            panelSilla.Location = new Point(42, 90);
            cambio = 1;
            focus();
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

        
    }
}
