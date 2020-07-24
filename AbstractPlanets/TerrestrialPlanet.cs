using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPlanets
{
    /// <summary>
    /// This class inherited from abstract class Planet.
    /// It has the own private member _oxygen which
    /// determine this planet has oxygen or not.
    /// This class also implement IHabitable and IHasMoons
    /// interfaces.
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE MEMBER
        private bool _oxygen;

        /// <summary>
        /// Class constructor, taking values as parameter
        /// and passed to base class constructor by calling it
        /// also, initialize private member _oxygen.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        /// <summary>
        /// Implement the method of IHabitable interface
        /// to return it has oxygen or not.
        /// </summary>
        /// <returns>true/false</returns>
        public bool Habitable()
        {
            return _oxygen;
        }

        /// <summary>
        /// Implement the method of IHasMoons interface
        /// to return it has any moon(s) or not.
        /// </summary>
        /// <returns>true/false</returns>
        public bool HasMoons()
        {
            return (MoonCount > 0);
        }
    }
}