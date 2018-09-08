using Cardsystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Cardsystem.Models
{ 

   public class Incident:Entity
    {
        public DateTime OpenDate { get; set; }
        public DateTime? AcceptedDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
        public AppUser Operator { get; set; }
        public int OperatorId { get; set; }
        public string TeamViewerLogin { get; set; }
        public int TeamViewerPassword { get; set; }
        public string Description { get; set; }
        public string SolvedDescription { get; set; }
        public string Invoice { get; set; }
    }
}