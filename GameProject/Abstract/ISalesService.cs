using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        public void Sell(Gamer gamer, Game game, Campaign campaign);
    }
}