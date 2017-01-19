using System;
namespace Zoolandia.Animals
{
    class EretmochelysImbricata : Animal
    {
        public string commonName = "Hawksbill Turtle";
        public int cutenessFactor = 7;
        public string endangered = "is endangered";

        public string sound { get; set; }
        public override void eat()
        {
            Console.WriteLine("Hawksbill Turtles like to eat sea creatures!");
        }
        public EretmochelysImbricata()
        {
            // this.name = "Turtle Tony";
        }
    }
}