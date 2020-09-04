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
        public Dictionary<string, string> result;

        //Search a movie with the following title
        public int search(string imdbID)
        {
            result = new Dictionary<string, string>();
            string api = "https://yts.mx/api/v2/list_movies.json?query_term=" + imdbID;
            string json;

            using (var webClient = new System.Net.WebClient())
            {
                json = webClient.DownloadString(api);

            }
            if (json.Contains("movies"))
            {
                string[] jsonLookUp = { "data", "movies" };
                json = browseJson(json, jsonLookUp);

                //JArray jArray = JArray.Parse(json);

                //Pick the only movie at index 0
                json = getJsonObjectFromArray(json);
                Console.WriteLine(json);

                string[] torrentJsonObjects = getJsonObjectsFromArray(getJsonValue(json, "torrents"));

                checkTorrentJsonObjects(torrentJsonObjects);
                

                return 0;
            }
            return -1;
        }

        //Fill the result dictionary with the urls as values with the corresponding quality as key
        private void checkTorrentJsonObjects(string[] torrentJsonObjects)
        {
            for (int i = 0; i < torrentJsonObjects.Length; i++)
            {
                Console.WriteLine(torrentJsonObjects[i]);
                result.Add(getJsonValue(torrentJsonObjects[i], "quality"), getJsonValue(torrentJsonObjects[i], "url"));
            }
        }

        private string getJsonObjectFromArray(string json)
        {
            //Remove the '[' and ']' brackets
            int startJson = json.IndexOf("{");
            json = json.Remove(0, startJson);
            int endJson = json.LastIndexOf("}") + 1;
            return json.Remove(endJson, json.Length - endJson);
        }

        //Take an object out of an array (in json)
        private string[] getJsonObjectsFromArray(string json)
        {
            //Remove the '[' and ']' brackets
            int startJson = json.IndexOf("{");
            json = json.Remove(0, startJson);
            int endJson = json.LastIndexOf("}") + 1;
            json = json.Remove(endJson, json.Length - endJson);

            string[] separator = { "}," };
            string[] jsonObjects = json.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int size = jsonObjects.Length;
            if (size > 1)
            {
                for (int i = 0; i < size; i++)
                {
                    if(i != size - 1)
                        jsonObjects[i] = String.Concat(jsonObjects[i], "}");
                }
            }
            Console.WriteLine(jsonObjects[0]);
            return jsonObjects;
        }

        //Browse the JSON by subsequently taking the values from the keys in the array jsonLookUp
        private string browseJson(string json, string [] jsonLookUp)
        {
            for(int i = 0; i < jsonLookUp.Length; i++)
                json = getJsonValue(json, jsonLookUp[i]);
            return json;
        }

        //Useful to quickly retrieve a value in a JSON object
        private string getJsonValue(string json, string valueName)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            JObject jObject = JObject.Load(reader);
            return jObject.GetValue(valueName).ToString();
        }
    }
}
