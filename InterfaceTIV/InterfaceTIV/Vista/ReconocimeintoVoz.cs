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

namespace InterfaceTIV.Vista
{
    public partial class ReconocimeintoVoz : Form
    {
        SpeechRecognitionEngine voz = new SpeechRecognitionEngine();

        public ReconocimeintoVoz()
        {
            InitializeComponent();
            this.SetDesktopLocation(420, 8);
            this.Show();
            TopMost = true;
            label1.Text = "";
            label2.Text = "";
            Main();
        }


        public void Main() {

            try
            {
                voz.SetInputToDefaultAudioDevice();
                voz.LoadGrammar(new DictationGrammar());
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

                label1.Text = label1.Text + palabras.Text + " ";

            }

            
            label2.Text = label1.Text;

            label1.Text = ""; 
            


        }




    }
}
