namespace Zoolandia.Animals
{
    class UrsusArctos : Ursus
    {
        public string commonName = "Brown Bear";
        public UrsusArctos(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            CanRoar = true;
        }
    }
}