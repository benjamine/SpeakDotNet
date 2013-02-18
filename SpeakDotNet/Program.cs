using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech;
using System.Speech.AudioFormat;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace SpeakDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = args.Length > 0 ? args[0] : "enter some text as first argument to this command";

            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.
            if (args.Length > 1)
            {
                var audioformat = new SpeechAudioFormatInfo(16000,AudioBitsPerSample.Sixteen, AudioChannel.Mono);
                synth.SetOutputToWaveFile(args[1], audioformat);
            }
            else
            {
                synth.SetOutputToDefaultAudioDevice();
            }

            // Speak a string.
            synth.Speak(text);
        }
    }
}
