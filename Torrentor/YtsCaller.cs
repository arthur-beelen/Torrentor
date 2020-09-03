using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Torrentor
{
    //Uses Yts API to get a torrent ready to download
    class YtsCaller
    {
        //Search a movie with the following title
        public void search(string imdbID)
        {
            string api = "https://yts.mx/api/v2/list_movies.json?query_term=" + imdbID;
            string json;

            using (var webClient = new System.Net.WebClient())
            {
                json = webClient.DownloadString(api);

            }
            /*
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            JObject jObject = JObject.Load(reader);
            string jsonData = jObject.GetValue("data").Value<String>();
            */
            string[] jsonLookUp = { "data", "movies" };
            json = browseJson(json, jsonLookUp);

            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                    Console.WriteLine("Token: {0}, Value: {1}", reader.TokenType, reader.Value);
                }
                else
                {
                    Console.WriteLine("Token: {0}", reader.TokenType);
                }
            }

            //JArray jArray = JArray.Parse(json);

            json = getJsonObjectFromArray(json);
            Console.WriteLine(json);



        }

        //If the object is within an array in the JSON, this will remove the array brackets
        private string getJsonObjectFromArray(string json)
        {
            int startJson = json.IndexOf("{");
            json = json.Remove(0, startJson);
            int endJson = json.LastIndexOf("}") + 1;
            return json.Remove(endJson, json.Length - endJson);
        }

        private string browseJson(string json, string [] jsonLookUp)
        {
            for(int i = 0; i < jsonLookUp.Length; i++)
                json = getJsonValue(json, jsonLookUp[i]);
            return json;
        }

        //Useful to quickly retrieve 
        private string getJsonValue(string json, string valueName)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            JObject jObject = JObject.Load(reader);
            return jObject.GetValue(valueName).ToString();
        }
    }
}
