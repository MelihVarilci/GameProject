using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void Purchase(Game game, Gamer gamer);
    }
}