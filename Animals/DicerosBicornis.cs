using System;
namespace Zoolandia.Animals
{
    class DicerosBicornis : Animal
    {
        public string commonName = "Black Rhino";
        public int cutenessFactor = 5;
        public string endangered = "is endangered";
        public string sound { get; set; }
        public override void eat()
        {
            Console.WriteLine("Black Rhinos like to eat veggies!");
        }
        public DicerosBicornis()
        {
            // this.name = "Rhino Rudy";
        }
    }
}