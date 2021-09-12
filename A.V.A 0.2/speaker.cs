using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace A.V.A_0._2
{
    class speaker
    {
        private static SpeechSynthesizer sp = new SpeechSynthesizer();
        public static void speak(string text)
        {
            if (sp.State == SynthesizerState.Speaking)
                sp.SpeakAsyncCancelAll();
            sp.SpeakAsync(text);
        }
        public static void speak(params string[] texts)
        {
            Random rnd = new Random();
            speak(texts[rnd.Next(0, texts.Length)]);
        }
        public static void SetVoz(string voice)
        {
            sp.SelectVoice(voice);
        }
    }
}
