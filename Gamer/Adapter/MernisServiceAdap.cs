using Gamer.Service;
using System;

namespace Gamer
{
    public class MernisServiceAdap : IGamerCheckService
    {
        public bool CheckIfRealPlayer(Gamers gamers)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamers.IdentificationNumber),
                gamers.FirstName.ToUpper(),
                gamers.LastName.ToUpper(),
                gamers.DateOfBirth.Year);
        }
    }
}
