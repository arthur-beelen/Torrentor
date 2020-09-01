using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torrentor
{
    class ApiCaller
    {
        private string apiKey = "fcc3c567";
        public Dictionary<string, string> result = new Dictionary<string, string>();
        private string[] properties = { "Title", "Year", "Released", "Runtime", "Genre", "Director", "Writer", "Actors", "Plot", "Language", "Country", "Awards", "Poster", "Metascore", "imdbRating", "imdbVotes", "imdbID", "Type", "DVD", "BoxOffice", "Production" };

        public void search(string query)
        {
            string api = "http://www.omdbapi.com/?apikey=" + apiKey + "&t=" + query.Replace(' ', '+');
            string json;

            using (var webClient = new System.Net.WebClient())
            {
                json = webClient.DownloadString(api);
                // Now parse with JSON.Net
            }
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            JObject jObject = JObject.Load(reader);

            result = new Dictionary<string, string>();
            try
            {
                //string title = jObject.GetValue("Title").Value<String>();
                //searchTitle.Text = title;

                foreach (string property in properties)
                {
                    string value = jObject.GetValue(property).Value<String>();
                    result.Add(property, value);
                }
            }
            catch (ArgumentNullException p)
            {
                Console.WriteLine(p.ToString());
            }
            
        }
    }
}
