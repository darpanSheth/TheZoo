using System;
namespace TheZoo
{
	public interface IAnimal
	{
		public int age { get; set; }
		public string species { get; set; }

        public string GetDescription();
        public void RequestUniqueCharacteristic();
    }

	
}

