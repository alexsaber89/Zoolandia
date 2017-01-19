using System;

namespace Zoolandia.Animals
{
    public class Mammal : Vertibrate
    {
        public Mammal()
        {
            base.BirthsLiveYoung = true;
            Console.WriteLine("This animal gives birth to live young.");
        }
    }
}