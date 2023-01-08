using System;
namespace TheZoo
{
    public class Bear : IAnimal
    {
        public int age { get; set ; }
        public string species { get ; set ; }

        public bool IsGrizzly;

        public string GetDescription()
        {
            if(IsGrizzly)
                return $"contains a {age}-year-old grizzly bear.";
            else
                return $"contains a {age}-year-old non-grizzly bear.";
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("Is it a grizzly bear (true/false)? ");
            IsGrizzly = bool.Parse(Console.ReadLine().ToLower());

        }
    }
}

