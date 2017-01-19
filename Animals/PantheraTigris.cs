namespace Zoolandia.Animals
{
    class PantheraTigris : Panthera
    {
        public string commonName = "Tiger";
        public PantheraTigris(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            CanRoar = true;
        }
    }
}