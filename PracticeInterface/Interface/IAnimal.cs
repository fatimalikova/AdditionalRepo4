using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterface.Interface
{
    internal interface IAnimal
    {
        string Name { get; }
        int Age { get; }
        void Speak();
        void Eat();
        void Move();
        void Sleep();
    }
}
