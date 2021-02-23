using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderServices
    {
        public void Sell(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName+" kullanıcımız "+game.GameName+" oyununu gule gule kullanın");
        }
    }
}
