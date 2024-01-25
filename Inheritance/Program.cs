using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {


            Animals animal1 = new Animals();
            animal1.Name = "Steve";
            animal1.Age = 10;
            animal1.Color = "Red and White";


            Birds bird1 = new Birds();
            bird1.Type = "Cardinal";
            bird1.Weight = "1.5 oz";
            bird1.CanFly = true;

            Reptiles reptile1 = new Reptiles();
            reptile1.Legs = 2;
            reptile1.CanSwim = true;
            reptile1.Skin = "It has Scales";

            animal1.PrintAnimalDetails();

            bird1.PrintBirdsDetails();

            reptile1.PrintReptilesDetails();

            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
