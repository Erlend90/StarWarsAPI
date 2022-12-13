using System;
using Newtonsoft.Json;

namespace StarWarsAPI.Models
{
	public class Resident
	{
		public long id { get; set; }
		public int birth_year { get; set; }
		public string? name { get; set; }
		public string? gender { get; set; }

        public Resident(int birth_year, string? name, string? gender)
        {
            this.name = name;
            this.birth_year = birth_year;
            this.gender = gender;
        }

        public async Task<object> characterByID(int id)
        {
            string? url = $"https://swapi.dev/api/people/{id}";

            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<Planet>(response);

            return data;

        }
    }
}

