using PracticeInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterface.Class
{
    internal class Bear : IAnimal
    {
        public string Name = "Baloo";

        public int Age = 10;

        string IAnimal.Name => throw new NotImplementedException();

        int IAnimal.Age => throw new NotImplementedException();

        public void Eat()
        {
            Console.WriteLine("Bear is eating honey");
        }

        public void Move()
        {
            Console.WriteLine("Bear is running");
        }

        public void Speak()
        {
            Console.WriteLine("Bear is silent");
        }
    }
}
