using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestaurantReviewsLibrary;
using RestaurantReviewsLibrary.Interfaces;
using RestaurantReviewsLibrary.Models;
using NLog;

namespace PresentationLayer
{
    class Program
    {
        static List<IRestaurantInfo> currentList;
        static RestaurantsInfo rinfo;
        static Logger logHandler;

        static void Main(string[] args)
        {
            string inputString = "";
            rinfo = new RestaurantsInfo();
            logHandler = LogManager.GetLogger("f");

            while (inputString != "quit")
            {
                PrintCommands();

                inputString = Console.ReadLine();
                Console.Clear();

                //DisplayTop3();

                logHandler.Info(inputString);
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

        static void DisplayTop3()
        {
            Console.WriteLine("Restaurant Name\t|| Average Rating || Number of Reviews");
            foreach(var rest in rinfo.GetTopThreeRestaurants())
            {
                Console.WriteLine(rest.Name + "|| " + rest.GetAverageRating + "|| " + rest.ReviewCount);
            }
        }
    }
}
