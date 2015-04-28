using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alice alice = new Alice();
            string message = "";
            string latestAnswer = "";

                System.Console.WriteLine("Hello now you start to talk with A.L.E.N.A. Write something down:");
                while (!message.Equals("stop"))
                {
                try
                {
                    message = Convert.ToString(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nSYSTEM FORMAT EXCEPTION: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(e.StackTrace);
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\nTap to continue...");
                    Console.ReadKey(true);
                }

                System.Console.WriteLine(alice.SetAction(alice.DefineAction(message.ToLower())));
                latestAnswer = message;
                alice.SetLatestAnswer(latestAnswer);
            }

            Console.ReadKey(true);
        }
    }
}
