using System.Security.Cryptography.X509Certificates;

namespace CIT_195_Lesson_5_Orrery
{
    interface IPlanet
    {
        public int Number { get; set; }

        string Display();
    }
    class Program
    {
        class Satellite : IPlanet
        {
            public int Number { get; set; }
            public string GreekName { get; set; }
            public string RomanName { get; set; }
            public int OrbitRadius { get; set; }
            public double OrbitPeriod { get; set; }

            public Satellite()
            {
                Number = 0;
                GreekName = string.Empty;
                RomanName = string.Empty;
                OrbitRadius = 0;
                OrbitPeriod = 0;
            }
            public Satellite(int number, string greekName, string romanName, int orbitRadius, double orbitPeriod)
            {
                Number = number;
                GreekName = greekName;
                RomanName = romanName;
                OrbitRadius = orbitRadius;
                OrbitPeriod = orbitPeriod;
            }
            public string Display()
            {
                return $"Satellite statistics\n\nNumber = {Number}\nGreek Name = {GreekName}\nRoman Name = {RomanName}\nOrbit Radius = {OrbitRadius} miles\nOrbit Period = {OrbitPeriod} days";
            }
        }
        static void Main(string[] args)
        {
            Satellite Moon = new Satellite(1, "Selene", "Luna", 239000, 27.3);
            Console.WriteLine(Moon.Display());
        }
    }
}
