using System;
namespace SWAPIWebAppUI.Data
{
	public class SWAPIPlanet : ISWAPIData
    {
        // variables - getters/setters

        /// <summary>
        /// The name of the star wars Planet.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The Rotation Period of the star wars Planet.
        /// </summary>
        public long? RotationPeriod { get; set; }

        /// <summary>
        /// The Orbital Period of the star wars Planet.
        /// </summary>
        public long? OrbitalPeriod { get; set; }

        /// <summary>
        /// The Diameter of the star wars Planet.
        /// </summary>
        public long? Diameter { get; set; }

        /// <summary>
        /// The Climate of the star wars Planet.
        /// </summary>
        public string? Climate { get; set; }

        /// <summary>
        /// The Gravity of the star wars Planet.
        /// </summary>
        public string? Gravity { get; set; }

        /// <summary>
        /// The types of Terrain of the star wars Planet.
        /// </summary>
        public string? Terrain { get; set; }

        /// <summary>
        /// The Surface water coverage of the star wars Planet.
        /// </summary>
        public int? SurfaceWater { get; set; }

        /// <summary>
        /// The Population size of the star wars Planet.
        /// </summary>
        public long? Population { get; set; }

        /// <summary>
        /// The Residents of the star wars Planet.
        /// </summary>
        public List<string>? Residents { get; set; }    // refactor to type SWAPICharacter

        /// <summary>
        /// The Films this star wars Planet has appeared in.
        /// </summary>
        public List<string>? Films { get; set; }        // refactor to type films

        /// <summary>
        /// Date of creation of this star wars Planet.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Last Date of editing this star wars data entry.
        /// </summary>
        public DateTime? Edited { get; set; }

        /// <summary>
        /// SWAPI url of this star wars character data entry.
        /// </summary>
        public string? Url { get; set; }


        // constructors

        /// <summary>
        /// generic constructor
        /// </summary>
        public SWAPIPlanet()
		{
		}

        /// <summary>
        /// constructor with full parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rotationPeriod"></param>
        /// <param name="orbitalPeriod"></param>
        /// <param name="diameter"></param>
        /// <param name="climate"></param>
        /// <param name="gravity"></param>
        /// <param name="terrain"></param>
        /// <param name="surfaceWater"></param>
        /// <param name="population"></param>
        /// <param name="residents"></param>
        /// <param name="films"></param>
        /// <param name="created"></param>
        /// <param name="edited"></param>
        /// <param name="url"></param>
        public SWAPIPlanet(string? name, long? rotationPeriod, long? orbitalPeriod, long? diameter, string? climate, string? gravity, string? terrain, int? surfaceWater, long? population, List<string>? residents, List<string>? films, DateTime? created, DateTime? edited, string? url)
        {
            Name = name;
            RotationPeriod = rotationPeriod;
            OrbitalPeriod = orbitalPeriod;
            Diameter = diameter;
            Climate = climate;
            Gravity = gravity;
            Terrain = terrain;
            SurfaceWater = surfaceWater;
            Population = population;
            Residents = residents;
            Films = films;
            Created = created;
            Edited = edited;
            Url = url;
        }
    }
}

