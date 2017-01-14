using InterfaceTIV.Model;
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
            txtNombre.Select();
        }
        public int TipoGuardado { get; set; }
        public string panelReferencia { get; set; }
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"C:\Users\Symonds-Pc\Downloads";
            openFileDialog1.Filter = "IMG files (*.JPG)|*.JPG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imgPreview.BackgroundImage = Properties.Resources.imgNO;
                    filePath = openFileDialog1.FileName;
                    imgPreview.BackgroundImage = Image.FromFile(filePath);
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
            imgPreview.BackgroundImage = Properties.Resources.imgNO;

            if (txtNombre.Text.Equals("") || txtDescripcion.Text.Equals(""))
            {
                MessageBox.Show("Escribir en Ambos Espacios ");
            }
            else
            {
                //Console.WriteLine(filePath);
                try
                {

                    string destinationFile = @"C:\Users\Symonds-Pc\Pictures\" + txtNombre.Text + ".jpg";
                    File.Copy(filePath, destinationFile, true);

                    GuardarDatos(panelReferencia);

                }
                catch (System.IO.IOException ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
                


            }
        }

        private void hoverlogo() {

            try
            {
                Cursor.Position = new Point(30, 30);
            }
            catch
            {
            }

        }

        public void GuardarDatos(string cambioPanel)
        {
            switch (cambioPanel)
            {
                case "comidas":

                    comidas nEntrada = new comidas();
                    nEntrada.lbl_Descripcion = txtDescripcion.Text;
                    nEntrada.lbl_Nombre = txtNombre.Text;
                    nEntrada.img_Ruta = txtNombre.Text;
                    nEntrada.bactivo = true;

                    Acciones.GuardarComida(nEntrada);

                    hoverlogo();
                    this.Close();

                    break;
                case "bebidas":
                    bebidas nEntrada2 = new bebidas();
                    nEntrada2.lbl_Descripcion = txtDescripcion.Text;
                    nEntrada2.lbl_Nombre = txtNombre.Text;
                    nEntrada2.img_Ruta = txtNombre.Text;
                    nEntrada2.bactivo = true;

                    Acciones.GuardarBebidas(nEntrada2);

                    hoverlogo();
                    this.Close();
                    break;
                case "postres":
                    postres nEntrada3 = new postres();
                    nEntrada3.lbl_Descripcion = txtDescripcion.Text;
                    nEntrada3.lbl_Nombre = txtNombre.Text;
                    nEntrada3.img_Ruta = txtNombre.Text;
                    nEntrada3.bactivo = true;

                    Acciones.GuardarPostres(nEntrada3);

                    hoverlogo();
                    this.Close();
                    break;
                case "actividades":
                    actitidades nEntrada4 = new actitidades();
                    nEntrada4.lbl_NombreActividad = txtNombre.Text;
                    nEntrada4.img_Ruta = txtNombre.Text;
                    nEntrada4.bactivo = true;

                    Acciones.GuardarActividades(nEntrada4);

                    hoverlogo();
                    this.Close();
                    break;
                case "entretenimiento":
                    internet nEntrada5 = new internet();
                    nEntrada5.lbl_Url = txtDescripcion.Text;
                    nEntrada5.lbl_Nombre = txtNombre.Text;
                    nEntrada5.img_Ruta = txtNombre.Text;
                    nEntrada5.bactivo = true;

                    Acciones.GuardarInternet(nEntrada5);

                    hoverlogo();
                    this.Close();
                    break;
                case "":
                    break;
                default:
                    break;
            }
        }

        /////////////////////////////////////////////Arrastrar Ventana/////////////////////////////////////////////////////////

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /////////////////////////////////////////////Arrastrar Ventana/////////////////////////////////////////////////////////

    }
}
