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
            IGamerManager gamersManager = new GamersManager(new MernisServiceAdap());
            gamersManager.Add(new Gamers { DateOfBirth = new DateTime(1996,1,2), FirstName = "Yalçın", LastName = "Uzun", IdentificationNumber = "19622660912" });
            Console.Read();
        }
    }
}
