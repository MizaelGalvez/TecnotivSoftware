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

        private void MoverCursor()
        {
            
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);

        }




    }
}
