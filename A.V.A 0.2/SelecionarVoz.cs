using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace A.V.A_0._2
{
    public partial class SelecionarVoz : Form
    {
        private SpeechSynthesizer sp = new SpeechSynthesizer();
        public SelecionarVoz()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            foreach(InstalledVoice voice in sp.GetInstalledVoices())
            {
                comboBox1.Items.Add(voice.VoiceInfo.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void SelecionarVoz_Load(object sender, EventArgs e)
        {

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            speaker.SetVoz(comboBox1.SelectedItem.ToString());
            string[] remover = { "Microsoft","Desktop", "ScanSoft", "_Full_22kHz" };
            string voz = comboBox1.SelectedItem.ToString();
            int n = 0;
            while (n < remover.Length) 
            {
                voz = voz.Replace(remover[n], "");
                n++;
            }
            speaker.speak("Voz " + voz + " selecionada");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
