using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;
using InterfaceTIV.Controladores;
using InterfaceTIV.Model;

namespace InterfaceTIV.Controladores
{

    public class LecturaSerial
    {
        public int sensor{ get; set; }
        public string valor { get; set; }
        public void Lectura()
        {
            
            SerialPort _serialPort;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            
            _serialPort = new SerialPort();

            _serialPort.PortName = "COM1";
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataBits = 8;

            

            if (sensor == 1)
            {
                try
                {
                    _serialPort.Open();
                    _serialPort.Write(String.Format("{0}", valor));
                    _serialPort.Close();
                }
                catch
                {
                    Console.Write(String.Format("Escribir por serial: {0}", valor));
                }
                
            }
            else
            {

                MovimientoInterface movimiento = new MovimientoInterface();
                movimiento.valor = valor;
                movimiento.MoverCursor();


            }
            
        }
    }
}
