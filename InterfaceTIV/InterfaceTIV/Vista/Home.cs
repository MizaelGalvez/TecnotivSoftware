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

namespace InterfaceTIV.Vista
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
          
            Configuracion VistaConfiguracion = new Configuracion();

            VistaConfiguracion.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panelAlimentos.Show();
        }
    }
}
