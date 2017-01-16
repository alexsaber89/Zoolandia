using System;
using Zoolandia.Animals;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var eschrichtiusRobustus = new EschrichtiusRobustus();
            eschrichtiusRobustus.name = "Fred";
            Console.WriteLine($"I have a {eschrichtiusRobustus.commonName} named {eschrichtiusRobustus.name} who {eschrichtiusRobustus.endangered}.");

            var eretmochelysImbricata = new EretmochelysImbricata();
            eretmochelysImbricata.name = "Donald";
            Console.WriteLine($"I have a {eretmochelysImbricata.commonName} named {eretmochelysImbricata.name} who {eretmochelysImbricata.endangered}.");

            var dicerosBicornis = new DicerosBicornis();
            dicerosBicornis.name = "Jim";
            Console.WriteLine($"I have a {dicerosBicornis.commonName} named {dicerosBicornis.name} who {dicerosBicornis.endangered}.");

            var alligatorMississippiensis = new AlligatorMississippiensis();
            alligatorMississippiensis.name = "Susan";
            Console.WriteLine($"I have a {alligatorMississippiensis.commonName} named {alligatorMississippiensis.name} who {alligatorMississippiensis.endangered}.");
        }
    }
}
