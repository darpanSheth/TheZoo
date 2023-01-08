using System;


namespace TheZoo
{
	public class Lion : IAnimal
	{
        public int age { get; set ; }
        public string species { get ; set ; }

        public string ManeColour;

        public string GetDescription()
        {
            return $"contains a {age}-year-old lion with a {ManeColour} mane.";
        }

        public void RequestUniqueCharacteristic()
        {
            Console.Write("What colour is its mane? ");
            ManeColour = Console.ReadLine();
        }
    }

    
}

