using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Bolleyballer
{
    public class Database
    {
        internal static string key = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJhcGlfa2V5IjoiOWMzNzMzNWQtMmQ3Yy00ZGJlLWFkMjUtZmRkYjE4MGRkMzg0IiwidGVuYW50X2lkIjo1MDIsImp0aV9rZXkiOiI5ZGI3NjcwMi1kNTkxLTExZWMtYmM1Yy0wYWMxNWY0NGM5MTUifQ.O8oNoJlWzdTEk0It7knfVw5I8alk0Rc5Gfi5xoatFKw";
        internal static string id = "436";
        internal static string url = "https://scoretracker.fireapis.com/bolleyballer/";

        public static async void AwardWin(string[] players)
        {
            // get all player data
            Dictionary<object, object> _db = await RetrieveDatabase();
            Newtonsoft.Json.Linq.JArray _data = (Newtonsoft.Json.Linq.JArray)_db["data"];
            List<object> db = _data.ToObject<List<object>>();

            // pair player names with ID and score
            Dictionary<string, Tuple<int, string>> data = new Dictionary<string, Tuple<int, string>>();
            foreach (Newtonsoft.Json.Linq.JObject _player in db)
            {
                Dictionary<string, object> player = _player.ToObject<Dictionary<string, object>>();
                if (players.Contains(player["name"]))
                {
                    Tuple<int, string> tuple = new Tuple<int, string>(int.Parse(player["id"].ToString()), (string)player["score"]);
                    data.Add((string)player["name"], tuple);
                }
            }

            // update each winning player
            foreach (string player in players)
            {
                var playerdata = data[player];
                int player_id = playerdata.Item1;
                int score = int.Parse(playerdata.Item2);

                IEnumerable<KeyValuePair<string, string>> reqdata = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("name", player),
                    new KeyValuePair<string, string>("score", (score + 1).ToString())
                };

                UpdatePlayer(reqdata, player_id);
            }
        }

        public static async void UpdateExistingPlayers(string[] players)
        {
            // get player db in dictionary form
            Dictionary<object, object> db = await RetrieveDatabase();

            /* add all non-existing players to the dictionary */

            Newtonsoft.Json.Linq.JArray _data = (Newtonsoft.Json.Linq.JArray)db["data"];
            List<object>data = _data.ToObject<List<object>>(); 
            
            string[] names = new string[data.Count];
            for (int i = 0; i < data.Count; i++)
            {
                Newtonsoft.Json.Linq.JObject _player = (Newtonsoft.Json.Linq.JObject)data[i];
                Dictionary<string, object> player = _player.ToObject<Dictionary<string, object>>();
                names[i] = (string)player["name"];
            }

            List<IEnumerable<KeyValuePair<string, string>>> newplayers = new List<IEnumerable<KeyValuePair<string, string>>>();
            foreach (string player in players)
            {
                if (!names.Contains(player))
                {
                    IEnumerable<KeyValuePair<string, string>> newplayer = new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string, string>("name", player),
                        new KeyValuePair<string, string>("score", "0")
                    };

                    newplayers.Add(newplayer);
                }
            }

            // update the db
            foreach (IEnumerable<KeyValuePair<string, string>> player in newplayers)
                UpdateDatabase(player);
        }

        internal static async Task<Dictionary<object, object>> RetrieveDatabase()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-ID", id);
                client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", key);

                using (HttpResponseMessage response = await client.GetAsync(url + "all"))
                {
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    using (HttpContent responseContent = response.Content)
                    {
                        string content = await responseContent.ReadAsStringAsync();
                        Dictionary<object, object> db = JsonConvert.DeserializeObject<Dictionary<object, object>>(content);
                        return db;
                    }
                }
            }
        }

        private static async void UpdateDatabase(IEnumerable<KeyValuePair<string, string>> player)
        {
            HttpContent body = new FormUrlEncodedContent(player);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-ID", id);
                client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", key);

                using (HttpResponseMessage response = await client.PostAsync(url, body))
                {
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                }
            }
        }

        private static async void UpdatePlayer(IEnumerable<KeyValuePair<string, string>> player, int player_id)
        {
            HttpContent body = new FormUrlEncodedContent(player);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-API-ID", id);
                client.DefaultRequestHeaders.Add("X-CLIENT-TOKEN", key);

                using (HttpResponseMessage response = await client.PutAsync(url + player_id, body))
                {
                    response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                    using (HttpContent content = response.Content)
                    {
                        string response_content = await content.ReadAsStringAsync();
                    }
                }
            }
        }
    }
}
