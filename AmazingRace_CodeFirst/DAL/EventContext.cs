using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AmazingRace_CodeFirst.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace AmazingRace_CodeFirst.DAL
{
    public class EventContext: DbContext
    {
        public EventContext() : base("EventContext")
        {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<PitStop> PitStops { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}