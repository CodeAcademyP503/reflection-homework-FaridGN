using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardsystem.Models
{
    public class Card:Entity
    {
        public int Number { get; set; }
        public decimal Balance { get; set; }
        public bool Isused { get; set; }
        public DateTime? ActivatedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public CurrencyType CurrencyType { get; set; }
        public AppUser ActivatedBy { get; set; }
        public int ActivatedById { get; set; }

        public override bool Equals(object obj)
        {
            Card card = obj as Card;
            if(card.Number == this.Number)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
