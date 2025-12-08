using PracticeInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterface.Class
{
    internal class Sloth : IAnimal
    {
        public string Name => throw new NotImplementedException();

        public int Age => throw new NotImplementedException();

        public void Eat()
        {
            Console.WriteLine("Sloth is eating leaves");
        }

        public void Move()
        {
            Console.WriteLine("Sloth is moving slowly");
        }

        public void Speak()
        {
            Console.WriteLine("Sloth is making a soft sound");
        }
    }
}
