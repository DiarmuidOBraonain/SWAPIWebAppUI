using System;
namespace SWAPIWebAppUI.Data
{
    public class SWAPISpecies
    {
        /// <summary>
        /// The name of the star wars species.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The classification of the star wars species.
        /// </summary>
        public string? Classification { get; set; }

        /// <summary>
        /// The designation of the star wars species.
        /// </summary>
        public string? Designation { get; set; }

        /// <summary>
        /// The average height of the star wars species.
        /// </summary>
        public int? AverageHeight { get; set; }

        /// <summary>
        /// The skin colors of the star wars species.
        /// </summary>
        public string? SkinColors { get; set; }

        /// <summary>
        /// The hair colors of the star wars species.
        /// </summary>
        public string? HairColors { get; set; }

        /// <summary>
        /// The Eye colors of the star wars species.
        /// </summary>
        public string? EyeColors { get; set; }

        /// <summary>
        /// The average lifespan of the star wars species.
        /// </summary>
        public int? AverageLifespan { get; set; }

        /// <summary>
        /// The Home world planet of the star wars species.
        /// </summary>
        public string? Homeworld { get; set; }    // possibly refactor to SWAPIPlanet

        /// <summary>
        /// The spoken language of the star wars species.
        /// </summary>
        public string? Language { get; set; }

        /// <summary>
        /// The characters that belong to this star wars species.
        /// </summary>
        public List<string>? People { get; set; } // refactor to type List<SWAPICharacter>

        /// <summary>
        /// The Films the star wars species has appeared in.
        /// </summary>
        public List<string>? Films { get; set; }  // refactor to type List<SWAPIFilm>

        /// <summary>
        /// Date of creation of this star wars species.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Last date of editing this star wars species.
        /// </summary>
        public DateTime? Edited { get; set; }

        /// <summary>
        /// SWAPI url of this star wars species.
        /// </summary>
        public string? Url { get; set; }


        // constructors

        /// <summary>
        /// generic constructor
        /// </summary>
        public SWAPISpecies()
		{
		}

        /// <summary>
        /// constructor with full parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="classification"></param>
        /// <param name="designation"></param>
        /// <param name="averageHeight"></param>
        /// <param name="skinColors"></param>
        /// <param name="hairColors"></param>
        /// <param name="eyeColors"></param>
        /// <param name="averageLifespan"></param>
        /// <param name="homeworld"></param>
        /// <param name="language"></param>
        /// <param name="people"></param>
        /// <param name="films"></param>
        /// <param name="created"></param>
        /// <param name="edited"></param>
        /// <param name="url"></param>
        public SWAPISpecies(string? name, string? classification, string? designation, int? averageHeight, string? skinColors, string? hairColors, string? eyeColors, int? averageLifespan, string? homeworld, string? language, List<string>? people, List<string>? films, DateTime? created, DateTime? edited, string? url)
        {
            Name = name;
            Classification = classification;
            Designation = designation;
            AverageHeight = averageHeight;
            SkinColors = skinColors;
            HairColors = hairColors;
            EyeColors = eyeColors;
            AverageLifespan = averageLifespan;
            Homeworld = homeworld;
            Language = language;
            People = people;
            Films = films;
            Created = created;
            Edited = edited;
            Url = url;
        }
    }
}

