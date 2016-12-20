using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceTIV.Model;
using InterfaceTIV.Controladores;

namespace InterfaceTIV.Vista
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
            comboxIdioma.SelectedIndex = Acciones.idioma(1)-1;
            txtNombreUsuario.Text = Acciones.usuario(1);
            txtNombreUsuario.Focus();

            radiobtnDiadema.Checked = Acciones.isChecked_diadema(1);
            radiobtnSilla.Checked = Acciones.isChecked_silla(1);
            radiobtnMause.Checked = Acciones.isChecked_mause(1);
            radiobtnSensor.Checked = Acciones.isChecked_sensor(1);


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Increment(45);

            configuracion nEntrada = new configuracion();
            nEntrada.idConfiguracion = 1;
            nEntrada.lbl_idioma = comboxIdioma.SelectedIndex + 1;
            nEntrada.lbl_Usuario = txtNombreUsuario.Text;
            nEntrada.txtContraseña = Acciones.contraseña(1);


            if (radiobtnDiadema.Checked) { nEntrada.uso_diadema = 1; } else { nEntrada.uso_diadema = 0; }
            if (radiobtnSilla.Checked) { nEntrada.uso_silla = 1; } else { nEntrada.uso_silla = 0; }
            if (radiobtnMause.Checked) { nEntrada.uso_Mause = 1; } else { nEntrada.uso_Mause = 0; }
            if (radiobtnSensor.Checked) { nEntrada.uso_Sensor = 1; } else { nEntrada.uso_Sensor = 0; }
            
            Acciones.Guardar(nEntrada);

            progressBar1.Increment(85);

            MessageBox.Show("Registro Modificado", "Guardando...");

            progressBar1.Increment(100);

            progressBar1.Visible = false;

            this.Close();


        }
    }
}
