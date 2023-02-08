using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planterne
{
    public class Planets
    {
        private string _name;
        private double _mass;
        private double _diameter;
        private double _density;
        private double _gravity;
        private double _rotationPeriod;
        private double _lenghtOfDays;
        private double _distanceFromSun;
        private double _orbitalPeriod;
        private double _orbitalVelocity;
        private int _meanTemperture;
        private byte _numberOfMoons;
        private bool _ringSystem;

        public Planets(string name, double mass, double diameter, double density, double gravity, double rotationPeriod, double lenghtOfDays, double distanceFromSun, double orbitalPeriod, double orbitalVelocity, int meanTemperture, byte numberOfMoons, bool ringSystem)
        {
            _name = name;
            _mass = mass;
            _diameter = diameter;
            _density = density;
            _gravity = gravity;
            _rotationPeriod = rotationPeriod;
            _lenghtOfDays = lenghtOfDays;
            _distanceFromSun = distanceFromSun;
            _orbitalPeriod = orbitalPeriod;
            _orbitalVelocity = orbitalVelocity;
            _meanTemperture = meanTemperture;
            _numberOfMoons = numberOfMoons;
            _ringSystem = ringSystem;
        }

        public override string ToString()
        {
            string all = _name + " " + _mass + " " + _diameter + " " + _density + " " + _gravity + " " + _rotationPeriod + " " + _lenghtOfDays + " " + _distanceFromSun + " " + _orbitalPeriod + " " + _orbitalVelocity + " " + _meanTemperture + " " + _numberOfMoons + " " + _ringSystem; 
            return all;
        }
    }
}
