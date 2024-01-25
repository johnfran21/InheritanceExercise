using System;
namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class

    public class Birds : Animals
    {
        public string Type { get; set; }
        public string Weight { get; set; }
        public bool CanFly { get; set; }

        public void PrintBirdsDetails()
        {
            Console.WriteLine($"Type of Bird: {Type}");
            Console.WriteLine($"Weight of Bird: {Weight}");
            Console.WriteLine($"Bird Can Fly: {CanFly}");
        }
    }
}

