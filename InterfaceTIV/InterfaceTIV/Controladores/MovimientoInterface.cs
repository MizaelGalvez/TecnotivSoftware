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
        public string panelReferencia { get; set; }
        public int contador { get; set; }



        public void MoverCursor()
        {
            //Console.WriteLine(valor);
            // N = neutral A = adelante I = izquierda D = derecha UP = arriba DOWN = abajo
            if (valor.Equals("4")||valor.Equals("5")||valor.Equals("6")|| valor.Equals("8"))
            {
                try
                {
                    Cursor.Show();
                }
                catch
                {
                }
                switch (valor)
                {
                    case "4":

                        try
                        {
                            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 0);
                        }
                        catch
                        {
                            Console.Write("Error clase MovimientoInterface al Mover Mause");
                        }


                        break;
                    case "6":
                        try
                        {
                            Cursor.Position = new Point(Cursor.Position.X + 50, Cursor.Position.Y + 0);
                        }
                        catch
                        {
                            Console.Write("Error clase MovimientoInterface al Mover Mause");
                        }

                        break;
                    case "5":
                        try
                        {
                            Cursor.Position = new Point(Cursor.Position.X + 0, Cursor.Position.Y + 50);
                        }
                        catch
                        {
                            Console.Write("Error clase MovimientoInterface al Mover Mause");
                        }
                        break;
                    case "8":
                        try
                        {
                            Cursor.Position = new Point(Cursor.Position.X - 0, Cursor.Position.Y - 50);
                        }
                        catch
                        {
                            Console.Write("Error clase MovimientoInterface al Mover Mause");
                        }
                        break;
                    default:
                        break;
                }
            }
            if (valor.Equals("R"))
            {
                PosicionPrederteminada();
            }
            
            
        }

        public void PosicionPrederteminada()
        {
            try
            {
               Cursor.Hide();
            }
            catch
            {
            }
            Console.WriteLine(contador+" "+panelReferencia);
            switch (panelReferencia)
            {
                case "comidas":
                    saltosAutomatico();
                    break;
                case "bebidas":

                    saltosAutomatico();
                    break;
                case "postres":

                    saltosAutomatico();
                    break;
                case "actividades":

                    saltosAutomatico();
                    break;
                case "entretenimiento":

                    saltosAutomatico();
                    break;
                case "home":
                    saltosHome();
                    break;
                case "alimentos":
                    saltosAlimento();
                    break;
                case "silla":
                    saltosSilla();
                    break;
                case "rutas":
                    saltosRutas();
                    break;
                default:
                    break;
            }

        }

        public void saltosHome()
        {
           
            switch (contador)
            {
                case 0:
                    try
                    {
                        Cursor.Position = new Point(265, 180);
                    }
                    catch
                    {
                    }
                    break;
                case 2:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 310, Cursor.Position.Y + 0);
                    }
                    catch
                    {
                    }
                    break;
                case 4:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X - 310, Cursor.Position.Y + 230);
                    }
                    catch
                    {
                    }
                    break;
                case 6:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 310, Cursor.Position.Y + 0);
                    }
                    catch
                    {
                    }
                    break;
                case 8:

                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 205, Cursor.Position.Y - 235);
                    }
                    catch
                    {
                    }
                    break;
                case 10:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 0, Cursor.Position.Y + 125);
                    }
                    catch
                    {
                    }
                    break;
                case 12:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 0, Cursor.Position.Y + 125);
                    }
                    catch
                    {
                    }
                    break;
                default:
                    break;
            }

        }
        public void saltosAlimento()
        {
            switch (contador)
            {
                case 0:
                    try
                    {
                        Cursor.Position = new Point(175, 305);
                    }
                    catch
                    {
                    }
                    break;
                case 2:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 300, Cursor.Position.Y + 0);
                    }
                    catch
                    {
                    }
                    break;
                case 4:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 300, Cursor.Position.Y + 0);
                    }
                    catch
                    {
                    }
                    break;
                case 6:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 60, Cursor.Position.Y - 185);
                    }
                    catch
                    {
                    }
                    break;
                default:
                    break;
            }

        }
        public void saltosAutomatico()
        {
            switch (contador)
            {
                case 0:
                    try
                    {
                        Cursor.Position = new Point(225, 200);
                    }
                    catch
                    {
                    }
                    break;
                case 2:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 230, Cursor.Position.Y + 0);
                    }
                    catch
                    {
                    }
                    break;
                case 4:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 230, Cursor.Position.Y + 0);
                    }
                    catch
                    {
                    }
                    break;
                case 6:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X - 460, Cursor.Position.Y + 170);
                    }
                    catch
                    {
                    }
                    break;
                case 8:

                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 230, Cursor.Position.Y + 0);
                    }
                    catch
                    {
                    }
                    break;
                case 10:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 230, Cursor.Position.Y + 0);
                    }
                    catch
                    {
                    }
                    break;
                case 12:
                    try
                    {
                        Cursor.Position = new Point(845, 290);
                    }
                    catch
                    {
                    }
                    break;
                case 14:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X - 770, Cursor.Position.Y - 0);
                    }
                    catch
                    {
                    }
                    break;
                case 16:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 770, Cursor.Position.Y - 170);
                    }
                    catch
                    {
                    }
                    break;
                default:
                    break;
            }

        }
        public void saltosSilla()
        {
            switch (contador)
            {

                case 0:
                    try
                    {
                        Cursor.Position = new Point(875, 500);
                    }
                    catch
                    {
                    }
                    break;
                case 2:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 0, Cursor.Position.Y - 350);
                    }
                    catch
                    {
                    }
                    break;
                case 4:
                    try
                    {
                        Cursor.Position = new Point(175, 325);
                    }
                    catch
                    {
                    }
                    break;
                case 6:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 110, Cursor.Position.Y - 100);
                    }
                    catch
                    {
                    }
                    break;
                case 8:

                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 110, Cursor.Position.Y +100);
                    }
                    catch
                    {
                    }
                    break;
                default:
                    break;
            }

        }
        public void saltosRutas()
        {
            switch (contador)
            {
                case 0:
                    try
                    {
                        Cursor.Position = new Point(350, 500);
                    }
                    catch
                    {
                    }
                    break;
                case 2:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 230, Cursor.Position.Y - 0);
                    }
                    catch
                    {
                    }
                    break;
                case 4:
                    try
                    {
                        Cursor.Position = new Point(900, 100);
                    }
                    catch
                    {
                    }
                    break;
                case 6:
                    try
                    {
                        Cursor.Position = new Point(100, 330);
                    }
                    catch
                    {
                    }
                    break;
                case 8:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 175, Cursor.Position.Y - 100);
                    }
                    catch
                    {
                    }
                    break;
                case 10:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 175, Cursor.Position.Y - 100);
                    }
                    catch
                    {
                    }
                    break;
                case 12:
                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 175, Cursor.Position.Y + 100);
                    }
                    catch
                    {
                    }
                    break;
                case 14:

                    try
                    {
                        Cursor.Position = new Point(Cursor.Position.X + 175, Cursor.Position.Y + 100);
                    }
                    catch
                    {
                    }
                    break;
                
                default:
                    break;
            }

        }
        public void saltosControlRemoto()
        {
            switch (contador)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    break;
            }

        }



    }
}
