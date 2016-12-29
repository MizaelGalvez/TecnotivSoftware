using InterfaceTIV.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTIV.Vista
{
    public partial class WebNavegador : Form
    {




        Home Metodos = new Home();


        public WebNavegador()
        {
            InitializeComponent();
            TopMost = true;
            txtEnviar.Select();
            Size = new System.Drawing.Size(2000, this.Height);
        }
        public void focus()
        {
            txtEnviar.Text = "";
            txtEnviar.Select();
        }
        public void enviar(string valor)
        {
            Console.WriteLine(valor);
            LecturaSerial enviardatos = new LecturaSerial();
            enviardatos.valor = valor;
            enviardatos.Lectura();
            focus();
        }
        private void btnRegresarNavegador_Click(object sender, EventArgs e)
        {
            foreach (Process proceso in Process.GetProcesses())
            {
                if (proceso.ProcessName == "chrome")
                {
                    proceso.Kill();
                }
            }
            this.Close();
            
        }

        private void btnRegresarNavegador_MouseHover(object sender, EventArgs e)
        {
            Metodos.CambiarTamañoControl(ref btnRegresarNavegador);
        }

        private void btnRegresarNavegador_MouseLeave(object sender, EventArgs e)
        {
            Metodos.RegresarTamañoControl(ref btnRegresarNavegador);
        }

        private void txtEnviar_TextChanged(object sender, EventArgs e)
        {
            enviar(txtEnviar.Text);
        }
        
    }
}
