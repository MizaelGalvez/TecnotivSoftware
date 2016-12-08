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
        
        public void Lectura()
        {

            SerialPort _serialPort;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            String valor = "";
            string sensor_uso = "0";  // TODO:   asignar al Valor guardado en la base de Datos en la tabla Configuracion
            bool continuar = true;

            _serialPort = new SerialPort();

            _serialPort.BaudRate = 9600;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            _serialPort.Open();


            while (continuar)
            {
                valor = Console.ReadLine().ToString();

                if (stringComparer.Equals("cerrar", valor))
                {

                    continuar = false;

                }
                else
                {

                    if (sensor_uso.Equals("1"))
                    { 

                        _serialPort.BaudRate = 4800;
                        _serialPort.WriteLine(String.Format("{0}", valor));
                        _serialPort.BaudRate = 9600;

                    }
                    else
                    {
                       
                        var movimiento = new MovimientoInterface() { valor = valor };
                        movimiento.MoverCursor();
                        Console.WriteLine("{ }",valor);
                        
                    }

                }

            }





        }
    }
}
