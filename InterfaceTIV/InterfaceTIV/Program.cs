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
            InicioCarga HOME = new InicioCarga();

            //IntegracionDiadiema Estados = new IntegracionDiadiema();
            //Estados.Main();

            //LecturaFrecuencias Frecuencias = new LecturaFrecuencias();
            //Frecuencias.Main();

            Electrodos_Carga_señal Electro  = new Electrodos_Carga_señal();


            Application.Run();


        }
    }
}
