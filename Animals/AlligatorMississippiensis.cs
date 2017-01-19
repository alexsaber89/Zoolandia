using System;
namespace Zoolandia.Animals
{
    class AlligatorMississippiensis : Animal
    {
        public string commonName = "American Alligator";
        public int cutenessFactor = 2;
        public string endangered = "is not endangered";
        public string sound { get; set; }
        public override void eat()
        {
            Console.WriteLine("American Alligators like to eat any meat they can get!");
        }
        public AlligatorMississippiensis()
        {
            // this.name = "Alligator Al";
        }
    }
}