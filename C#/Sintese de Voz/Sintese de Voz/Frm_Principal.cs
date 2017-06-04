using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace Sintese_de_Voz
{
    public partial class Frm_Principal : Form
    {
        SpeechSynthesizer voz = new SpeechSynthesizer();
    
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_Falar_Click(object sender, EventArgs e)
        {
            voz.SpeakAsyncCancelAll();
            voz.SpeakAsync(txt_Frase.Text);
        }
    }
}
