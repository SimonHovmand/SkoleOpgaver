using Planterne;

namespace Planterne
{
    public class Program
    {
        static void Main(string[] args)
        {
            //2\\ (1 forfindes i "planet.cs"
            List<Planet> planets = new List<Planet>();

            planets.Add(new Planet("Mercury", 0.333, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88, 47.4, 167, 0, false));
            planets.Add(new Planet("Earth", 5.97, 12756, 5514, 9.8, 23.9, 24, 149.6, 365.2, 29.8, 15, 1, false));
            planets.Add(new Planet("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687, 24.1, -65, 2, false));
            planets.Add(new Planet("Jupiter", 1898, 142984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true));
            planets.Add(new Planet("Saturn", 568, 120536, 687, 9, 10.7, 10.7, 1433.5, 10.747, 9.7, 140, 62, true));
            planets.Add(new Planet("Uranus", 86.6, 51118, 1271, 8.7, -17.2, 17.2, 2872.5, 30.859, 6.8, -195, 27, true));
            planets.Add(new Planet("Neptun", 102, 49582, 1638, 11, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true));
            planets.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, true));

            //3\\

            //foreach (Planet planet in planets)
            //{
            //    Console.WriteLine(planet.ToString());
            //}

            //4\\
            planets.Insert(1, new Planet("Venus", 4.87, 12104, 5243, 8.9, -5832, 2802, 108.2, 224.7, 34, 464, 0, false));
            Console.WriteLine("--------------------");

            //5\\

            //foreach (Planet planet in planets)
            //{
            //    Console.WriteLine(planet.ToString());
            //}

            //6
            Planet temppluto = null;

            foreach (Planet planet in planets)
            {
                if (planet.Name == "Pluto")
                {
                    temppluto = planet;
                }
            }
            if (temppluto != null) //If temppluto is not null
            {
                planets.Remove(temppluto);  
            }

            //Console.WriteLine("--------------------");
            //foreach (Planet planet in planets)
            //{
            //    Console.WriteLine(planet.ToString());
            //}

            //7\\
            planets.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, true)); //Add Pluto to planets

            //8\\
            Console.WriteLine(planets.Count); //Write the count of planets

            //9\\

            foreach (Planet planet in planets)
            {
                if (planet.MeanTemp < 0) //If planet.MeanTemp is under 0
                {
                    Console.WriteLine(planet.ToString());
                }
            }

            //10\\

            List<Planet> planets2 = new List<Planet>();

            foreach (Planet planet in planets)
            {
                if (planet.Diameter > 10000 && planet.Diameter < 50000) //If planet.Diameter is over 10000 & under 50000
                {
                    planets2.Add(planet); //Add plant to planets2
                }
            }

            foreach (Planet planet in planets2) //Write all planets in list planets2
            {
                Console.WriteLine(planet.ToString());
            }

            //11\\
            planets.Clear();
        }
    }
}