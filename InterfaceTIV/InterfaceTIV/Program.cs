using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceTIV.Vista;
using System.Windows.Forms;

namespace InterfaceTIV
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InicioCarga HOME = new InicioCarga();
            Application.Run();

           
        }
    }
}
