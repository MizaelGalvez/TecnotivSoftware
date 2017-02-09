using InterfaceTIV.Controladores;
using InterfaceTIV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTIV.Vista
{
    public partial class InicioCarga : Form
    {
        public InicioCarga()
        {
            InitializeComponent();
            
            var usuario = Acciones.usuario(1);
            var contraseña = Acciones.contraseña(1);
            

            MetodosHTTP primer = new MetodosHTTP();
            primer.user = usuario;
            primer.pass = contraseña;
            Console.WriteLine(usuario,contraseña);
            var activo = primer.VerificarUsuario();

            this.Show();

            verificar(activo);


            
        }
        
        private void verificar(string bActivo) {

            if (bActivo.Equals("1"))
            {


                progressBar1.Increment(100);


                ReconocimeintoVoz TECNOTIV = new ReconocimeintoVoz();
                TECNOTIV.Show();
                
                this.Close();


            }
        }
        

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
           

            var usuario = txtUsuario.Text;
            var contraseña = txtContraseña.Text;

            MetodosHTTP primer = new MetodosHTTP();

                progressBar1.Visible = true;
                progressBar1.Increment(10);

            primer.user = usuario;

                progressBar1.Increment(45);

            primer.pass = contraseña;

                progressBar1.Increment(85);

            var activo =  primer.VerificarUsuario();

            configuracion nEntrada = new configuracion();

            nEntrada.idConfiguracion = 1;
            nEntrada.lbl_Usuario = txtUsuario.Text;
            nEntrada.txtContraseña = txtContraseña.Text;
            nEntrada.lbl_idioma = 1;                             //TODO: colocar un combo box para seleccionar idioma, español o ingles
            nEntrada.uso_diadema = 0;
            nEntrada.uso_Mause = 0;
            nEntrada.uso_Sensor = 0;
            nEntrada.uso_silla = 1;

            Acciones.Guardar(nEntrada);


            verificar(activo);
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "http://www.tecnotiv.com/");
        }

        /////////////////////////////////////////////Arrastrar Ventana/////////////////////////////////////////////////////////

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /////////////////////////////////////////////Arrastrar Ventana/////////////////////////////////////////////////////////

    }
}
