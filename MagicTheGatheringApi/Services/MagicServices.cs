using MagicTheGatheringApi.Models;
using System.Text.Json;

namespace MagicTheGatheringApi.Services
{
    public class MagicServices : IMagicServices
    {
        private readonly HttpClient client = new HttpClient();
        private readonly string baseUrl = "https://api.magicthegathering.io/v1/cards?";
        private readonly string setUrl = "https://api.magicthegathering.io/v1/sets";


        public async Task<CardsModel?> GetCards(string name, string manaCost, string colors, string set)
        {
            var requestUrl = baseUrl;
            if (!string.IsNullOrWhiteSpace(name))
            {
                requestUrl += $"&name={name}";
            }
            if (!string.IsNullOrWhiteSpace(manaCost))
            {
                requestUrl += $"&cmc={manaCost}";
            }
            if (!string.IsNullOrWhiteSpace(colors))
            {
                requestUrl += $"&colors={colors}";
            }
            if (!string.IsNullOrWhiteSpace(set))
            {
                requestUrl += $"&setName={set}";
            }

            HttpResponseMessage response = await client.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var cards = JsonSerializer.Deserialize<CardsModel>(responseString);
            return cards;
        }

        public async Task<SetsModel?> GetSet()
        {
            HttpResponseMessage response = await client.GetAsync(setUrl);
            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();
            var sets = JsonSerializer.Deserialize<SetsModel>(responseString);
            return sets;
        }
    }
}
