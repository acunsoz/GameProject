using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IOrderServices
    {
        void Sell(Gamer gamer, Game game);
    }
}
