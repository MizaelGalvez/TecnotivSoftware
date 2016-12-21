using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceTIV.Vista;
using System.Windows.Forms;
using System.Drawing;

namespace InterfaceTIV.Controladores
{
    class MovimientoInterface
    {

        public string valor { get; set; }
        public static Point Position { get; set; }
        public Cursor Cursor { get; private set; }

        

        public void MoverCursor()
        {

            // N = neutral A = adelante I = izquierda D = derecha UP = arriba DOWN = abajo

            switch (valor)
            {
                case "1":
                    
                    break;
                case "A":
                    
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 0);
                    }
                    catch
                    {
                        Console.Write("Error clase MovimientoInterface al Mover Mause");
                    }
                    
                    
                    break;
                case "D":
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 50, Cursor.Position.Y + 0);
                    }
                    catch
                    {
                        Console.Write("Error clase MovimientoInterface al Mover Mause");
                    }

                    break;
                case "S":
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 0, Cursor.Position.Y + 50);
                    }
                    catch
                    {
                        Console.Write("Error clase MovimientoInterface al Mover Mause");
                    }
                    break;
                case "W":
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X - 0, Cursor.Position.Y - 50);
                    }
                    catch
                    {
                        Console.Write("Error clase MovimientoInterface al Mover Mause");
                    }
                    break;

                case "C":
                    break;
                default:
                    break;
            }
            
        }


       

    }
}
