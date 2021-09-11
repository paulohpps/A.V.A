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
    }
}
