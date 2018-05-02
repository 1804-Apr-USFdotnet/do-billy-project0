using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    internal class InputHandler
    {
        public enum InputCommand { Unknown, Show, Details, Find};
        public enum ShowCommand { Top, All }
        static List<string> allowedCommands = new List<string> { "", "show", "details", "find" };

        public static InputCommand DetermineCommand(string input)
        {
            // TODO: Implement
            input = SanitizeInput(input);

            var sa = input.Split();
            if (sa.Count() > 0)
            {
                string maincommand = sa[0];
                Console.WriteLine(maincommand);
                InputCommand n = (InputCommand)allowedCommands.IndexOf(maincommand);
                return n;
            }
            
            return InputCommand.Unknown;
        }

        private static string SanitizeInput(string input)
        {
            return input.ToLower().Trim();
        }
    }
}
