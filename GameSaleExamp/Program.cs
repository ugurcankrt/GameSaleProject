using GameSaleProject.Concrete;
using GameSaleProject.Entities;
using System;

namespace GameSaleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User() { Id = 1, FirstName = "Uğurcan", LastName="KURT", TcNo="123456", DateOfBirth= new DateTime(1999,11,27)  };

            AuthManager userManager = new AuthManager();
            userManager.Add(user1);
            Campaign campaign1 = new Campaign() {Id=1, CampaignName="Kış" };
            Game game1 = new Game() {Id=1, GameName="Pubgi"  };


            SaleManager saleManager = new SaleManager();
            saleManager.Sale(user1, game1, campaign1);


        }
    }
}
