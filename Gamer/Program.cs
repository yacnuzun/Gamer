using Gamer.Service;
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
            BaseGamersManager gamersManager = new GamesManager(new MernisServiceAdap());
            gamersManager.Add(new Gamers { DateOfBirth = new DateTime(1996,1,1), FirstName = "Sait", LastName = "Kayar", IdentificationNumber = "" });
            Console.Read();
        }
    }
    public class Gamers
    {
        public int PlayerId { get; set; }
        public string IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
    class Games
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

    class GamesManager:BaseGamersManager
    {
        IGamerCheckService _gamerCheckService;

        public GamesManager(IGamerCheckService gamerCheckService)
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
    class MernisServiceAdap : IGamerCheckService
    {
        public bool CheckIfRealPlayer(Gamers gamers)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamers.IdentificationNumber), gamers.FirstName.ToUpper(), gamers.LastName.ToUpper(), gamers.DateOfBirth.Year);
        }
    }
}
