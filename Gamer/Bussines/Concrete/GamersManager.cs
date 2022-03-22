using System;

namespace Gamer
{
    public class GamersManager:IGamerManager
    {
        IGamerCheckService _gamerCheckService;

        public GamersManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamers gamers)
        {
            if (_gamerCheckService.CheckIfRealPlayer(gamers))
            {
                Console.WriteLine("add.");
            }
            else
            {
                Console.WriteLine("This is not Player");
            }
        }

        public void Delete(Gamers games)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamers games)
        {
            throw new NotImplementedException();
        }
    }
}
