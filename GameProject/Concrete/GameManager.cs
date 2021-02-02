using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GameManager : BaseGameManager
    {
        public override void Purchase(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " purchase " + game.GameName);
        }
    }
}