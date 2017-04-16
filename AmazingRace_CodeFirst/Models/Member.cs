using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazingRace_CodeFirst.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public int TeamID { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }

        public virtual Team Team { get; set; }
    }
}