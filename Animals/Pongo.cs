using System;
namespace Zoolandia.Animals
{
    class Pongo : Animal
    {
        public bool CanRoar { get; set; }
        public Pongo()
        {
            Genus = "Pongo";
            Console.WriteLine("This animal's genus is Pongo");
        }
        public override void eat()
        {
            Console.WriteLine($"{this.Name} will eat fruits and vegetables.");
        }
    }
}