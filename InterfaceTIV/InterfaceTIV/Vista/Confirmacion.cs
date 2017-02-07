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
    public partial class Confirmacion : Form
    {
        private int alto;
        private int ancho;
        private int animacion = 0;
        private int X;
        private int Y;

        public Confirmacion()
        {
            try
            {
                Cursor.Position = new Point(500, 350);
            }
            catch
            {
            }
            this.SetDesktopLocation(300, 200);
            InitializeComponent();
            Home home = new Home();
        }
        

        public void CambiarTamañoControl(ref Button c)
        {
            animacion = 1;
            alto = c.Height;
            ancho = c.Width;
            X = c.Location.X;
            Y = c.Location.Y;
            c.Height = c.Size.Height + 20;
            c.Width = c.Size.Width + 20;
            c.Location = new Point(c.Location.X - 10, c.Location.Y - 10);

        }                   //Animacion para acer mas grande el boton con el Hover
        public void RegresarTamañoControl(ref Button c)
        {
            if (animacion == 1)
            {
                c.Height = alto;
                c.Width = ancho;
                c.Location = new Point(X, Y);
                animacion = 0;
            }
            
        }



        private void btnGuardarRuta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarRuta_MouseHover(object sender, EventArgs e)
        {
            CambiarTamañoControl(ref btnGuardarRuta);
        }

        private void btnGuardarRuta_MouseLeave(object sender, EventArgs e)
        {
            RegresarTamañoControl(ref btnGuardarRuta);
        }
    }
}
