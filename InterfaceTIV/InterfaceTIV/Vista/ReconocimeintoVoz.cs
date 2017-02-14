using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using InterfaceTIV.Controladores;

namespace InterfaceTIV.Vista
{
    public partial class ReconocimeintoVoz : Form
    {
        SpeechRecognitionEngine voz = new SpeechRecognitionEngine();

        public ReconocimeintoVoz()
        {
            InitializeComponent();
            this.SetDesktopLocation(10, 340);
            this.Show();
            TopMost = true;
            lblVerificacion.Text = "";
            lblTexto.Text = "";
            Main();
        }


        public void Main() {
            Choices palabras = new Choices();
            palabras.Add(new string[] { "Netflix", "Google", "Hola Henry" });
            Grammar gramatica = new Grammar(new GrammarBuilder(palabras));
            try
            {
                voz.SetInputToDefaultAudioDevice();
                voz.LoadGrammar(new DictationGrammar());
                voz.LoadGrammar(gramatica);
                voz.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Escuchando);
                voz.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("no se puede abrir mas de Una vez");
            }

        }

        public void Escuchando(object sender, SpeechRecognizedEventArgs frase) {

            
            foreach (RecognizedWordUnit palabras in frase.Result.Words)
            {

                lblVerificacion.Text = lblVerificacion.Text + palabras.Text + " ";

            }

            
            lblTexto.Text = lblVerificacion.Text;

            ComandosDeVoz secuencia = new ComandosDeVoz();
            secuencia.comando = lblTexto.Text;
            secuencia.ComandosVoz();

            lblVerificacion.Text = "";
            


        }

       
    }
}
