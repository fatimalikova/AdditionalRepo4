using PracticeInterface.Class;
using PracticeInterface.Interface;

namespace PracticeInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal[] animals = new IAnimal[3];
            animals[0] = new Lion();
            animals[1] = new Bear();
            animals[2] = new Sloth();

            foreach (IAnimal animal in animals)
            {
                Console.WriteLine($"Animal: {animal.GetType().Name}");
                animal.Speak();
                animal.Eat();
                animal.Move();
                Console.WriteLine();
            }
        }
    }
}
