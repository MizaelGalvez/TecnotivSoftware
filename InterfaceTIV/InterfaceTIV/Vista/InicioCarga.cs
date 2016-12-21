using InterfaceTIV.Controladores;
using InterfaceTIV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            lblBienvenida.Text = "Bienvenido " + Acciones.usuario(1);
            var usuario = Acciones.usuario(1);
            var contraseña = Acciones.contraseña(1);

            MetodosHTTP primer = new MetodosHTTP();
            primer.user = usuario;
            primer.pass = contraseña;
            var activo = primer.VerificarUsuario();

            this.Show();

            verificar(activo);


            
        }
        
        private void verificar(string bActivo) {

            if (bActivo.Equals("1"))
            {


                progressBar1.Increment(100);


                Home HOME = new Home();
                HOME.Show();
                HOME.SetDesktopLocation(0, 0);
                HOME.Activate();


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

            Acciones.Guardar(nEntrada);


            verificar(activo);
            
        }
    }
}
