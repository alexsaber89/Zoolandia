using System;
namespace Zoolandia.Animals
{
    class Panthera : Animal
    {
        public bool CanRoar { get; set; }
        public Panthera()
        {
            Genus = "Panthera";
            Console.WriteLine("This animal's genus is Panthera");
        }
        public override void eat()
        {
            Console.WriteLine($"{this.Name} will eat any meat it can get!");
        }
    }
}