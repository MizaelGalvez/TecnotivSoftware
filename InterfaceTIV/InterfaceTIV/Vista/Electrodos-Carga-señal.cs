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
    public partial class Electrodos_Carga_señal : Form
    {
        public Electrodos_Carga_señal()
        {
            InitializeComponent();
        }

        static int userID = -1;
        static string filename = "BateriayContactodeElectrodos.csv";
        static TextWriter file = new StreamWriter(filename, false);



        static void engine_UserAdded_Event(object sender, EmoEngineEventArgs e)
        {
            Console.WriteLine("User Added Event has occured");
            userID = (int)e.userId;
        }

        void engine_EmoStateUpdated(object sender, EmoStateUpdatedEventArgs e)
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
            Console.WriteLine(chargeLevel);
            switch (chargeLevel)
            {
                case 0:
                    pbBateria.BackgroundImage = InterfaceTIV.Properties.Resources.C0;
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
            Console.WriteLine((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF3));
            switch ((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF3))
            {
                case 0:
                    pbAF3.BackgroundImage = InterfaceTIV.Properties.Resources.C0;
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

            Console.WriteLine((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T7));
            switch ((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T7))
            {
                case 0:
                    pbT7.BackgroundImage = InterfaceTIV.Properties.Resources.C0;
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

            Console.WriteLine((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_O1));
            switch ((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_O1))
            {
                case 0:
                    pbPZ.BackgroundImage = InterfaceTIV.Properties.Resources.C0;
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

            Console.WriteLine((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T8));
            switch ((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T8))
            {
                case 0:
                    pbT8.BackgroundImage = InterfaceTIV.Properties.Resources.C0;
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

            Console.WriteLine((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF4));
            switch ((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF4))
            {
                case 0:
                    pbAF4.BackgroundImage = InterfaceTIV.Properties.Resources.C0;
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
        }

        public void Main()
        {

            //Console.WriteLine("Headset Information Logger Example");

            EmoEngine engine = EmoEngine.Instance;

            engine.UserAdded += new EmoEngine.UserAddedEventHandler(engine_UserAdded_Event);
            engine.EmoStateUpdated += new EmoEngine.EmoStateUpdatedEventHandler(engine_EmoStateUpdated);

            // connect to Emoengine.            
            engine.Connect();

            Electrodos_Carga_señal p = new Electrodos_Carga_señal();

            string header = "Time, Wireless Strength, Battery Level, AF3, T7, Pz, T8, AF4";
            file.WriteLine(header);
            file.WriteLine("");

            while (true)
            {
                if (Console.KeyAvailable)
                    break;

                engine.ProcessEvents();

                // If the user has not yet connected, do not proceed
                if ((int)userID == -1)
                    continue;

                Thread.Sleep(10);
            }

            file.Close();
            engine.Disconnect();
        }
    }
}
