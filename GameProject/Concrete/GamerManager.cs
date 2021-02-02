using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }

        public override void Update(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Update(gamer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }

        public override void Delete(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                base.Delete(gamer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }
    }
}