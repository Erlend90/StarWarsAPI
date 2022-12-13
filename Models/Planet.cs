using System;
using Newtonsoft.Json;

namespace StarWarsAPI.Models
{
	public class Planet
	{
		public int id { get; set; }
		public string? name { get; set; }
        public int population { get; set; }
        public string?[] residents { get; set; }
        public string?[] films { get; set; }

        public Planet(string? name, int population, string?[] residents, string?[] films)
        {
            this.name = name;
            this.population = population;
            this.residents = residents;
            this.films = films;
        }

        public async Task<object> planetByID(int id)
        {
            string? url = $"https://swapi.dev/api/planets/{id}";

            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<Planet>(response);

            //examine results for planetByID and get information from resident and film from their models
            //for each the array of films/residents and compile results, append to data and encode to json

            return data;
        }
    }
}

