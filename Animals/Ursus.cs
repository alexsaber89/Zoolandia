using System;
namespace Zoolandia.Animals
{
    class Ursus : Animal
    {
        public bool CanRoar { get; set; }
        public Ursus()
        {
            Genus = "Ursus";
            Console.WriteLine("This animal's genus is Ursus");
        }
        public override void eat()
        {
            Console.WriteLine($"{this.Name} will eat fruits, vegetables, and meat.");
        }
    }
}