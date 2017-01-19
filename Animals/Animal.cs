using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Genus { get; set; }
        public bool HasBackbone = true;
        public bool BirthsLiveYoung = true;
        public virtual void eat ()
        {
            Console.WriteLine("Animals like to eat.");
        }
    }
}
