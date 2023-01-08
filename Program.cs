using System;
using System.Collections;
using TheZoo;

var Animals = new List<IAnimal>();


for(int i = 0; i <= 2; i++)
{
    Console.WriteLine($"Cage {i+1}");
    Console.Write("What is the animal's species? ");
    string species = Console.ReadLine().ToLower();
    if(species == "lion")
    {
        Animals.Add(new Lion());
    }
    else if (species == "wolf")
    {
        Animals.Add(new Wolf());
    }
    else if (species == "bear")
    {
        Animals.Add(new Bear());
    }
    else
    {
        throw new ArgumentException("Please enter valid species name.");
    }

    Console.Write("How old is it? ");
    Animals[i].age = int.Parse(Console.ReadLine());

    Animals[i].RequestUniqueCharacteristic();

    Console.WriteLine();

}

for(int i = 0; i < Animals.Count; i++)
{
    Console.WriteLine($"Cage {i+1} {Animals[i].GetDescription()}");
}