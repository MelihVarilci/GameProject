using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public class BaseGameManager : IGameService
    {
        public virtual void Purchase(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " purchase game : " + game.GameName);
        }

    }
}