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
            gamersManager.Add(new Gamers { DateOfBirth = new DateTime(1996,1,2), FirstName = "Yalçın", LastName = "Uzun", IdentificationNumber = "19622660911" });
            Console.Read();
        }
    }
}
