using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTIV.Vista
{
    public partial class AgregarContenido : Form
    {



        Home metodos = new Home();
        string filePath = "";
        

        public AgregarContenido()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
        }
        public int TipoGuardado { get; set; }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGmail_Click(object sender, EventArgs e)
        {
            metodos.abrirNavgador(@"https://www.gmail.com/");
        }

        private void btnOutlook_Click(object sender, EventArgs e)
        {
            metodos.abrirNavgador(@"https://www.outlook.com/");
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\Symonds-Pc\Downloads";
            openFileDialog1.Filter = "IMG files (*.JPG)|*.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath = openFileDialog1.FileName;
                    string destinationFile = @"C:\Users\Symonds-Pc\Downloads" + txtNombre.Text + ".jpg";
                    File.Move(filePath, destinationFile);

                    imgPreview.BackgroundImage = Image.FromFile(destinationFile);
                    //Console.WriteLine(filePath);
                    btnGuardar.Enabled = true;
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Escribir en Ambos Espacios ");
            }
            else
            {
                Console.WriteLine(filePath);
                
                try
                {
                    System.IO.File.Delete(filePath);
                }
                catch (System.IO.IOException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                
            }
        }
    }
}
