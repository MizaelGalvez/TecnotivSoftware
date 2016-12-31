using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.ComponentModel;
using InterfaceTIV.Controladores;
using InterfaceTIV.Vista;

namespace InterfaceTIV.Controladores
{

    public class LecturaSerial
    {
        public int sensor{ get; set; }
        public string valor { get; set; }
        public string panelReferencia { get; set; }
        public int contador { get; set; }


        public void Lectura()
        {
            
            SerialPort _serialPort;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            
            _serialPort = new SerialPort();
            
            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataBits = 8;


            foreach (var item in SerialPort.GetPortNames())
            {
               // Console.WriteLine(item);
                _serialPort.PortName = item;
            }

            if (sensor == 2)  //TODO arreglar la impresion serial
            {
                //try
                //{
                //    _serialPort.Open();
                //    _serialPort.Write(String.Format("{0}", valor));
                //    _serialPort.Close();
                //}
                //catch
                //{
                //    Console.Write("error");
                //}
            }
            else
            {

                MovimientoInterface movimiento = new MovimientoInterface();
                movimiento.valor = valor;
                movimiento.panelReferencia = panelReferencia;
                movimiento.contador = contador;
                movimiento.MoverCursor();
                
            }
            
        }
    }
}
