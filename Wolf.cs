using System;
namespace TheZoo
{
    public class Wolf : IAnimal
    {
        public int age { get ; set ; }
        public string species { get ; set ; }

        public int speed;

        public string GetDescription()
        {
            return $"contains a {age}-year-old wolf that runs {speed} km/h.";
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("How fast can it run (in km/h)? ");
            speed = int.Parse(Console.ReadLine());
        }
    }
}

