using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberSecurityBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VoiceGreeting();
            ShowAsciiArt();
            Console.WriteLine("\nWhat's your name? ");
            string userName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nWelcome, {userName}! I'm your Cybersercurity Awareness Assistant.");
            Console.ResetColor();

            ShowMenu(userName);

        }

        static void VoiceGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("welcome.wav");
                player.Play();// Wait until it's done
            }
            catch (Exception ex) {
                Console.WriteLine("Error while playing voice greeting : " + ex.Message);
            }
        }
        static void ShowAsciiArt()
        {
            string asciiLogo = @"
                  
   ____   ____  _____  __  __   ___    ____       _____ __  __   ___    ____   ___ 
  / __/  / __/ / ___/ / / / /  / _ \  / __/      / ___/ \ \/ /  / _ )  / __/  / _ \
 _\ \   / _/  / /__  / /_/ /  / , _/ / _/       / /__    \  /  / _  | / _/   / , _/
/___/  /___/  \___/  \____/  /_/|_| /___/       \___/    /_/  /____/ /___/  /_/|_| 
                                                                                   
                                                                                                         

             Cybersecurity Awareness Assistant";
             Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(asciiLogo);
            Console.ResetColor();

        }
        static void ShowMenu(string userName)
        {
            while (true)
            {
                Console.WriteLine("\nAsk me something (type 'exit' to quit):");
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter something.");
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine($"Goodbye, {userName}. Stay safe online!");
                    break;
                }

                RespondToInput(input);
            }
        }

        static void RespondToInput(string input)
        {
            if (input.Contains("How are you?"))
            {
                TypeEffect("I'm fully functional and ready to help you stay secure!");
            }
            else if (input.Contains("What's your purpose?"))
            {
                TypeEffect("I am here to teach you about staying safe online—like avoiding phishing, using strong passwords, and safe browsing.");
            }
            else if (input.Contains("Password safety recommendation"))
            {
                TypeEffect("Use long, unique passwords and a password manager. Never reuse passwords!");
            }
            else if (input.Contains("What is phishing?"))
            {
                TypeEffect("Phishing is when attackers trick you into giving away sensitive info. Be cautious of unknown links or emails.");
            }
            else if (input.Contains("Safe browsing"))
            {
                TypeEffect("Use HTTPS websites, avoid clicking on pop-ups, and keep your browser up-to-date.");
            }
            else
            {
                TypeEffect("I didn't quite understand that. Could you rephrase?");
            }
        }

        static void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }
    }
}
