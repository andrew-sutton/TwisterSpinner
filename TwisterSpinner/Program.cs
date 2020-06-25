using System;
using System.Xml.Schema;

namespace TwisterSpinner
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = false;
            var colors = new string[] { "Green", "Red", "Yellow", "Blue" };
            var bodyParts = new string[] { "Right Hand", "Left Hand", "Right Foot", "Left Foot" };
            var r = new Random();
            var exit = "";
            Console.WriteLine("Welcome to the Twister Spinner!");
            Console.WriteLine("Type \"exit\" to exit or hit any key to continue");
            exit = Console.ReadLine();
            while (exitCode == false)
            {
                Console.WriteLine($"{bodyParts[r.Next(0, 4)]} on {colors[r.Next(0, 4)]}!");
                exit = Console.ReadLine();
                if (exit == "exit") { exitCode = true; }
            } 
        }
    }
}
