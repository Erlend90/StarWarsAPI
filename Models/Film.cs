using System;
using Newtonsoft.Json;

namespace StarWarsAPI.Models
{
	public class Film
	{
		public int id { get; set; }
		public string? director { get; set; }
		public string? title { get; set; }

        public Film(string? director, string? title)
        {
            this.director = director;
            this.title = title;
        }

        public async Task<object> filmByID(int id)
        {
            string? url = $"https://swapi.dev/api/films/{id}";

            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<Planet>(response);

            return data;

        }
    }
}

