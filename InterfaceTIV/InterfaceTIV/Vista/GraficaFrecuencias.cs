using Emotiv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InterfaceTIV.Vista
{
    public partial class GraficaFrecuencias : Form
    {


        static int userID = -1;
        //static string filename = "PromediodeFrecuencias.csv";
        // static TextWriter file = new StreamWriter(filename, false);
        
        double[] AF3 = { 0, 0, 0, 0, 0};
        double[] AF4 = { 0, 0, 0, 0, 0 };
        double[] T7 = { 0, 0, 0, 0, 0 };
        double[] T8 = { 0, 0, 0, 0, 0 };
        double[] PZ = { 0, 0, 0, 0, 0 };



        public GraficaFrecuencias()
        {
            InitializeComponent();
            this.Show();
            this.SetDesktopLocation(0, 62);

            GraficaT7.ChartAreas[0].AxisY.Interval = 5;
            GraficaT8.ChartAreas[0].AxisY.Interval = 5;
            GraficaAF3.ChartAreas[0].AxisY.Interval = 5;
            GraficaAF4.ChartAreas[0].AxisY.Interval = 5;
            GraficaPZ.ChartAreas[0].AxisY.Interval = 5;
            
            GraficaT7.ChartAreas[0].AxisY.Maximum = 40;
            GraficaT8.ChartAreas[0].AxisY.Maximum = 40;
            GraficaAF3.ChartAreas[0].AxisY.Maximum = 40;
            GraficaAF4.ChartAreas[0].AxisY.Maximum = 40;
            GraficaPZ.ChartAreas[0].AxisY.Maximum = 40;

            GraficaT7.ChartAreas[0].AxisX.Maximum = 100;
            GraficaT8.ChartAreas[0].AxisX.Maximum = 100;
            GraficaAF3.ChartAreas[0].AxisX.Maximum = 100;
            GraficaAF4.ChartAreas[0].AxisX.Maximum = 100;
            GraficaPZ.ChartAreas[0].AxisX.Maximum = 100;




            Thread procesoAsync = new Thread(Main);
            procesoAsync.Start();
        }
        

        static void engine_UserAdded_Event(object sender, EmoEngineEventArgs e)
        {
            //Console.WriteLine("User Added Event has occured");
            userID = (int)e.userId;

            EmoEngine.Instance.IEE_FFTSetWindowingType((uint)userID, EdkDll.IEE_WindowingTypes.IEE_HAMMING);
        }


        public void Main()
        {
            
            
            EmoEngine engine = EmoEngine.Instance;
            engine.UserAdded += new EmoEngine.UserAddedEventHandler(engine_UserAdded_Event);
            engine.Connect();

            EdkDll.IEE_DataChannel_t[] channelList = new EdkDll.IEE_DataChannel_t[5] { EdkDll.IEE_DataChannel_t.IED_AF3,
                                                                                       EdkDll.IEE_DataChannel_t.IED_AF4,
                                                                                       EdkDll.IEE_DataChannel_t.IED_T7,
                                                                                       EdkDll.IEE_DataChannel_t.IED_T8,
                                                                                       EdkDll.IEE_DataChannel_t.IED_O1 };

            while (true)
            {
                engine.ProcessEvents(10);

                if (userID < 0) continue;

                if (Console.KeyAvailable)
                    break;

                double[] alpha = new double[1];
                double[] low_beta = new double[1];
                double[] high_beta = new double[1];
                double[] gamma = new double[1];
                double[] theta = new double[1];
                
                for (int i = 0; i < 5; i++)
                {
                    Int32 result = engine.IEE_GetAverageBandPowers((uint)userID, channelList[i], theta, alpha, low_beta, high_beta, gamma);
                    if (result == EdkDll.EDK_OK) // 1 y 0 =movimiento de sejas   //2= muela izquierda  // 3 = muela Derecha // 4= no detecto, posible PZ
                    {

                        switch (i)
                        {
                            case 0:
                                T7[0] = theta[0];        //Gris
                                T7[1] = alpha[0];        //naranja
                                T7[2] = low_beta[0];     //verde
                                T7[3] = high_beta[0];    //azul
                                T7[4] = gamma[0];        //Morado

                                SetText(T7[0], T7[1], T7[2], T7[3], T7[4], 0);
                                break;
                            case 1:
                                T8[0] = theta[0];        //Gris
                                T8[1] = alpha[0];        //naranja
                                T8[2] = low_beta[0];     //verde
                                T8[3] = high_beta[0];    //azul
                                T8[4] = gamma[0];        //Morado

                                SetText(T8[0], T8[1], T8[2], T8[3], T8[4], 1);
                                break;
                            case 2 :
                                AF3[0] = theta[0];        //Gris
                                AF3[1] = alpha[0];        //naranja
                                AF3[2] = low_beta[0];     //verde
                                AF3[3] = high_beta[0];    //azul
                                AF3[4] = gamma[0];        //Morado

                                SetText(AF3[0], AF3[1], AF3[2], AF3[3], AF3[4], 2);
                                break;
                            case 3:
                                AF4[0] = theta[0];        //Gris
                                AF4[1] = alpha[0];        //naranja
                                AF4[2] = low_beta[0];     //verde
                                AF4[3] = high_beta[0];    //azul
                                AF4[4] = gamma[0];        //Morado

                                SetText(AF4[0], AF4[1], AF4[2], AF4[3], AF4[4], 3);
                                break;
                            case 4:
                                PZ[0] = theta[0];        //Gris
                                PZ[1] = alpha[0];        //naranja
                                PZ[2] = low_beta[0];     //verde
                                PZ[3] = high_beta[0];    //azul
                                PZ[4] = gamma[0];        //Morado

                                SetText(PZ[0], PZ[1], PZ[2], PZ[3], PZ[4], 4);
                                break;

                            default:
                                break;
                        }
                        
                        //Console.WriteLine("Theta: " + theta[0]);
                    }
                }
                
            }

            //file.Close();
            engine.Disconnect();
        }


        private void SetText(double AF3a, double AF3b, double AF3c, double AF3d, double AF3e, int Electrodo)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.GraficaAF3.InvokeRequired)
            {
                SetTextCallback f = new SetTextCallback(SetText);
                this.Invoke(f, new object[] { AF3a, AF3b, AF3c, AF3d, AF3e, Electrodo });
            }
            else
            {
                //this.Grafica.Series[0].Points.AddXY(0, AF3a);
                //this.Grafica.Series[1].Points.AddXY(0, AF3b);
                //this.Grafica.Series[2].Points.AddXY(0, AF3c);
                //this.Grafica.Series[3].Points.AddXY(0, AF3d);
                //this.Grafica.Series[4].Points.AddXY(0, AF3e);

                switch (Electrodo)
                {
                    case 0:
                        this.GraficaT7.Series[0].Points.AddXY(0, AF3a);
                        this.GraficaT7.Series[1].Points.AddXY(0, AF3b);
                        this.GraficaT7.Series[2].Points.AddXY(0, AF3c);
                        this.GraficaT7.Series[3].Points.AddXY(0, AF3d);
                        this.GraficaT7.Series[4].Points.AddXY(0, AF3e);

                        if (GraficaT7.Series[3].Points.Count > 100)
                        {
                            // Borra desde X = 0.
                            GraficaT7.Series[0].Points.RemoveAt(0);
                            GraficaT7.Series[1].Points.RemoveAt(0);
                            GraficaT7.Series[2].Points.RemoveAt(0);
                            GraficaT7.Series[3].Points.RemoveAt(0);
                            GraficaT7.Series[4].Points.RemoveAt(0);
                        }

                        break;
                    case 1:
                        this.GraficaT8.Series[0].Points.AddXY(0, AF3a);
                        this.GraficaT8.Series[1].Points.AddXY(0, AF3b);
                        this.GraficaT8.Series[2].Points.AddXY(0, AF3c);
                        this.GraficaT8.Series[3].Points.AddXY(0, AF3d);
                        this.GraficaT8.Series[4].Points.AddXY(0, AF3e);

                        if (GraficaT8.Series[3].Points.Count > 100)
                        {
                            // Borra desde X = 0.
                            GraficaT8.Series[0].Points.RemoveAt(0);
                            GraficaT8.Series[1].Points.RemoveAt(0);
                            GraficaT8.Series[2].Points.RemoveAt(0);
                            GraficaT8.Series[3].Points.RemoveAt(0);
                            GraficaT8.Series[4].Points.RemoveAt(0);
                        }

                        break;
                    case 2:
                        this.GraficaAF3.Series[0].Points.AddXY(0, AF3a);
                        this.GraficaAF3.Series[1].Points.AddXY(0, AF3b);
                        this.GraficaAF3.Series[2].Points.AddXY(0, AF3c);
                        this.GraficaAF3.Series[3].Points.AddXY(0, AF3d);
                        this.GraficaAF3.Series[4].Points.AddXY(0, AF3e);

                        if (GraficaAF3.Series[3].Points.Count > 100)
                        {
                            // Borra desde X = 0.
                            GraficaAF3.Series[0].Points.RemoveAt(0);
                            GraficaAF3.Series[1].Points.RemoveAt(0);
                            GraficaAF3.Series[2].Points.RemoveAt(0);
                            GraficaAF3.Series[3].Points.RemoveAt(0);
                            GraficaAF3.Series[4].Points.RemoveAt(0);
                        }

                        break;
                    case 3:
                        this.GraficaAF4.Series[0].Points.AddXY(0, AF3a);
                        this.GraficaAF4.Series[1].Points.AddXY(0, AF3b);
                        this.GraficaAF4.Series[2].Points.AddXY(0, AF3c);
                        this.GraficaAF4.Series[3].Points.AddXY(0, AF3d);
                        this.GraficaAF4.Series[4].Points.AddXY(0, AF3e);

                        if (GraficaAF4.Series[3].Points.Count > 100)
                        {
                            // Borra desde X = 0.
                            GraficaAF4.Series[0].Points.RemoveAt(0);
                            GraficaAF4.Series[1].Points.RemoveAt(0);
                            GraficaAF4.Series[2].Points.RemoveAt(0);
                            GraficaAF4.Series[3].Points.RemoveAt(0);
                            GraficaAF4.Series[4].Points.RemoveAt(0);
                        }

                        break;
                    case 4:
                        this.GraficaPZ.Series[0].Points.AddXY(0, AF3a);
                        this.GraficaPZ.Series[1].Points.AddXY(0, AF3b);
                        this.GraficaPZ.Series[2].Points.AddXY(0, AF3c);
                        this.GraficaPZ.Series[3].Points.AddXY(0, AF3d);
                        this.GraficaPZ.Series[4].Points.AddXY(0, AF3e);

                        if (GraficaPZ.Series[3].Points.Count > 100)
                        {
                            // Borra desde X = 0.
                            GraficaPZ.Series[0].Points.RemoveAt(0);
                            GraficaPZ.Series[1].Points.RemoveAt(0);
                            GraficaPZ.Series[2].Points.RemoveAt(0);
                            GraficaPZ.Series[3].Points.RemoveAt(0);
                            GraficaPZ.Series[4].Points.RemoveAt(0);
                        }

                        break;

                    default:
                        break;
                }






            }
        }

        delegate void SetTextCallback(double AF3a, double AF3b, double AF3c, double AF3d, double AF3e, int Electrodo);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
