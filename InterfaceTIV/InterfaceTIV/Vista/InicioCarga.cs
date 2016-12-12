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

            lblBienvenida.Text = Acciones.usuario(1);

            progressBar1.Visible = true;
            progressBar1.Increment(10);
            progressBar1.Increment(45);
            progressBar1.Increment(85);
            progressBar1.Increment(100);
            
            
            
        }
    }
}
