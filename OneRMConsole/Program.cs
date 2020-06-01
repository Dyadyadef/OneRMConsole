using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneRMConsole.Model;

namespace OneRMConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise benchPress = new Exercise("Жим штанги лежа");
            Console.WriteLine("Упражнение: " + benchPress.ToString());

            Console.WriteLine("\nМеню: ");
            Console.WriteLine("a - Полный рассчет.");
            Console.WriteLine("q - выход.");

            bool menu = true;
            while (menu)
            {
                switch (Console.ReadLine())
                {
                    case "q": menu = false; break;
                    case "a":
                        {
                            benchPress.calculate();
                        }
                        break;
                    default: break;
                }
            }
        }
    }
}
