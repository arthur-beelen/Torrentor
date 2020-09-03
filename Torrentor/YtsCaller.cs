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
        public void search(string title)
        {
            string api = "https://yts.mx/api/v2/list_movies.json?query_term=" + title.Replace(" ", "+");
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
            string[] jsonLookUp = { "data", "movies", "0" };
            json = browseJson(json, jsonLookUp);
         



            

        }

        private string browseJson(string json, string [] jsonLookUp)
        {
            for(int i = 0; i < jsonLookUp.Length; i++)
                json = getJsonValue(json, jsonLookUp[i]);
            return json;
        }

        //USeful to quickly retrieve 
        private string getJsonValue(string json, string valueName)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            JObject jObject = JObject.Load(reader);
            return jObject.GetValue(valueName).Value<String>();
        }
    }
}
