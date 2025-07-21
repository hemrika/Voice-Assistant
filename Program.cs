using System;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace CSVoiceAssistant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Voice Assistant...");
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            using (SpeechRecognitionEngine rec = new SpeechRecognitionEngine())
            {
                synth.Speak("Hello. I am your voice assistant. Say 'exit' to quit.");

                Choices choices = new Choices(new string[] { "hello", "what is the time", "exit" });
                GrammarBuilder gb = new GrammarBuilder(choices);
                rec.LoadGrammar(new Grammar(gb));
                rec.SetInputToDefaultAudioDevice();

                while (true)
                {
                    Console.WriteLine("Listening...");
                    RecognitionResult result = rec.Recognize();
                    if (result != null)
                    {
                        string text = result.Text.ToLower();
                        Console.WriteLine("You said: " + text);

                        if (text == "hello")
                            synth.Speak("Hi there!");
                        else if (text == "what is the time")
                            synth.Speak("The current time is " + DateTime.Now.ToShortTimeString());
                        else if (text == "exit")
                        {
                            synth.Speak("Goodbye!");
                            break;
                        }
                        else
                            synth.Speak("Sorry, I didn't understand that.");
                    }
                }
            }
        }
    }
}
