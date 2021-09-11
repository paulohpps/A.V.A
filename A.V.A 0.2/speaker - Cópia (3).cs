using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Assistente_Virtual
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
