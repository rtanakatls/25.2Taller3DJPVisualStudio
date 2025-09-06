using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3DJP252
{
    internal class Student : Person
    {
        protected string code;

        public Student(string name, int age) : base(name, age)
        {
        }


        public override string GetData()
        {
            return $"{name} - {age} - {code}";
        }

    }
}
