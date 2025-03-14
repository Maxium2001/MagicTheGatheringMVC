using Microsoft.AspNetCore.Mvc;
using MagicTheGatheringMVC.Models;
using MagicTheGatheringApi.Services;
using System.Diagnostics;
using MagicTheGatheringMVC.ViewModel;

namespace MagicTheGatheringMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly MagicServices _magicServices;

        public HomeController()
        {
            _magicServices = new MagicServices();
        }

        public async Task<IActionResult> Index()
        {
            var resp = await _magicServices.GetSet();
            var sets = new IndexViewModel();
            sets.sets = new List<string>();
            foreach (var set in resp.sets)
            {   
                sets.sets.Add(set.name);
            }
            return View(sets);
        }

        public async Task<IActionResult> Cards(string name, string manaCost, string colors, string set, string page)
        {
            var res = await _magicServices.GetCards(name, manaCost, colors, set);
            var imageDefault = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fbacks.scryfall.io%2Flarge%2F5%2F9%2F597b79b3-7d77-4261-871a-60dd17403388.jpg%3F1665006177&f=1&nofb=1&ipt=d9212d13492520d8b62a832c4bc7916946bb8ed11a7b004bfbfc9327cc84edac&ipo=images";
            var cards = new CardsViewModel();
            cards.cards = new List<CardModel>();
            foreach (var card in res.cards)
            {
                var cardModel = new CardModel
                {
                    name = card.name,
                    manaCost = card.manaCost,
                    cmc = card.cmc,
                    colors = card.colors,
                    setName = card.setName,
                    imageUrl = string.IsNullOrEmpty(card.imageUrl) ? imageDefault : card.imageUrl,
                    id = card.id
                };
                cards.cards.Add(cardModel);
            }

            return View(cards);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
