using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP252
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string name;
            bool continueFlag = true;

            Console.WriteLine("Introduce tu nombre:");
            name = Console.ReadLine();

            while (continueFlag)
            {
                Console.WriteLine("Introduce tu edad:");
                age = int.Parse(Console.ReadLine());
                if (age >= 0)
                {
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("La edad no puede ser negativa");
                }
            }

            Console.WriteLine($"Hola {name} tienes {age} años");
        }
    }
}
