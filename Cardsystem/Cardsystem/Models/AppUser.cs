using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardsystem.Models
{
   public class AppUser:Entity
    {
        public AppUser()
        {
            Incidents = new HashSet<Incident>();
            Cards = new HashSet<Card>();
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }
        public string MobileNum { get; set; }
        public ICollection<Incident> Incidents { get; set; }
        public ICollection<Card> Cards { get; set; }
        public RoleType Role { get; set; }
        public bool IsLocked { get; set; }
        public DateTime? LockedDate { get; set; }

    }
}
