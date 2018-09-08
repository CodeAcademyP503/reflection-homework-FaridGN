using Cardsystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardsystem.Core
{
   public class InMemoryDatabase : Database
    {
       
        public InMemoryDatabase()
        {
            Cards = new InMemoryDBset<Card>();
            Users = new InMemoryDBset<AppUser>();
            Incidents = new InMemoryDBset<Incident>();
        }

        public override void Dispose()
        {
           //empty
        }
    }
}
