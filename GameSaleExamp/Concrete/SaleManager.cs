using GameSaleProject.Abstract;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void Sale(User user, Game game, Campaign campaign)
        {
            Console.WriteLine(user.FirstName+" "+user.LastName+" adlı kullanıcıya, "+game.GameName+" adlı oyunun, "+campaign.CampaignName+" kampanyası ile birlikte satışı gerçekleştirilmiştir.");
        }
    }
}
