using System;

namespace SWAPIWebAppUI.Data
{
	public class SWAPILightSideCharacter : SWAPICharacter
    {
        // variables - getters/setters

        // Additional variables to be added here if SWAPI
        // is updated to differentiate Light and Dark Side characters

        /// <summary>
        /// generic constructor
        /// </summary>
        public SWAPILightSideCharacter()
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
        public SWAPILightSideCharacter(string? name, long? height, long? mass, string? hairColor, string? skinColor, string? eyeColor, string? birthYear, string? gender, string? homeWorld, List<string>? films, List<string>? species, List<string>? vehicles, List<string>? starShips, DateTime? created, DateTime? edited, string? url) : base(name, height, mass, hairColor, skinColor, eyeColor, birthYear, gender, homeWorld, films, species, vehicles, starShips, created, edited, url)
        {
        }



    }
}

