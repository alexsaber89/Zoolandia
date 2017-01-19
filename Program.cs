using System;
using Zoolandia.Animals;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PantheraTigris myPantheraTigris = new PantheraTigris();
            Console.WriteLine($"This animal's common name is {myPantheraTigris.commonName}.");
            Console.WriteLine($"This animal's name is {myPantheraTigris.Name}.");
            myPantheraTigris.eat();

            PongoPygmaeus myPongoPygmaeus = new PongoPygmaeus();
            Console.WriteLine($"This animal's common name is {myPongoPygmaeus.commonName}.");
            Console.WriteLine($"This animal's name is {myPongoPygmaeus.Name}.");
            myPongoPygmaeus.eat();

            UrsusArctos myUrsusArctos = new UrsusArctos();
            Console.WriteLine($"This animal's common name is {myUrsusArctos.commonName}.");
            Console.WriteLine($"This animal's name is {myUrsusArctos.Name}.");
            myUrsusArctos.eat();
            // EschrichtiusRobustus eschrichtiusRobustus = new EschrichtiusRobustus();
            // eschrichtiusRobustus.sound = "yelp";
            // Console.WriteLine($"I have a {eschrichtiusRobustus.commonName} named {eschrichtiusRobustus.name} who makes a {eschrichtiusRobustus.sound} sound and {eschrichtiusRobustus.endangered}.");
            // eschrichtiusRobustus.eat();

            // EretmochelysImbricata eretmochelysImbricata = new EretmochelysImbricata();
            // eretmochelysImbricata.sound = "chomp";
            // Console.WriteLine($"I have a {eretmochelysImbricata.commonName} named {eretmochelysImbricata.name} who makes a {eretmochelysImbricata.sound} sound and {eretmochelysImbricata.endangered}.");
            // eretmochelysImbricata.eat();

            // DicerosBicornis dicerosBicornis = new DicerosBicornis();
            // dicerosBicornis.sound = "grunt";
            // Console.WriteLine($"I have a {dicerosBicornis.commonName} named {dicerosBicornis.name} who makes a {dicerosBicornis.sound} sound and {dicerosBicornis.endangered}.");
            // dicerosBicornis.eat();

            // AlligatorMississippiensis alligatorMississippiensis = new AlligatorMississippiensis();
            // alligatorMississippiensis.sound = "gurgle";
            // Console.WriteLine($"I have a {alligatorMississippiensis.commonName} named {alligatorMississippiensis.name} who makes a {alligatorMississippiensis.sound} sound and {alligatorMississippiensis.endangered}.");
            // alligatorMississippiensis.eat();
        }
    }
}
