using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfaceTIV.Vista;
using InterfaceTIV.Controladores;
using Emotiv;
using InterfaceTIV.Controladores;

namespace InterfaceTIV.Vista
{
    public partial class Home : Form
    {

        EmoEngine engine;
        int userID = 12600143;

        public Home()
        {

            InitializeComponent();


            //
            //
           

            Program program = new Program();
            engine = EmoEngine.Instance;
            engine.UserAdded += new EmoEngine.UserAddedEventHandler(engine_UserAdded_Event);
            engine.EmoStateUpdated += new EmoEngine.EmoStateUpdatedEventHandler(engine_EmoStateUpdated);
            engine.Connect();

            var Diadema = EdkDll.IEE_EmoStateCreate();


            Console.WriteLine(EdkDll.IEE_InputChannels_t.IEE_CHAN_T8.ToString());

            while (true)
            {
                engine.ProcessEvents();
            }
            //



        }



        void engine_UserAdded_Event(object sender, EmoEngineEventArgs e)
        {
            Console.WriteLine("User Added Event has occured");
            // record the user      
            userID = (int)e.userId;
            // enable data aquisition for this user.          
            // ask for up to 1 second of buffered data      
        }

        void engine_EmoStateUpdated(object sender, EmoStateUpdatedEventArgs e)
        {
            if (e.userId == 0)
            {
                EmoState es = e.emoState;

                Console.WriteLine("User ", e.userId, ":  ", es.GetTimeFromStart());
            }
            else if (e.userId == 1)
            {
                EmoState es = e.emoState;
                Console.WriteLine("User ", e.userId, ":  ", es.GetTimeFromStart());
            }
        }


        //entrar a la ventana de configuracion
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
          
            Configuracion VistaConfiguracion = new Configuracion();

            VistaConfiguracion.Show();

        }

        //
        //
        //
        // eventos del panel HOME
        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelAlimentos.Show();
            panelAlimentos.Location = new Point(42, 90);

            
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelActividades.Show();
            panelActividades.Location = new Point(42, 90);

            

        }

        private void btnEntretenimiento_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelEntretenimiento.Show();
            panelEntretenimiento.Location = new Point(42, 90);

            
        }

        private void btnControlRemoto_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelControlRemoto.Show();
            panelControlRemoto.Location = new Point(42, 90);

            
        }

        private void btnSilla_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelSilla.Show();
            panelSilla.Location = new Point(42, 90);

            
        }
        
        //
        //
        //
        // eventos de panel de Alimentos
        private void btnRegresarAlimentos_Click(object sender, EventArgs e)
        {
            panelAlimentos.Hide();
            panelHome.Show();
        }
        
        //
        //
        //
        //eventos del panel Actividades
        private void btnRegresarPanelActividades_Click(object sender, EventArgs e)
        {
            panelActividades.Hide();
            panelHome.Show();
        }
        
        //
        //
        //
        //eventos del panel de Entretenimiento
        private void btnRegresarEntretenimiento_Click(object sender, EventArgs e)
        {
            panelEntretenimiento.Hide();
            panelHome.Show();
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            panelHome.Hide();
            panelWeb.Show();
            panelWeb.Location = new Point(12, 13);
           
            
        }
        
        //
        //
        //
        //Eventos del Panel Control Remoto
        private void btnRegresarRemoto_Click(object sender, EventArgs e)
        {
            panelControlRemoto.Hide();
            panelHome.Show();
        }
        
        //
        //
        //
        //Eventos del panel de  la silla
        private void btnRegresarSilla_Click(object sender, EventArgs e)
        {
            panelSilla.Hide();
            panelHome.Show();
        }

    }
}
