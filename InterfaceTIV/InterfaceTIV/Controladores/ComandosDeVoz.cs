using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTIV.Controladores
{
    class ComandosDeVoz
    {

        public string comando { get; set; }


        public void ComandosVoz()
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();

            Console.WriteLine("...."+comando+"....");

            switch (comando)
            {
                case "Hola Henry ":
                    synth.Speak("");
                    break;
                default:
                    break;
            }




        }
    }
}
