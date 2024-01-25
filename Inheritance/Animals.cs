using System;
namespace Inheritance
{
    // Create a class Animal
    // give this class 4 members that all Animals have in common

    public class Animals
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string Color { get; set; }

        public void PrintAnimalDetails()
        {
            Console.WriteLine($"The Animals name is {Name}");
            Console.WriteLine($"The Animal is {Age}");
            Console.WriteLine($"The color od the Animal is {Color}");
        }

    }
}

