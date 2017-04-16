using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingRace_CodeFirst.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public int EventID { get; set; }
        
        public virtual Event Event { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual Staff Staff { get; set; }
    }
}