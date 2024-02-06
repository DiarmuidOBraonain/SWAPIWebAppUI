using System;
namespace SWAPIWebAppUI.Data
{
    public class SWAPIFilm : ISWAPIData
    {
        // variables - getters/setters

        /// <summary>
        /// The title of the star wars film.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// The episode number of the star wars film.
        /// </summary>
        public int EpisodeId { get; set; }

        /// <summary>
        /// The opening crawl of the star wars film.
        /// </summary>
        public string? OpeningCrawl { get; set; }

        /// <summary>
        /// The name of the director of the star wars film.
        /// </summary>
        public string? Director { get; set; }

        /// <summary>
        /// The name of the director of the star wars film.
        /// </summary>
        public string? Producer { get; set; }

        /// <summary>
        /// The release date of the star wars film.
        /// </summary>
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// The characters that appear in the star wars film.
        /// </summary>
        public List<string>? Characters { get; set; } // refactor to type List<SWAPICharacter>

        /// <summary>
        /// The planets that appear in the star wars film.
        /// </summary>
        public List<string>? Planets { get; set; }    // refactor to type List<SWAPIPlanet>

        /// <summary>
        /// The starships that appear in the star wars film.
        /// </summary>
        public List<string>? Starships { get; set; }  // refactor to type List<SWAPIStarShip>

        /// <summary>
        /// The vehicles that appear in the star wars film.
        /// </summary>
        public List<string>? Vehicles { get; set; }   // refactor to type List<SWAPIVehicle>

        /// <summary>
        /// The species that appear in the star wars film.
        /// </summary>
        public List<string>? Species { get; set; }    // refactor to type List<SWAPISpecies>

        /// <summary>
        /// Date of creation of this star wars film.
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Last date of editing this star wars film.
        /// </summary>
        public DateTime? Edited { get; set; }

        /// <summary>
        /// SWAPI url of this star wars vehicle.
        /// </summary>
        public string? Url { get; set; }


        // constructors

        /// <summary>
        /// generic constructor
        /// </summary>
        public SWAPIFilm()
		{
		}

        /// <summary>
        /// constructor with full parameters
        /// </summary>
        /// <param name="title"></param>
        /// <param name="episodeId"></param>
        /// <param name="openingCrawl"></param>
        /// <param name="director"></param>
        /// <param name="producer"></param>
        /// <param name="releaseDate"></param>
        /// <param name="characters"></param>
        /// <param name="planets"></param>
        /// <param name="starships"></param>
        /// <param name="vehicles"></param>
        /// <param name="species"></param>
        /// <param name="created"></param>
        /// <param name="edited"></param>
        /// <param name="url"></param>
        public SWAPIFilm(string? title, int episodeId, string? openingCrawl, string? director, string? producer, DateTime? releaseDate, List<string>? characters, List<string>? planets, List<string>? starships, List<string>? vehicles, List<string>? species, DateTime? created, DateTime? edited, string? url)
        {
            Title = title;
            EpisodeId = episodeId;
            OpeningCrawl = openingCrawl;
            Director = director;
            Producer = producer;
            ReleaseDate = releaseDate;
            Characters = characters;
            Planets = planets;
            Starships = starships;
            Vehicles = vehicles;
            Species = species;
            Created = created;
            Edited = edited;
            Url = url;
        }
    }
}

