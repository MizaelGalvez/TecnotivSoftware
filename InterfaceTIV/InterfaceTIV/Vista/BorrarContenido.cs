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
    public partial class BorrarContenido : Form
    {
    public string panelReferencia { get; set; }

        
        private string[,] Datos;

        public BorrarContenido()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
                img = Datos[incremento, 1];
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
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[0, 1] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[0, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
        }

        private void imgDOS_Click(object sender, EventArgs e)
        {
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[1, 1] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[1, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
        }

        private void imgTRES_Click(object sender, EventArgs e)
        {
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[2, 1] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[2, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
        }

        private void imgCUATRO_Click(object sender, EventArgs e)
        {
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[3, 1] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[3, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
        }

        private void imgCINCO_Click(object sender, EventArgs e)
        {
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[4, 1] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[4, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
        }

        private void imgSEIS_Click(object sender, EventArgs e)
        {
            imgBORRAR.BackgroundImage = Image.FromFile(@"C:\Users\Symonds-Pc\Pictures\" + Datos[6, 1] + ".jpg");  //TODO AUTOMATIZAR LA RUTA AUTOMATICA A IMAGENES EL LA PC
            lblBORRAR.Text = Datos[6, 0];
            imgBORRAR.Show();
            lblBORRAR.Show();
            btnEliminar.Enabled = true;
        }
    }
}
