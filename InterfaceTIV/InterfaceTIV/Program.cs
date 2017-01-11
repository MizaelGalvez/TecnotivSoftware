using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceTIV.Vista;
using InterfaceTIV.Controladores;
using System.Windows.Forms;

namespace InterfaceTIV
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HeadsetInformationLogger Datos = new HeadsetInformationLogger();
            //InicioCarga HOME = new InicioCarga();
            Datos.Main();
            Application.Run();

           
        }
    }
}
