using System;
namespace SWAPIWebAppUI.Data
{
	public class SWAPIStarShip : ISWAPIData
	{
        // variables - getters/setters

        /// <summary>
        /// The name of the star wars starship.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The model of the star wars starship.
        /// </summary>
        public string? Model { get; set; }

        /// <summary>
        /// The Manufacturer of the star wars starship.
        /// </summary>
        public string? Manufacturer { get; set; }

        /// <summary>
        ///  The cost in republic/imperial credits of the star wars starship.
        /// </summary>
        public string? CostInCredits { get; set; }

        /// <summary>
        /// The length of the star wars starship.
        /// </summary>
        public long? Length { get; set; }

        /// <summary>
        /// The Max atmosphering speed of the star wars starship.
        /// </summary>
        public int? MaxAtmospheringSpeed { get; set; }

        /// <summary>
        /// The crew size of the star wars starship.
        /// </summary>
        public int? Crew { get; set; }

        /// <summary>
        /// The max number of passengers for the star wars starship.
        /// </summary>
        public int? Passengers { get; set; }

        /// <summary>
        /// The cargo capacity of the star wars starship
        /// </summary>
        public long? CargoCapacity { get; set; }

        /// <summary>
        /// The duration of consumables of the star wars starship.
        /// </summary>
        public string? Consumables { get; set; }

        /// <summary>
        /// The hyper drive rating of the star wars starship.
        /// </summary>
        public decimal? HyperdriveRating { get; set; }

        /// <summary>
        /// The MGLT of the star wars starship.
        /// </summary>
        public int? MGLT { get; set; }

        /// <summary>
        /// The cclass of the star wars starship.
        /// </summary>
        public string? StarshipClass { get; set; }

        /// <summary>
        /// The Pilots who have flown the star wars starship.
        /// </summary>
        public List<string>? Pilots { get; set; } // refactor to type SWAPICharacter

        /// <summary>
        /// The Films the star wars starship has appeared in.
        /// </summary>
        public List<string>? Films { get; set; }  // refactor to type SWAPIFilm

        /// <summary>
        /// Date of creation of this star wars starship.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Last Date of editing this star wars starship.
        /// </summary>
        public DateTime? Edited { get; set; }

        /// <summary>
        /// SWAPI url of this star wars starship.
        /// </summary>
        public string? Url { get; set; }


        // constructors

        /// <summary>
        /// generic constructor
        /// </summary>
        public SWAPIStarShip()
		{
		}

        /// <summary>
        /// constructor with full parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="model"></param>
        /// <param name="manufacturer"></param>
        /// <param name="costInCredits"></param>
        /// <param name="length"></param>
        /// <param name="maxAtmospheringSpeed"></param>
        /// <param name="crew"></param>
        /// <param name="passengers"></param>
        /// <param name="cargoCapacity"></param>
        /// <param name="consumables"></param>
        /// <param name="hyperdriveRating"></param>
        /// <param name="mGLT"></param>
        /// <param name="starshipClass"></param>
        /// <param name="pilots"></param>
        /// <param name="films"></param>
        /// <param name="created"></param>
        /// <param name="edited"></param>
        /// <param name="url"></param>
        public SWAPIStarShip(string? name, string? model, string? manufacturer, string? costInCredits, long? length, int? maxAtmospheringSpeed, int? crew, int? passengers, long? cargoCapacity, string? consumables, decimal? hyperdriveRating, int? mGLT, string? starshipClass, List<string>? pilots, List<string>? films, DateTime? created, DateTime? edited, string? url)
        {
            Name = name;
            Model = model;
            Manufacturer = manufacturer;
            CostInCredits = costInCredits;
            Length = length;
            MaxAtmospheringSpeed = maxAtmospheringSpeed;
            Crew = crew;
            Passengers = passengers;
            CargoCapacity = cargoCapacity;
            Consumables = consumables;
            HyperdriveRating = hyperdriveRating;
            MGLT = mGLT;
            StarshipClass = starshipClass;
            Pilots = pilots;
            Films = films;
            Created = created;
            Edited = edited;
            Url = url;
        }

    }
}

