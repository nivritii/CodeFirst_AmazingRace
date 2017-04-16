using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingRace_CodeFirst.Models
{
    public class PitStop
    {
        public int PitStopID { get; set; }
        public int EventID { get; set; }
        public string StopName { get; set; }
        public int StopOrder { get; set; }
        public String Location { get; set; }
        public int StaffID { get; set; }

        public virtual Event Event { get; set; }
        public virtual Staff Staff { get; set; }
    }
}