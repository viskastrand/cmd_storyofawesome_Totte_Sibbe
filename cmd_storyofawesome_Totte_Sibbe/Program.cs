using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmd_storyofawesome_Totte_Sibbe
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean harNyckel = false;
            string input;

            Console.WriteLine("---Välkommen till Story Of Awesome---");
            Console.WriteLine("\nDU ska in, starta och köra iväg din bil.");

            while (true) //oändlig loop
            {
                Console.Write("\n>");
                input = Console.ReadLine();

                if (input == "dörr" || input == "öppna dörr" || input == "gå till dörr")
                {
                    if (harNyckel)
                    {
                        Console.WriteLine("Du öppnar dörren, sätter dig i bilen och kör iväg.");
                        break;
                    }
                    else
                        Console.WriteLine("Bildörren är låst, du behöver en nyckel.");
                }

                else if (input == "nyckel" || input == "ta nyckel")
                {
                    Console.WriteLine("Du tog nyckeln");
                    harNyckel = true;
                }
                else
                    Console.WriteLine("Ditt commando är inte giltigt.");

            }

            Console.WriteLine("\nDu vann!");
            Console.ReadLine();
        }
    }
}