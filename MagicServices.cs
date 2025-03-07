using MagicTheGatheringMVC.Models;
using System.Text.Json;

namespace MagicTheGatheringMVC
{
    public class MagicServices
    {
        private readonly HttpClient client = new HttpClient();

        private readonly string baseUrl = "https://api.magicthegathering.io/v1/cards";
    }
}