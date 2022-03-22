using Gamer.Entities.Abstract;
using System;

namespace Gamer
{
    public class Gamers:IEntity
    {
        public int PlayerId { get; set; }
        public string IdentificationNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
