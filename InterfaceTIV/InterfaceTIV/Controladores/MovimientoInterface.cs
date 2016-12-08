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

            switch (this.valor)
            {
                case "N":
                    this.Cursor = new Cursor(Cursor.Current.Handle);
                    Cursor.Position = new Point(Cursor.Position.X - 0, Cursor.Position.Y - 0);
                    break;
                case "A":
                    this.Cursor = new Cursor(Cursor.Current.Handle);
                    SendKeys.Send("{ENTER}");
                    break;
                case "I":
                    this.Cursor = new Cursor(Cursor.Current.Handle);
                    Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 0);
                    break;
                case "D":
                    this.Cursor = new Cursor(Cursor.Current.Handle);
                    Cursor.Position = new Point(Cursor.Position.X + 50, Cursor.Position.Y + 0);
                    break;
                case "UP":
                    this.Cursor = new Cursor(Cursor.Current.Handle);
                    Cursor.Position = new Point(Cursor.Position.X + 0, Cursor.Position.Y + 50);
                    break;
                case "DOWN":
                    this.Cursor = new Cursor(Cursor.Current.Handle);
                    Cursor.Position = new Point(Cursor.Position.X - 0, Cursor.Position.Y - 50);
                    break;
                default:
                    break;
            }
            
        }




    }
}
