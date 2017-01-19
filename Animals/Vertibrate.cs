using System;

namespace Zoolandia.Animals
{
    public class Vertibrate : Animal
    {
        public Vertibrate()
        {
            HasBackbone = true;
            Console.WriteLine("This animal has a backbone.");
        }
    }
}