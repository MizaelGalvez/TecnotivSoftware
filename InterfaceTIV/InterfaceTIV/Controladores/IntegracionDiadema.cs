using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Emotiv;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using InterfaceTIV.Vista;

namespace InterfaceTIV.Controladores
{
    
    class IntegracionDiadiema
    {

        static int userID = -1;
        static string filename = "BateriayContactodeElectrodos.csv";
        static TextWriter file = new StreamWriter(filename, false);
        
        
        
        static void engine_UserAdded_Event(object sender, EmoEngineEventArgs e)
        {
            Console.WriteLine("User Added Event has occured");
            userID = (int)e.userId;
        }

        static void engine_EmoStateUpdated(object sender, EmoStateUpdatedEventArgs e)
        {

            EmoState es = e.emoState;

            if (e.userId != 0) return;

            float timeFromStart = es.GetTimeFromStart();
            file.Write(timeFromStart + ",");
            Console.WriteLine("Time: " + timeFromStart);

            EdkDll.IEE_SignalStrength_t signalStrength = es.GetWirelessSignalStatus();
            file.Write(signalStrength + ",");

            Int32 chargeLevel = 0;
            Int32 maxChargeLevel = 0;
            es.GetBatteryChargeLevel(out chargeLevel, out maxChargeLevel);
            file.Write(chargeLevel + ",");


            file.Write((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF3) + ",");
            file.Write((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T7) + ",");
            file.Write((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_O1) + ","); 	// Pz
            file.Write((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_T8) + ",");
            file.Write((int)es.GetContactQuality((int)EdkDll.IEE_InputChannels_t.IEE_CHAN_AF4) + ",");

            file.WriteLine("");
        }

        public void Main()
        {
           
            //Console.WriteLine("Headset Information Logger Example");

            EmoEngine engine = EmoEngine.Instance;

            engine.UserAdded += new EmoEngine.UserAddedEventHandler(engine_UserAdded_Event);
            engine.EmoStateUpdated += new EmoEngine.EmoStateUpdatedEventHandler(engine_EmoStateUpdated);

            // connect to Emoengine.            
            engine.Connect();

            IntegracionDiadiema p = new IntegracionDiadiema();

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
