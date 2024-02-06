using System;
namespace SWAPIWebAppUI.Data
{
	public class SWAPIVehicle : ISWAPIData
	{
        /// <summary>
        /// The name of the star wars vehicle.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The model of the star wars vehicle.
        /// </summary>
        public string? Model { get; set; }

        /// <summary>
        /// The Manufacturer of the star wars vehicle.
        /// </summary>
        public string? Manufacturer { get; set; }

        /// <summary>
        /// The cost in republic/imperial credits of the star wars vehicle.
        /// </summary>
        public long? CostInCredits { get; set; }

        /// <summary>
        /// The length of the star wars vehicle.
        /// </summary>
        public decimal? Length { get; set; }

        /// <summary>
        /// The Max atmosphering speed of the star wars vehicle.
        /// </summary>
        public int? MaxAtmospheringSpeed { get; set; }

        /// <summary>
        /// The crew size of the star wars vehicle.
        /// </summary>
        public int? Crew { get; set; }

        /// <summary>
        /// The max number of passengers for the star wars vehicle.
        /// </summary>
        public int? Passengers { get; set; }

        /// <summary>
        /// The cargo capacity of the star wars vehicle.
        /// </summary>
        public long? CargoCapacity { get; set; }

        /// <summary>
        /// The duration of consumables of the star wars vehicle.
        /// </summary>
        public string? Consumables { get; set; }

        /// <summary>
        /// The class of the star wars vehicle.
        /// </summary>
        public string? VehicleClass { get; set; }

        /// <summary>
        /// The Pilots who have driven the star wars vehicle.
        /// </summary>
        public List<string>? Pilots { get; set; } // refactor to type SWAPICharacter

        /// <summary>
        /// The Films the star wars vehicle has appeared in.
        /// </summary>
        public List<string>? Films { get; set; }  // refactor to type SWAPIFilm

        /// <summary>
        /// Date of creation of this star wars vehicle.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Last Date of editing this star wars vehicle.
        /// </summary>
        public DateTime? Edited { get; set; }

        /// <summary>
        /// SWAPI url of this star wars vehicle.
        /// </summary>
        public string? Url { get; set; }


        /// <summary>
        /// generic constructor
        /// </summary>
        public SWAPIVehicle()
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
        /// <param name="vehicleClass"></param>
        /// <param name="pilots"></param>
        /// <param name="films"></param>
        /// <param name="created"></param>
        /// <param name="edited"></param>
        /// <param name="url"></param>
        public SWAPIVehicle(string? name, string? model, string? manufacturer, long? costInCredits, decimal? length, int? maxAtmospheringSpeed, int? crew, int? passengers, long? cargoCapacity, string? consumables, string? vehicleClass, List<string>? pilots, List<string>? films, DateTime? created, DateTime? edited, string? url)
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
            VehicleClass = vehicleClass;
            Pilots = pilots;
            Films = films;
            Created = created;
            Edited = edited;
            Url = url;
        }
    }
}

