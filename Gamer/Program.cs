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
    class Games
    {

    } 
    interface IGamerManager
    {
        void Add(Gamers gamers);
    }
    class BaseGamersManager : IGamerManager
    {
        public void Add(Gamers gamers)
        {
            Console.WriteLine("Player's Added"+gamers.FirstName);
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
}
