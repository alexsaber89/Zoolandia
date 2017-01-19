using System;
namespace Zoolandia.Animals
{
    class EschrichtiusRobustus : Animal
    {
        public string commonName = "Gray Whale";
        public int cutenessFactor = 8;
        public string endangered = "is not endangered";
        public string sound { get; set; }
        public override void eat()
        {
            Console.WriteLine("Gray Whales like to eat plankton!");
        }
        public EschrichtiusRobustus()
        {
            // this.name = "Whale Whitney";
        }
    }
}