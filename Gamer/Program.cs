using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamersManager gamersManager = new GameManager();
            Console.Read();
        }
    }
    public class Gamers:IEntity
    {
        public int PlayerId { get; set; }
        public int IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }

    }
    class Games:IEntity
    {

    } 
    interface IGamerManager
    {
        void Add(Gamers gamers);
        void Update(Gamers gamers);
    }
    class BaseGamersManager : IGamerManager
    {
        public virtual void Add(Gamers gamers)
        {
            Console.WriteLine("Player's Added"+gamers.FirstName);
        }

        public void Update(Gamers gamers)
        {
            throw new NotImplementedException();
        }
    }
    interface IGamerCheckService
    {
        bool CheckIfRealPlayer(Gamers gamers);
    }
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPlayer(Gamers gamers)
        {
            return true;
        }
    }
    interface IEntity
    {

    }
    class GamesManager:BaseGamersManager
    {
        IGamerCheckService _gamerCheckService;

        public GamesManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public GamesManager()
        {
        }
        public override void Add(Gamers gamers)
        {
            if (_gamerCheckService.CheckIfRealPlayer(gamers))
            {
                base.Add(gamers);
            }
            else
            {
                Console.WriteLine("This is a Player");
            }
        }
    }
}
