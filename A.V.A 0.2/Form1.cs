using Microsoft.Speech.Recognition;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace A.V.A_0._2
{
    public partial class Form1 : Form
    {
        #region variaveis
        private SpeechRecognitionEngine engine;

        #endregion

        public void SpeechRec()
        {
            #region speech
            try
            {

                engine = new SpeechRecognitionEngine();
                engine.SetInputToDefaultAudioDevice();

                #region Grammar

                Choices c_comandosDoSistema = new Choices();
                Choices cNumbers = new Choices();

                #region Numbers
                for (int i = 0; i <= 1; i++)
                {
                    cNumbers.Add(i.ToString());
                }
                GrammarBuilder gbNumber = new GrammarBuilder();
                gbNumber.Append(cNumbers);
                gbNumber.Append(new Choices("Vezes", "mais", "Menos", "Por"));
                gbNumber.Append(cNumbers);

                Grammar gNumbers = new Grammar(gbNumber);
                gNumbers.Name = "calc";
                #endregion

                #region Interface

                c_comandosDoSistema.Add(grammar.Minimizar.ToArray());
                c_comandosDoSistema.Add(grammar.TamanhoNormal.ToArray());
                c_comandosDoSistema.Add(grammar.Maximizar.ToArray());
                c_comandosDoSistema.Add(grammar.SegundoPlano.ToArray());
                c_comandosDoSistema.Add(grammar.PrimeiroPlano.ToArray());

                #endregion

                #region Outros

                c_comandosDoSistema.Add(grammar.CpuUso.ToArray());
                c_comandosDoSistema.Add(grammar.RAMUso.ToArray());
                c_comandosDoSistema.Add(grammar.StatusGerais.ToArray());

                #endregion

                #region time
                c_comandosDoSistema.Add(grammar.Horas.ToArray());
                c_comandosDoSistema.Add(grammar.Data.ToArray());
                #endregion

                #region open
                c_comandosDoSistema.Add(grammar.Chrome.ToArray());
                c_comandosDoSistema.Add(grammar.Notepad.ToArray());
                c_comandosDoSistema.Add(grammar.Cmd.ToArray());
                c_comandosDoSistema.Add(grammar.Explorer.ToArray());
                c_comandosDoSistema.Add(grammar.OpenDocuments.ToArray());
                c_comandosDoSistema.Add(grammar.OpenImagens.ToArray());
                c_comandosDoSistema.Add(grammar.OpenDownloads.ToArray());
                c_comandosDoSistema.Add(grammar.OpenVideos.ToArray());
                c_comandosDoSistema.Add(grammar.Steam.ToArray());
                c_comandosDoSistema.Add(grammar.Discord.ToArray());

                #endregion

                #region stop
                c_comandosDoSistema.Add(grammar.ChromeStop.ToArray());
                c_comandosDoSistema.Add(grammar.ExploreStop.ToArray());
                c_comandosDoSistema.Add(grammar.NotaPadStop.ToArray());
                c_comandosDoSistema.Add(grammar.DiscordStop.ToArray());
                #endregion

                GrammarBuilder gb_comandosDoSistema = new GrammarBuilder();
                gb_comandosDoSistema.Append(c_comandosDoSistema);
                Grammar g_comandosDoSistema = new Grammar(gb_comandosDoSistema);
                g_comandosDoSistema.Name = "sys";

                engine.LoadGrammar(g_comandosDoSistema);
                engine.LoadGrammar(gNumbers);
                #endregion

                #region events
                engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(rec);
                engine.AudioLevelUpdated += new EventHandler<AudioLevelUpdatedEventArgs>(audioUp);

                #endregion
                speaker.speak("Carregamento Completo");
                engine.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no Rec " + ex.Message);
            }
            #endregion
        }

        public Form1()
        {
            speaker.speak("Inicializando o Sistema");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SpeechRec();
        }

        private void rec(object s, SpeechRecognizedEventArgs e)
        {
            #region variaveis de resposta
            string speech = e.Result.Text;
            float conf = e.Result.Confidence;
            #endregion

            #region resposta
            if (conf > 0.35f)
            {
                switch (e.Result.Grammar.Name)
                {
                    case "sys":

                        #region interface

                        if (grammar.Minimizar.Any(x => x == speech))
                        {
                            this.WindowState = FormWindowState.Minimized;
                            speaker.speak("A Janela Minimizada");
                        }
                        if (grammar.Maximizar.Any(x => x == speech))
                        {
                            this.WindowState = FormWindowState.Maximized;
                            speaker.speak("A Janela Maximizada");
                        }
                        if (grammar.TamanhoNormal.Any(x => x == speech))
                        {
                            this.WindowState = FormWindowState.Normal;
                            speaker.speak("A Janela em Tamanho Normal");
                        }
                        if (grammar.SegundoPlano.Any(x => x == speech))
                        {
                            this.Hide();
                            speaker.speak("A Janela estar em Segundo Plano");
                        }
                        if (grammar.PrimeiroPlano.Any(x => x == speech))
                        {
                            this.Show();
                            speaker.speak("A Janela estar em Primeiro Plano");
                        }

                        #endregion

                        #region outros
                        if (grammar.CpuUso.Any(x => x == speech))
                        {
                            int cputext = (int)CPU.NextValue();
                            speaker.speak("O Uso de CPU Estar em " + cputext.ToString() + "%");
                        }
                        if (grammar.RAMUso.Any(x => x == speech))
                        {
                            int ramtext = (int)RAM.NextValue();
                            speaker.speak("O Uso de Memoria Estar em " + ramtext.ToString() + "%");
                        }
                        if (grammar.StatusGerais.Any(x => x == speech))
                        {
                            int cputext = (int)CPU.NextValue();
                            int ramtext = (int)RAM.NextValue();
                            speaker.speak("O Uso de Memoria Estar em " + ramtext.ToString() + "% ,e o Uso de CPU Estar em " + cputext.ToString() + "%");
                        }
                        #endregion

                        #region data e hora

                        if (grammar.Horas.Any(x => x == speech))
                        {
                            resp.horas();
                        }
                        if (grammar.Data.Any(x => x == speech))
                        {
                            resp.data();
                        }

                        #endregion

                        #region abrir

                        if (grammar.Chrome.Any(x => x == speech))
                            resp.chrome();
                        if (grammar.Notepad.Any(x => x == speech))
                            resp.notepad();
                        if (grammar.Cmd.Any(x => x == speech))
                            resp.cmd();
                        if (grammar.Explorer.Any(x => x == speech))
                            resp.explorer();
                        if (grammar.OpenDocuments.Any(x => x == speech))
                            resp.OpenDocuments();
                        if (grammar.OpenImagens.Any(x => x == speech))
                            resp.OpenImages();
                        if (grammar.OpenVideos.Any(x => x == speech))
                            resp.OpenVideos();
                        if (grammar.OpenDownloads.Any(x => x == speech))
                            resp.OpenDownload();
                        if (grammar.Steam.Any(x => x == speech))
                            resp.steam();
                        if (grammar.Discord.Any(x => x == speech))
                            resp.Discord();
                        #endregion

                        #region fechar

                        if (grammar.ChromeStop.Any(x => x == speech))
                            resp.chromestop();

                        if (grammar.NotaPadStop.Any(x => x == speech))
                            resp.notestop();

                        if (grammar.DiscordStop.Any(x => x == speech))
                            resp.discordstop();
                        if (grammar.ExploreStop.Any(x => x == speech))
                            resp.ExploreStop();

                        #endregion

                        break;

                    case "calc":

                        speaker.speak(Calculadora.Solver(speech));

                        break;

                }
                this.label2.Text = "Reconhecido: " + speech;
            }
            #endregion
        }

        #region Interface

        private void audioUp(object s, AudioLevelUpdatedEventArgs e)
        {
            this.audiovol.Maximum = 100;
            this.audiovol.Value = e.AudioLevel;
            if (audiovol.Value >= 10)
                this.recs.ForeColor = Color.Red;
            else
                this.recs.ForeColor = Color.DodgerBlue;
        }

        #endregion

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            float Fcpu = CPU.NextValue();
            int Fcpui = (int)Fcpu;
            CPUBAR.Value = (int)Fcpu;
            CPUBAR.Text = string.Format(Fcpui + "%");
            float Fram = RAM.NextValue();
            int Frami = (int)Fram;
            RAMBAR.Value = (int)Fram;
            RAMBAR.Text = string.Format(Frami + "%");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

