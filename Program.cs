using System;
using Zoolandia.Animals;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var eschrichtiusRobustus = new EschrichtiusRobustus();
            eschrichtiusRobustus.sound = "yelp";
            eschrichtiusRobustus.name = "Fred";
            Console.WriteLine($"I have a {eschrichtiusRobustus.commonName} named {eschrichtiusRobustus.name} who makes a {eschrichtiusRobustus.sound} sound and {eschrichtiusRobustus.endangered}.");

            var eretmochelysImbricata = new EretmochelysImbricata();
            eretmochelysImbricata.sound = "chomp";
            eretmochelysImbricata.name = "Donald";
            Console.WriteLine($"I have a {eretmochelysImbricata.commonName} named {eretmochelysImbricata.name} who makes a {eretmochelysImbricata.sound} sound and {eretmochelysImbricata.endangered}.");

            var dicerosBicornis = new DicerosBicornis();
            dicerosBicornis.sound = "grunt";
            dicerosBicornis.name = "Jim";
            Console.WriteLine($"I have a {dicerosBicornis.commonName} named {dicerosBicornis.name} who makes a {dicerosBicornis.sound} sound and {dicerosBicornis.endangered}.");

            var alligatorMississippiensis = new AlligatorMississippiensis();
            alligatorMississippiensis.sound = "gurgle";
            alligatorMississippiensis.name = "Susan";
            Console.WriteLine($"I have a {alligatorMississippiensis.commonName} named {alligatorMississippiensis.name} who makes a {alligatorMississippiensis.sound} sound and {alligatorMississippiensis.endangered}.");
        }
    }
}
