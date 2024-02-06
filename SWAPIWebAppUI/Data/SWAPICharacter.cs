using System;
namespace SWAPIWebAppUI.Data
{
	public class SWAPICharacter : ISWAPIData
	{
        // variables - getters/setters

        /// <summary>
        /// The name of the star wars character.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The height of the star wars character.
        /// </summary>
        public long? Height { get; set; }

        /// <summary>
        /// The mass of the star wars character.
        /// </summary>
        public long? Mass { get; set; }

        /// <summary>
        /// The Hair color of the star wars character.
        /// </summary>
        public string? HairColor { get; set; }

        /// <summary>
        /// The skin color of the star wars character.
        /// </summary>
        public string? SkinColor { get; set; }

        /// <summary>
        /// The Eye color of the star wars character.
        /// </summary>
        public string? EyeColor { get; set; }

        /// <summary>
        /// The year of birth of the star wars character.
        /// </summary>
        public string? BirthYear { get; set; }

        /// <summary>
        /// The gender of the star wars character.
        /// </summary>
        public string? Gender { get; set; }

        /// <summary>
        /// The home world planet of the star wars character.
        /// </summary>
        public string? HomeWorld { get; set; }      // refactor to Planet type

        /// <summary>
        /// The films this star wars character has appeared in.
        /// </summary>
        public List<string>? Films { get; set; }    // refactor to type SWAPIFilm

        /// <summary>
        /// The species of the star wars character.
        /// </summary>
        public List<string>? Species { get; set; }  // Refactor to Species type

        /// <summary>
        /// The vehicles this star wars character has driven.
        /// </summary>
        public List<string>? Vehicles { get; set; } // Refactor to Vehicle type      

        /// <summary>
        /// The starships this star wars character pilots/boards.
        /// </summary>
        public List<string>? StarShips { get; set; } // Refactor to Starship type 

        /// <summary>
        /// Date of creation of this star wars character data entry.
        /// </summary>
        public DateTime? Created { get; set; }     // refactored to DateTime as per json sample data

        // <summary>
        /// Last Date of editing this star wars character data entry.
        /// </summary>
        public DateTime? Edited { get; set; }      // refactored to DateTime as per json sample data

        // <summary>
        /// SWAPI url of this star wars character data entry.
        /// </summary>
        public string? Url { get; set; }


        // constructors

        /// <summary>
        /// generic constructor
        /// </summary>
        public SWAPICharacter()
        {
        }

        /// <summary>
        /// constructor with full parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="height"></param>
        /// <param name="mass"></param>
        /// <param name="hairColor"></param>
        /// <param name="skinColor"></param>
        /// <param name="eyeColor"></param>
        /// <param name="birthYear"></param>
        /// <param name="gender"></param>
        /// <param name="homeWorld"></param>
        /// <param name="films"></param>
        /// <param name="species"></param>
        /// <param name="vehicles"></param>
        /// <param name="starShips"></param>
        /// <param name="created"></param>
        /// <param name="edited"></param>
        /// <param name="url"></param>
        public SWAPICharacter(string? name, long? height, long? mass, string? hairColor, string? skinColor, string? eyeColor, string? birthYear, string? gender, string? homeWorld, List<string>? films, List<string>? species, List<string>? vehicles, List<string>? starShips, DateTime? created, DateTime? edited, string? url)
        {
            Name = name;
            Height = height;
            Mass = mass;
            HairColor = hairColor;
            SkinColor = skinColor;
            EyeColor = eyeColor;
            BirthYear = birthYear;
            Gender = gender;
            HomeWorld = homeWorld;
            Films = films;
            Species = species;
            Vehicles = vehicles;
            StarShips = starShips;
            Created = created;
            Edited = edited;
            Url = url;
        }




    }
}

