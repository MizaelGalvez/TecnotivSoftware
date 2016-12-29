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
    public partial class WebNavegador : Form
    {




        Home Metodos = new Home();


        public WebNavegador()
        {
            InitializeComponent();
        }

        private void btnRegresarNavegador_Click(object sender, EventArgs e)
        {
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
    }
}
