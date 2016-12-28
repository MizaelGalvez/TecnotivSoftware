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
    public partial class AgregarContenido : Form
    {
        public AgregarContenido()
        {
            InitializeComponent();
            
        }
        public int TipoGuardado { get; set; }










        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
