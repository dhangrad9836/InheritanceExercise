using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
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
            var blueJay = new Bird()
            {
                Name = "Blue Jay",
                BeakColor = "Yellow",
                CanFly= true,
                Eat = "Seeds",
                FeatherColor = "Blue",
                CanWalk = true,                                                           
            };
            Console.WriteLine($"A {blueJay.Name} has {blueJay.FeatherColor} feathers " +
                $"and eats {blueJay.Eat}");
            
            Console.WriteLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var iguana = new Reptile();
            iguana.Name = "Iguana";
            iguana.LayEggs = true;
            iguana.HasMoreThanOneLung = true;
            iguana.HasDrySkin= true;

            var animals = new Animal[] {blueJay, iguana};
            foreach(var animal in animals)
            {
                Console.WriteLine($"{animal.Name}");
                Console.WriteLine($"{animal.Eat}");
                Console.WriteLine($"{animal.CanWalk}");
                Console.WriteLine($"{animal.CanSpeak}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
