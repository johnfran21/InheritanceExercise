using System;
namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class


    public class Reptiles : Animals
	{
		public int Legs { get; set; }
        public bool CanSwim { get; set; }
        public string Skin { get; set; }

        public void PrintReptilesDetails()
        {
            Console.WriteLine($"Reptile has {Legs} Legs.");
            Console.WriteLine($"Reptile Can Swim: {CanSwim}");
            Console.WriteLine($"Reptile has {Skin} for its Skin.");
        }
    }
}

