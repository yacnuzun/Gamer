using Gamer.Entities;

namespace Gamer
{
    public interface ICampaignManager
    {
        void Add(Campaigns campaigns);
        void Update(Campaigns campaigns);
        void Delete(Campaigns campaigns);
    }
}
