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
    public partial class GuardarRuta : Form
    {
        Home metodos = new Home();
        public GuardarRuta()
        {
            InitializeComponent();
            txtNombre.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarRuta_MouseHover(object sender, EventArgs e)
        {
            metodos.CambiarTamañoControl(ref btnIniciarRuta);
        }

        private void btnIniciarRuta_MouseLeave(object sender, EventArgs e)
        {
            metodos.RegresarTamañoControl(ref btnIniciarRuta);
        }

        private void btnGuardarRuta_MouseHover(object sender, EventArgs e)
        {
            metodos.CambiarTamañoControl(ref btnGuardarRuta);
        }

        private void btnGuardarRuta_MouseLeave(object sender, EventArgs e)
        {
            metodos.RegresarTamañoControl(ref btnGuardarRuta);
        }

        private void btnIniciarRuta_Click(object sender, EventArgs e)
        {
            progressBar1.Increment(100);
        }

        private void btnGuardarRuta_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Position = new Point(80, 75);
            }
            catch
            {
            }
            this.Close();
        }
    }
}
