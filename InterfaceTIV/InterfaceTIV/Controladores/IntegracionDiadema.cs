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
using System.IO.Ports;

namespace InterfaceTIV.Controladores
{
    
    class IntegracionDiadiema
    {

        static bool _continue;
        static SerialPort puertoSerial;


        public void Main()
        {
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            Thread readThread = new Thread(Read);

            // Create a new SerialPort object with default settings.

            puertoSerial = new SerialPort();

            // Allow the user to set the appropriate properties.
            puertoSerial.PortName = SetPortName(puertoSerial.PortName);
            puertoSerial.BaudRate = 9600;

            // Set the read/write timeouts
            puertoSerial.ReadTimeout = 500;
            puertoSerial.WriteTimeout = 500;

            puertoSerial.Open();
            _continue = true;
            readThread.Start();

            //Console.Write("Name: ");
            //name = Console.ReadLine();

            Console.WriteLine("leeyendo Bluetooth emotiv");
           
            while (_continue)
            {
                message = Console.ReadLine();
            
                if (stringComparer.Equals("quit", message))
                {
                    _continue = false;
                }
                else
                {
                    puertoSerial.WriteLine(
                        String.Format("<>: {1}", message));
                }
            }

            readThread.Join();
            puertoSerial.Close();

        }
        public static string SetPortName(string defaultPortName)
        {
            string portName;

            Console.WriteLine("Puertos Disponibles en la Computadora:");
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Escribir el COM que deseas escuchar: ");
            portName = Console.ReadLine();

            if (portName == "" || !(portName.ToLower()).StartsWith("com"))
            {
                portName = defaultPortName;
            }
            return portName;
        }
       
        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = puertoSerial.ReadLine();
                    Console.WriteLine(message);
                }
                catch (TimeoutException) { }
            }
            if (_continue == false)
            {
                Console.WriteLine("Conexion Terminada");
            }
        }
    }
}
