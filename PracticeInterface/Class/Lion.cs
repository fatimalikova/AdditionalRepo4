using PracticeInterface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterface.Class
{
    internal class Lion : IAnimal
    {
        public string Name = "Simba";

        public int Age = 15;

        string IAnimal.Name => throw new NotImplementedException();

        int IAnimal.Age => throw new NotImplementedException();

        public void Eat()
        {
            Console.WriteLine("Lion is eating something");
        }

        public void Move()
        {
            Console.WriteLine("Lion is running");
        }

        public void Speak()
        {
            Console.WriteLine("Lion is roaring");
        }
    }
}
