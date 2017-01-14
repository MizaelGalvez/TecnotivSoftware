using InterfaceTIV.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceTIV.Vista
{
    public partial class BorrarContenido : Form
    {
    public string panelReferencia { get; set; }
        int idborrar;
        string Nombre;
        string Descripcion;
        string Ruta;
        string url;

        
        private string[,] Datos;

        public BorrarContenido()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Position = new Point(30, 30);
            }
            catch
            {
            }
            this.Close();
        }

        public void TraerDatos() {
            switch (panelReferencia)
            {
                case "comidas":
                    Datos = Acciones.ObtenerComidas();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "bebidas":

                    Datos = Acciones.ObtenerBebidas();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "postres":

                    Datos = Acciones.ObtenerPostres();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "actividades":

                    Datos = Acciones.ObtenerActividades();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "entretenimiento":

                    Datos = Acciones.ObtenerEntretenimiento();
                    llenadoAUTOMATICO(Datos);
                    break;
                default:
                    break;
            }
        }
        
        public void llenadoAUTOMATICO(string[,] Datos)
        {

            
            string img;
            int longitud = Datos.GetLength(0);
            int incremento = 0;

            lblBORRAR.Hide();
            imgBORRAR.Hide();

            lblUNO.Hide();
            lblDOS.Hide();
            lblTRES.Hide();
            lblCUATRO.Hide();
            lblCINCO.Hide();
            lblSEIS.Hide();
            lblSIETE.Hide();
            lblOCHO.Hide();
            lblNUEVE.Hide();
            lblDIEZ.Hide();
            lblONCE.Hide();
            lblDOCE.Hide();
            lblTRECE.Hide();
            lblCATORCE.Hide();
            lblQUINCE.Hide();
            imgUNO.Hide();
            imgDOS.Hide();
            imgTRES.Hide();
            imgCUATRO.Hide();
            imgCINCO.Hide();
            imgSEIS.Hide();
            imgSIETE.Hide();
            imgOCHO.Hide();
            imgNUEVE.Hide();
            imgDIEZ.Hide();
            imgONCE.Hide();
            imgDOCE.Hide();
            imgTRECE.Hide();
            imgCATORCE.Hide();
            imgQUINCE.Hide();


            if (longitud >= 1)
            {
                lblUNO.Show();
                lblUNO.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgUNO.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgUNO.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 2)
            {
                lblDOS.Show();
                lblDOS.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgDOS.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgDOS.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 3)
            {
                lblTRES.Show();
                lblTRES.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgTRES.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgTRES.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 4)
            {
                lblCUATRO.Show();
                lblCUATRO.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgCUATRO.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgCUATRO.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 5)
            {
                lblCINCO.Show();
                lblCINCO.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgCINCO.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgCINCO.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 6)
            {
                lblSEIS.Show();
                lblSEIS.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgSEIS.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgSEIS.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 7)
            {
                lblSIETE.Show();
                lblSIETE.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgSIETE.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgSIETE.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 8)
            {
                lblOCHO.Show();
                lblOCHO.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgOCHO.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgOCHO.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 9)
            {
                lblNUEVE.Show();
                lblNUEVE.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgNUEVE.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgNUEVE.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 10)
            {
                lblDIEZ.Show();
                lblDIEZ.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgDIEZ.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgDIEZ.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 11)
            {
                lblONCE.Show();
                lblONCE.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgONCE.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgONCE.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 12)
            {
                lblDOCE.Show();
                lblDOCE.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgDOCE.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgDOCE.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 13)
            {
                lblTRECE.Show();
                lblTRECE.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgTRECE.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgTRECE.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 14)
            {
                lblCATORCE.Show();
                lblCATORCE.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgCATORCE.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgCATORCE.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
            if (longitud >= 15)
            {
                lblQUINCE.Show();
                lblQUINCE.Text = Datos[incremento, 0];
                img = Datos[incremento, 0];
                try
                {
                    imgQUINCE.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + img + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
                    imgQUINCE.Show();
                }
                catch (Exception)
                {
                    throw;
                }
                incremento++;
            }
        }

        private void imgUNO_Click(object sender, EventArgs e)
        {
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[0, 0] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[0, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
            idborrar = Convert.ToInt32(Datos[0, 4]);
            Nombre = Datos[0, 0];
            Descripcion = Datos[0, 2];
            Ruta = Datos[0, 1];
        }

        private void imgDOS_Click(object sender, EventArgs e)
        {
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[1, 0] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[1, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
            idborrar = Convert.ToInt32(Datos[1, 4]);
            Nombre = Datos[1, 0];
            Descripcion = Datos[1, 2];
            Ruta = Datos[1, 1];
        }

        private void imgTRES_Click(object sender, EventArgs e)
        {
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[2, 0] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[2, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
            idborrar = Convert.ToInt32(Datos[2, 4]);
            Nombre = Datos[3, 0];
            Descripcion = Datos[3, 2];
            Ruta = Datos[3, 1];
        }

        private void imgCUATRO_Click(object sender, EventArgs e)
        {
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[3, 0] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[3, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
            idborrar = Convert.ToInt32(Datos[3, 4]);
            Nombre = Datos[3, 0];
            Descripcion = Datos[3, 2];
            Ruta = Datos[3, 1];
        }

        private void imgCINCO_Click(object sender, EventArgs e)
        {
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[4, 0] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[4, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
            idborrar = Convert.ToInt32(Datos[4, 4]);
            Nombre = Datos[4, 0];
            Descripcion = Datos[4, 2];
            Ruta = Datos[4, 1];
        }

        private void imgSEIS_Click(object sender, EventArgs e)
        {
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[6, 0] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[5, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
            idborrar = Convert.ToInt32(Datos[5, 4]);
            Nombre = Datos[5, 0];
            Descripcion = Datos[5, 2];
            Ruta = Datos[5, 1];
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (panelReferencia)
            {
                case "comidas":
                    comidas nEntrada = new comidas();
                    nEntrada.bactivo = false;
                    nEntrada.idComidas = idborrar;
                    nEntrada.lbl_Nombre = Nombre;
                    nEntrada.lbl_Descripcion = Descripcion;
                    nEntrada.img_Ruta = Ruta;
                    Acciones.EliminarComidas(nEntrada);

                    Datos = Acciones.ObtenerComidas();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "bebidas":
                    bebidas nEntrada2 = new bebidas();
                    nEntrada2.bactivo = false;
                    nEntrada2.idBebidas = idborrar;
                    nEntrada2.lbl_Nombre = Nombre;
                    nEntrada2.lbl_Descripcion = Descripcion;
                    nEntrada2.img_Ruta = Ruta;
                    Acciones.EliminarBebidas(nEntrada2);

                    Datos = Acciones.ObtenerBebidas();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "postres":
                    postres nEntrada3 = new postres();
                    nEntrada3.bactivo = false;
                    nEntrada3.idPostres = idborrar;
                    nEntrada3.lbl_Nombre = Nombre;
                    nEntrada3.lbl_Descripcion = Descripcion;
                    nEntrada3.img_Ruta = Ruta;
                    Acciones.EliminarPostres(nEntrada3);

                    Datos = Acciones.ObtenerPostres();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "actividades":
                    actitidades nEntrada4 = new actitidades();
                    nEntrada4.bactivo = false;
                    nEntrada4.idActitidades = idborrar;
                    Acciones.EliminarActividades(nEntrada4);
                    nEntrada4.lbl_NombreActividad = Nombre;
                    nEntrada4.img_Ruta = Ruta;

                    Datos = Acciones.ObtenerActividades();
                    llenadoAUTOMATICO(Datos);
                    break;
                case "entretenimiento":
                    internet nEntrada5 = new internet();
                    nEntrada5.bactivo = false;
                    nEntrada5.idInternet = idborrar;
                    nEntrada5.lbl_Nombre = Nombre;
                    nEntrada5.lbl_Url = Descripcion;
                    nEntrada5.img_Ruta = Ruta;
                    Acciones.EliminarEntretenimiento(nEntrada5);

                    Datos = Acciones.ObtenerEntretenimiento();
                    llenadoAUTOMATICO(Datos);
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
