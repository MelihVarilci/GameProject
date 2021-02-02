using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;

namespace GameProject.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Save to db : " + gamer.FirstName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Update to db : " + gamer.FirstName);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Delete to db : " + gamer.FirstName);
        }
    }
}