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
            Console.WriteLine("\nDu är påväg hem och du ska gå in i ditt hus. Sedan göra dig i ordning för att sova.");

            while (true) //oändlig loop
            {
                Console.Write("\n>");
                input = Console.ReadLine();

                if (input == "dörr" || input == "öppna dörr" || input == "gå till dörr")
                {
                    if (harNyckel)
                    {
                        Console.WriteLine("Du öppnar dörren och går igenom");
                        break;
                    }
                    else
                        Console.WriteLine("Den är låst");
                }

                else if (input == "nyckel" || input == "ta nyckel")
                {
                    Console.WriteLine("Du tog nyckeln");
                    harNyckel = true;
                }
                else
                    Console.WriteLine("Icke gilltigt eller felstavat commando!");

            }

            Console.WriteLine("\nDu vann!!! Spelet stängs av...");
            Console.ReadLine();
        }
    }
}