using System;
namespace SWAPIWebAppUI.Data
{
	public interface ISWAPIData
	{
        // variables - getters/setters

        /// <summary>
        /// Date of creation of this star wars data entry.
        /// </summary>
        public DateTime? Created { get; set; }

        // <summary>
        /// Last Date of editing this star wars data entry.
        /// </summary>
        public DateTime? Edited { get; set; }

        // <summary>
        /// SWAPI url of this star wars data entry.
        /// </summary>
        public string? Url { get; set; }
    }
}

