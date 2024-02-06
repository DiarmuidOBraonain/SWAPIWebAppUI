using System.Collections.Generic;
using Newtonsoft.Json;
using SWAPIWebAppUI.Data;

namespace SWAPIWebAppUI.Services
{
    public class SWAPIService
	{
        //variables

        /// <summary>
        /// HttpClient instance to make HTTP requests
        /// </summary>
        private readonly HttpClient httpClient;


        // constructor

        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpClient"></param>
        public SWAPIService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        // Methods

        
        /// <summary>
        /// returns a list of Star wars characters from SWAPI
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<List<SWAPICharacter>> GetSWAPICharacters()
        {
            try
            {
                var resp = await httpClient.GetStringAsync("https://swapi.dev/api/people/");
                var characters = JsonConvert.DeserializeObject<List<SWAPICharacter>>(resp);

                if (characters == null)
                {
                    throw new Exception("Failed to deserialize SWAPI characters json.");
                }
                return characters;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"HTTP Request Error: {ex.Message}");
                throw;
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"JSON Deserialization Error: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// internal instance of GetJsonConvert from Newtonsoft.Json
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        internal object GetJsonConvert()
        {
            throw new NotImplementedException();
        }
    }
}

