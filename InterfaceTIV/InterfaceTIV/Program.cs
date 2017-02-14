using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceTIV.Vista;
using InterfaceTIV.Controladores;
using System.Windows.Forms;
using System.Threading;

namespace InterfaceTIV
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //IntegracionDiadiema Bluethoot = new IntegracionDiadiema();
            //Bluethoot.Main();

            InicioCarga HOME = new InicioCarga();


            //Electrodos_Carga_señal Electro  = new Electrodos_Carga_señal();

            //GraficaFrecuencias grafica = new GraficaFrecuencias();

            ReconocimeintoVoz escuchando = new ReconocimeintoVoz();

            Application.Run();
            
        }
    }
}
