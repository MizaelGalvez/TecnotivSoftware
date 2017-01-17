﻿using Emotiv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
            this.SetDesktopLocation(420,8);
            this.Show();
            pbBateria.BackgroundImage = Properties.Resources.B0;
            pbAF3.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
            pbT7.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
            pbPZ.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
            pbT8.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
            pbAF4.BackgroundImage = InterfaceTIV.Properties.Resources.C1;
            TopMost = true;
            

        }

        static int userID = -1;
        int c1, c2, c3, c4, c5, b1;
        string fuerzaseñal = "";
        int a = 0;

        private async void button1_Click(object sender, EventArgs e)
        {
            a = 0;
            await Main();
        }

        public async Task estadistica(int a,int b,int c,int d,int e,int f, string señal)
        {
            switch (f)
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
            switch (a)
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

            switch (b)
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

            switch (c)
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

            switch (d)
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

            switch (e)
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
            a = 0;
        }

        
        public void engine_UserAdded_Event(object sender, EmoEngineEventArgs e)
        {
            userID = (int)e.userId;
        }


        public void engine_EmoStateUpdated(object sender, EmoStateUpdatedEventArgs e)
        {

            EmoState es = e.emoState;


            if (e.userId != 0) return;

            float timeFromStart = es.GetTimeFromStart();
            lblTiempo.Text = timeFromStart.ToString();
            Console.WriteLine("Timer: " + timeFromStart);

            EdkDll.IEE_SignalStrength_t signalStrength = es.GetWirelessSignalStatus();
            fuerzaseñal = signalStrength.ToString();
            Int32 chargeLevel = 0;
            Int32 maxChargeLevel = 0;
            es.GetBatteryChargeLevel(out chargeLevel, out maxChargeLevel);
            b1 = chargeLevel;

            c1 = (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF3);
            c2 = (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T7);
            c3 = (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_O1);
            c4 = (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T8);
            c5 = (int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF4);
            
        }

        public async Task Main()
        {

            //Console.WriteLine("Headset Information Logger Example");

            EmoEngine engine = EmoEngine.Instance;

            engine.UserAdded += new EmoEngine.UserAddedEventHandler(engine_UserAdded_Event);
            engine.EmoStateUpdated += new EmoEngine.EmoStateUpdatedEventHandler(engine_EmoStateUpdated);

            // connect to Emoengine.            
            engine.Connect();

            button1.Text = "Conectado";

            while (true)
            {
                if (a >= 10)
                {
                    break;
                }
                
                Console.WriteLine("Hi Mizael ");
                Console.WriteLine(b1);
                Console.WriteLine(c1);
                Console.WriteLine(c2);
                Console.WriteLine(c3);
                Console.WriteLine(c4);
                Console.WriteLine(c5);


                engine.ProcessEvents();
                this.Refresh();
                await estadistica(c1, c2, c3, c4, c5, b1, fuerzaseñal);
                
                // If the user has not yet connected, do not proceed
                if ((int)userID == -1)
                    continue;

                Thread.Sleep(500);
            }

            engine.Disconnect();
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
