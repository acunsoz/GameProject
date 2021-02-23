using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignServices
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" oyununda sezon sonu kampanyası var");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName+" oyunun kampanyası silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName+" kampanya guncellendi");
        }
    }
}
