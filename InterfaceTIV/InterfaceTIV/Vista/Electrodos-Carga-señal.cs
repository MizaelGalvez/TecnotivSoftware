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

namespace InterfaceTIV.Vista
{
    public partial  class Electrodos_Carga_señal : Form
    {
        public Electrodos_Carga_señal()
        {
            InitializeComponent();
        }

        static int userID = -1;

        int c1, c2, c3, c4, c5, b1;

        int a = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            a = 0;
            Main();
        }

        public async Task estadistica(int c1,int c2,int c3,int c4,int c5,int b1, string señal)
        {
            switch (b1)
            {
                case 0:
                    pbBateria.BackgroundImage = InterfaceTIV.Properties.Resources.B1;
                    break;
                case 1:
                    pbBateria.BackgroundImage = InterfaceTIV.Properties.Resources.B1;
                    break;
                case 2:
                    pbBateria.BackgroundImage = InterfaceTIV.Properties.Resources.B2;
                    break;
                case 3:
                    pbBateria.BackgroundImage = InterfaceTIV.Properties.Resources.B3;
                    break;
                case 4:
                    pbBateria.BackgroundImage = InterfaceTIV.Properties.Resources.B3;
                    break;

                default:
                    break;
            }
            switch (c1)
            {
                case 0:
                    pbAF3.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
                    break;
                case 1:
                    pbAF3.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
                    break;
                case 2:
                    pbAF3.BackgroundImage = InterfaceTIV.Properties.Resources.C2;
                    break;
                case 3:
                    pbAF3.BackgroundImage = InterfaceTIV.Properties.Resources.C3;
                    break;
                case 4:
                    pbAF3.BackgroundImage = InterfaceTIV.Properties.Resources.C4;
                    break;

                default:
                    break;
            }

            switch (c2)
            {
                case 0:
                    pbT7.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
                    break;
                case 1:
                    pbT7.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
                    break;
                case 2:
                    pbT7.BackgroundImage = InterfaceTIV.Properties.Resources.C2;
                    break;
                case 3:
                    pbT7.BackgroundImage = InterfaceTIV.Properties.Resources.C3;
                    break;
                case 4:
                    pbT7.BackgroundImage = InterfaceTIV.Properties.Resources.C4;
                    break;

                default:
                    break;
            }

            switch (c3)
            {
                case 0:
                    pbPZ.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
                    break;
                case 1:
                    pbPZ.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
                    break;
                case 2:
                    pbPZ.BackgroundImage = InterfaceTIV.Properties.Resources.C2;
                    break;
                case 3:
                    pbPZ.BackgroundImage = InterfaceTIV.Properties.Resources.C3;
                    break;
                case 4:
                    pbPZ.BackgroundImage = InterfaceTIV.Properties.Resources.C4;
                    break;

                default:
                    break;
            }

            switch (c4)
            {
                case 0:
                    pbT8.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
                    break;
                case 1:
                    pbT8.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
                    break;
                case 2:
                    pbT8.BackgroundImage = InterfaceTIV.Properties.Resources.C2;
                    break;
                case 3:
                    pbT8.BackgroundImage = InterfaceTIV.Properties.Resources.C3;
                    break;
                case 4:
                    pbT8.BackgroundImage = InterfaceTIV.Properties.Resources.C4;
                    break;

                default:
                    break;
            }

            switch (c5)
            {
                case 0:
                    pbAF4.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
                    break;
                case 1:
                    pbAF4.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
                    break;
                case 2:
                    pbAF4.BackgroundImage = InterfaceTIV.Properties.Resources.C2;
                    break;
                case 3:
                    pbAF4.BackgroundImage = InterfaceTIV.Properties.Resources.C3;
                    break;
                case 4:
                    pbAF4.BackgroundImage = InterfaceTIV.Properties.Resources.C4;
                    break;

                default:
                    break;
            }
            switch (señal)
            {
                case "NO_SIG":
                    pbWifi.BackgroundImage = InterfaceTIV.Properties.Resources.W0;
                    break;
                case "BAD_SIG":
                    pbWifi.BackgroundImage = InterfaceTIV.Properties.Resources.W1;
                    break;
                case "GOOD_SIG ":
                    pbWifi.BackgroundImage = InterfaceTIV.Properties.Resources.W2;
                    break;
                case "GOOD_SIG":
                    pbWifi.BackgroundImage = InterfaceTIV.Properties.Resources.W3;
                    break;

                default:
                    break;
            }
        }

        
        public void engine_UserAdded_Event(object sender, EmoEngineEventArgs e)
        {
            Console.WriteLine("User Added Event has occured");
            userID = (int)e.userId;
        }


        public async void engine_EmoStateUpdated(object sender, EmoStateUpdatedEventArgs e)
        {

            EmoState es = e.emoState;

            if (e.userId != 0) return;

            float timeFromStart = es.GetTimeFromStart();
            lblTiempo.Text = timeFromStart.ToString();
            //Console.WriteLine("Timer: " + timeFromStart);

            EdkDll.IEE_SignalStrength_t signalStrength = es.GetWirelessSignalStatus();

            Int32 chargeLevel = 0;
            Int32 maxChargeLevel = 0;
            es.GetBatteryChargeLevel(out chargeLevel, out maxChargeLevel);
            b1 = chargeLevel;
            await estadistica((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF3), (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T7), (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_O1), (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T8), (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF4), chargeLevel, signalStrength.ToString());



            // c1 = (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF3);
            //c2 = (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T7);
            // c3 = (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_O1);
            //c4 = (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T8);
            // c5 = (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF4);


        }

        public async void Main()
        {

            //Console.WriteLine("Headset Information Logger Example");

            EmoEngine engine = EmoEngine.Instance;

            engine.UserAdded += new EmoEngine.UserAddedEventHandler(engine_UserAdded_Event);
            engine.EmoStateUpdated += new EmoEngine.EmoStateUpdatedEventHandler(engine_EmoStateUpdated);

            // connect to Emoengine.            
            engine.Connect();


            while (true)
            {
                if (a >= 10)
                    break;


                Console.WriteLine("hola Mizael");
                Console.WriteLine(b1);
                Console.WriteLine(c1);
                Console.WriteLine(c2);
                Console.WriteLine(c3);
                Console.WriteLine(c4);
                Console.WriteLine(c5);


                engine.ProcessEvents();


                a++;

                // If the user has not yet connected, do not proceed
                if ((int)userID == -1)
                    continue;

                Thread.Sleep(500);
            }

            engine.Disconnect();

        }
    }
}
