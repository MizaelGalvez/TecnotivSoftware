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
            
            
            if (valor.Equals("W") || valor.Equals("A") || valor.Equals("D") || valor.Equals("N"))  //TODO arreglar la impresion serial
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


                try
                {
                    _serialPort.Open();
                    _serialPort.Write(String.Format("{0}", valor));
                    _serialPort.Close();
                }
                catch
                {
                    Console.Write("error en la Comunicacion con el USB del Circuito, ERROR del COM");
                }
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
