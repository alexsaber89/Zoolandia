namespace Zoolandia.Animals
{
    class PongoPygmaeus : Pongo
    {
        public string commonName = "Bornean Orangutan";
        public PongoPygmaeus(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            CanRoar = true;
        }
    }
}