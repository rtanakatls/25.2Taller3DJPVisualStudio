using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP252
{
    internal class Menu
    {
        public void Execute()
        {
            Person p1 = new Person("Tanaka",50);
            Person p2 = new Person("Pedro",10);

            int a = 50;


            Console.WriteLine(p1.GetData());
            Console.WriteLine(a);
            Person p3 = p1;
            p3.IncreaseAge();
            int b = a;
            b++;
            Console.WriteLine(p1.GetData());
            Console.WriteLine(a);

        }

        private Person GetPerson()
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
            return new Person(name, age);
        }
    }
}
