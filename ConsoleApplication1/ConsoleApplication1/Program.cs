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
            Alena alena = new Alena();
            string message = "";

            Console.WriteLine("Hello now you start to talk with A.L.E.N.A. Write something down:");
            while (!message.Equals("stop"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("YOU: ");
                Console.ResetColor();

                try
                {
                    message = Convert.ToString(Console.ReadLine());
                }
                catch (FormatException e)
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

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("A.L.E.N.A: ");
                Console.ResetColor();
                Console.WriteLine(alena.SetAction(alena.DefineAction(message)));
                alena.SetLatestAnswer(message);
            }

            Console.ReadKey(true);
        }
    }
}
