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
        
        double[] datos = {0,0,0,0,0};
        
        

        public GraficaFrecuencias()
        {
            InitializeComponent();
            this.Show();

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
           Console.WriteLine("===================================================================");
           Console.WriteLine("Example to get the average banpecific channel from the latst epoch.");
           Console.WriteLine("===================================================================");
            

            // create the engine
            EmoEngine engine = EmoEngine.Instance;
            engine.UserAdded += new EmoEngine.UserAddedEventHandler(engine_UserAdded_Event);
            engine.Connect();

           // string header = "Theta, Alpha, Low_beta, High_beta, Gamma"; ;
            //file.WriteLine(header);
           // file.WriteLine("");

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

                SetText(datos[0], datos[1], datos[2], datos[3], datos[4]);


                for (int i = 0; i < 5; i++)
                {
                    Int32 result = engine.IEE_GetAverageBandPowers((uint)userID, channelList[i], theta, alpha, low_beta, high_beta, gamma);
                    if (result == EdkDll.EDK_OK && i == 2)
                    {

                        datos[0] = theta[0];
                        datos[1] = alpha[0];
                        datos[2] = low_beta[0];
                        datos[3] = high_beta[0];
                        datos[4] = gamma[0];

                        
                        Console.WriteLine("Theta: " + theta[0]);
                    }
                }

                Console.WriteLine("____________________________");
            }

            //file.Close();
            engine.Disconnect();
        }


        private void SetText(double a, double b, double c, double d, double e)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.Grafica.InvokeRequired)
            {
                SetTextCallback f = new SetTextCallback(SetText);
                this.Invoke(f, new object[] { a,b,c,d,e });
            }
            else
            {
                Grafica.Palette = ChartColorPalette.Pastel;

                this.Grafica.Series[0].Points.AddXY(0, a);
                this.Grafica.Series[1].Points.AddXY(0, b);
                this.Grafica.Series[2].Points.AddXY(0, c);
                this.Grafica.Series[3].Points.AddXY(0, d);
                this.Grafica.Series[4].Points.AddXY(0, e);

            }
        }

        delegate void SetTextCallback(double a, double b, double c, double d, double e);






    }
}
