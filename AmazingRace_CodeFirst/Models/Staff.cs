using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingRace_CodeFirst.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public Boolean TeamStaff { get; set; }

        public virtual ICollection<PitStop> PitStops { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}