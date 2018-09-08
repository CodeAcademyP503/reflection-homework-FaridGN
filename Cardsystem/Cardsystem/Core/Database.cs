using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardsystem.Models;

namespace Cardsystem.Core
{
   
    public abstract class Database: IDisposable
    {
        public InMemoryDBset<Card> Cards { get; protected set; }
        public InMemoryDBset<AppUser> Users { get; protected set; }
       public InMemoryDBset<Incident> Incidents { get; protected set; }


        public abstract void Dispose();
    }
}
