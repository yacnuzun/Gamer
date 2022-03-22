using System;

namespace Gamer
{
    public class GamersManager:BaseGamersManager
    {
        IGamerCheckService _gamerCheckService;

        public GamersManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public override void Add(Gamers gamers)
        {
            if (_gamerCheckService.CheckIfRealPlayer(gamers))
            {
                base.Add(gamers);
            }
            else
            {
                Console.WriteLine("This is not Player");
            }
        }
    }
    public class GamesManager : BaseGamersManager
    {
        IGamerCheckService _gamerCheckService;

        public override void Add(Gamers gamers)
        {
            
        }
    }
    public class CampaignManager : BaseGamersManager
    {
        public override void Add(Gamers gamers)
        {
            
        }
    }
}
