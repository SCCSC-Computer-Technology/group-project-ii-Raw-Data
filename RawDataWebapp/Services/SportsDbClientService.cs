using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json; 

namespace RawDataWebapp.Services
{
    public class SportsDbClient
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private const string BaseUrl = "https://www.thesportsdb.com/api/v1/json/3"; // Using test API key "3"

        public SportsDbClient()
        {
            _httpClient.BaseAddress = new Uri(BaseUrl);
        }

        public async Task<List<Player>> SearchPlayersByNameAsync(string playerName)
        {
            string url = $"{BaseUrl}/searchplayers.php?p={Uri.EscapeDataString(playerName)}";
            var jsonResponse = await _httpClient.GetStringAsync(url);

            if (!string.IsNullOrEmpty(jsonResponse))
            {
                var playersResponse = JsonConvert.DeserializeObject<PlayersResponse>(jsonResponse);
                return playersResponse?.player ?? new List<Player>();
            }
            else
            {
                throw new HttpRequestException("Failed to fetch data: No response received.");
            }
        }

        public class Player
        {
            public string strPlayer { get; set; }
            public string strTeam { get; set; }
            public string strPosition { get; set; }
        }

        public class PlayersResponse
        {
            public List<Player> player { get; set; }
        }
    }
}
