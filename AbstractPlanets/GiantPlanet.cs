using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


/*
 Created by Shivani - 301100045 - Assignment 3 - COMP123
  This assignment is useful to build the strong understanding of classes and interfaces
 */
namespace AbstractPlanets
{
    /// <summary>
    /// This class inherited from abstract class Planet.
    /// It has the own private member _type which describe
    /// which type of Giant Planet is it (Gas or Ice).
    /// This class also implement IHasMoons and IHasRings
    /// interfaces.
    /// </summary>
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // PRIVATE MEMBER
        private string _type;

        /// <summary>
        /// Class constructor, taking values as parameter
        /// and passed to base class constructor by calling it
        /// also, initialize private member _type.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
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

        /// <summary>
        /// Implement the method of IHasRings interface
        /// to return it has any ring(s) or not.
        /// </summary>
        /// <returns>true/false</returns>
        public bool HasRings()
        {
            return (RingCount > 0);
        }
    }
}