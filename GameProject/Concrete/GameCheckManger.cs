using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;


namespace GameProject.Concrete
{
    public class GameCheckManger : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(
                        Convert.ToInt64(gamer.NationalityId),
                        gamer.FirstName.ToUpper(),
                        gamer.LastName.ToUpper(),
                        gamer.DateOfBirth.Year
                    )
                )
            ).Result.Body.TCKimlikNoDogrulaResult;
            
        }
    }
}