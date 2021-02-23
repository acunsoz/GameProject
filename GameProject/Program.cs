using GameProject.Concrete;
using GameProject.Abstract;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamer1 = new GamerManager(new UserValidateManager());
            OrderManager order1 = new OrderManager();

            //kullanıcı ekleme
            gamer1.Add(new Entities.Gamer
            {
                TcNo = "12345",
                FirstName = "ALIHAN",
                LastName = "ACUNSOZ",
                DateOfBirth = 1998
            });

            //oyun satın alma
            order1.Sell(new Entities.Gamer
            {
                TcNo = "12345",
                FirstName = "ALIHAN",
                LastName = "ACUNSOZ",
                DateOfBirth = 1998
            }, (new Entities.Game
            {
                Id = 1,
                GameName = " Rust ",
                Producer = "KK Gaming"
            }));


            //Oyuna gelen kampanya
            CampaignManager campaign = new CampaignManager();
            campaign.Add(new Entities.Game
            {
                Id = 1,
                GameName = "Rust",
                Producer = "KK Gaming"
            });


        }
    }
}
