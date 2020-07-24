using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPlanets
{
    /// <summary>
    /// This is an abstract class to hold
    /// detail information about a Planet.
    /// </summary>
    public abstract class Planet
    {
        // PRIVATE MEMBERS
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        // PUBLIC PROPERTIES
        public double Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        public double Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        public int MoonCount
        {
            get { return _moonCount; }
            set { _moonCount = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double OrbitalPeriod
        {
            get { return _orbitalPeriod; }
            set { _orbitalPeriod = value; }
        }

        public int RingCount
        {
            get { return _ringCount; }
            set { _ringCount = value; }
        }

        public double RotationPeriod
        {
            get { return _rotationPeriod; }
            set { _rotationPeriod = value; }
        }

        /// <summary>
        /// Class constructor, takes name, diameter and mass
        /// ass peremeter values and initialize member variables
        /// _name, _diameter and _mass
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        /// <summary>
        /// Override default ToString() to display Planet's 
        /// name, diameter and mass to console
        /// </summary>
        /// <returns>Formatted string as '[ name, diameter, mass ]'</returns>
        public override string ToString()
        {
            return "[ " + Name + ", " + Diameter + ", " + Mass + " ]";
        }
    }
}
