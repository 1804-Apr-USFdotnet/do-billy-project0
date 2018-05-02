using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "";

            while (inputString != "quit")
            {
                PrintCommands();

                inputString = Console.ReadLine();
                Console.Clear();

                InputHandler.DetermineCommand(inputString);
                //Console.WriteLine();
            }
        }

        static void PrintCommands()
        {
            string commandstr = 
                "\t\tCommands:" + "\n" +
                "\t\tshow top" + "\n" +
                "\t\tshow top N" + "\n" +
                "\t\tshow all" + "\n" +
                "\t\tshow [restaurant name]" + "\n" +
                "\t\tdetails" + "\n" +
                "\t\tfind" + "\n" +
                "\t\tfind [restaurant]" + "\n" +
                "\t\tquit\n";
            Console.WriteLine(commandstr);
            Console.Write("input >>> ");
        }
    }
}
