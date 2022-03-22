using Gamer.Bussines.Abstract;
using Gamer.Entities.Abstract;
using System;

namespace Gamer
{
    public class BaseGamersManager : IBaseManager
    {
        public virtual void Add(IEntity entity)
        {
            Console.WriteLine(" Added");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Deleted!"); ;
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Updated!"); 
        }
    }
}
