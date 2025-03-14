using System.ServiceModel;
using MagicTheGatheringApi.Models;

namespace MagicTheGatheringApi.Services
{
    [ServiceContract]
    public interface IMagicServices
    {
        [OperationContract]
        Task<CardsModel?> GetCards(string name, string manaCost, string colors, string set);
    }
}
