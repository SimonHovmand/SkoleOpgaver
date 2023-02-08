using Planterne;

namespace Planterne
{

    public class Program
    {

        static void Main(string[] args)
        {

            List<Planets> planets = new List<Planets>();

            planets.Add(new Planets("Mercury", 0.333, 4879, 5427, 3.7, 1407.6, 4222.6, 57.9, 88, 47.4, 167, 0, false));
            planets.Add(new Planets("Venus", 4.87, 12.104, 5243, 8.9, -5832, 2802, 108.2, 224.7, 34, 464, 0, false));
            planets.Add(new Planets("Earth", 5.97, 12.756, 5514, 9.8, 23.9, 24, 149.6, 365.2, 29.8, 15, 1, false));
            planets.Add(new Planets("Mars", 0.642, 6792, 3933, 3.7, 24.6, 24.7, 227.9, 687, 24.1, -65, 2, false));
            planets.Add(new Planets("Jupiter", 1898, 142.984, 1326, 23.1, 9.9, 9.9, 778.6, 4331, 13.1, -110, 67, true));
            planets.Add(new Planets("Saturn", 568, 120.536, 687, 9, 10.7, 10.7, 1433.5, 10.747, 9.7, 140, 62, true));
            planets.Add(new Planets("Uranus", 86.6, 51.118, 1271, 8.7, -17.2, 17.2, 2872.5, 30.859, 6.8, -195, 27, true));
            planets.Add(new Planets("Neptun", 102, 49.582, 1638, 11, 16.1, 16.1, 4495.1, 59.8, 5.4, -200, 14, true));
            planets.Add(new Planets("Pluto", 0.0146, 2370, 2095, 0.7, -153.3, 153.3, 5906.4, 90.56, 4.7, -225, 5, true));

            foreach (Planets planet in planets)
            {
                Console.WriteLine(planet.ToString());
            }
        }
    }
}