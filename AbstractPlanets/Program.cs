using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPlanets
{
    /// <summary>
    /// This driver class create GiantPlanet and
    /// TerrestrialPlanet object by calling constructor
    /// and display detail info by calling ToString()
    /// method.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Prompt user to press any key to exit
        /// the program.
        /// </summary>
        static void waitForAnyKey()
        {
            Console.Write("\nPlease press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Create and display object details of GiantPlanet
        /// and TerrestrialPlanet.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create and display GiantPlanet object
            GiantPlanet giantPlanet = 
                new GiantPlanet("Jupiter", 139820.0, 1898000000000000000000000000.0, "Gas");
            Console.WriteLine("Giant Planet:");
            Console.WriteLine(giantPlanet.ToString());

            // Create and display TerrestrialPlanet object
            TerrestrialPlanet terrestrialPlanet = 
                new TerrestrialPlanet("Earth", 12742.0, 5972000000000000000000000.0, true);
            Console.WriteLine("\nTerrestrial Planet:");
            Console.WriteLine(terrestrialPlanet.ToString());

            // Call waitForAnyKey() method
            waitForAnyKey();
        }
    }
}
