using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AmazingRace_CodeFirst.Models;

namespace AmazingRace_CodeFirst.DAL
{
    public class EventInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EventContext>
    {
        protected override void Seed(EventContext context)
        {
            var events = new List<Event>
            {
                new Event{EventName="Event1",Description="Event1Des",Country="SG",City="SG",EventStart=DateTime.Parse("2016-02-01"),EventEnd=DateTime.Parse("2016-02-01"),TotalPitStops=6,TotalTeams=5},
                new Event{EventName="Event2",Description="Event1Des",Country="SG",City="SG",EventStart=DateTime.Parse("2016-02-01"),EventEnd=DateTime.Parse("2016-02-01"),TotalPitStops=6,TotalTeams=5},
                new Event{EventName="Event3",Description="Event1Des",Country="SG",City="SG",EventStart=DateTime.Parse("2016-02-01"),EventEnd=DateTime.Parse("2016-02-01"),TotalPitStops=6,TotalTeams=5},
                new Event{EventName="Event4",Description="Event1Des",Country="SG",City="SG",EventStart=DateTime.Parse("2016-02-01"),EventEnd=DateTime.Parse("2016-02-01"),TotalPitStops=6,TotalTeams=5},
                new Event{EventName="Event5",Description="Event1Des",Country="SG",City="SG",EventStart=DateTime.Parse("2016-02-01"),EventEnd=DateTime.Parse("2016-02-01"),TotalPitStops=6,TotalTeams=5},
                new Event{EventName="Event6",Description="Event1Des",Country="SG",City="SG",EventStart=DateTime.Parse("2016-02-01"),EventEnd=DateTime.Parse("2016-02-01"),TotalPitStops=6,TotalTeams=5},
                new Event{EventName="Event7",Description="Event1Des",Country="SG",City="SG",EventStart=DateTime.Parse("2016-02-01"),EventEnd=DateTime.Parse("2016-02-01"),TotalPitStops=6,TotalTeams=5},
                new Event{EventName="Event8",Description="Event1Des",Country="SG",City="SG",EventStart=DateTime.Parse("2016-02-01"),EventEnd=DateTime.Parse("2016-02-01"),TotalPitStops=6,TotalTeams=5}
            };

            events.ForEach(s => context.Events.Add(s));
            context.SaveChanges();

            var teams = new List<Team>
            {
                new Team{TeamName="Team1", EventID=1},
                new Team{TeamName="Team2", EventID=1},
                new Team{TeamName="Team1", EventID=2},
                new Team{TeamName="Team2", EventID=2},
                new Team{TeamName="Team1", EventID=3},
            };

            teams.ForEach(s => context.Teams.Add(s));
            context.SaveChanges();

            var members = new List<Member>
            {
                new Member{MemberName="Member1",TeamID=1,ContactNo="65561314",Email="member1@email.com" },
                new Member{MemberName="Member2",TeamID=1,ContactNo="65561314",Email="member2@email.com" },
                new Member{MemberName="Member1",TeamID=2,ContactNo="65561314",Email="member1@email.com" },
                new Member{MemberName="Member2",TeamID=2,ContactNo="65561314",Email="member2@email.com" },
                new Member{MemberName="Member1",TeamID=3,ContactNo="65561314",Email="member1@email.com" },
                new Member{MemberName="Member2",TeamID=3,ContactNo="65561314",Email="member2@email.com" },
                new Member{MemberName="Member1",TeamID=4,ContactNo="65561314",Email="member1@email.com" },
                new Member{MemberName="Member2",TeamID=4,ContactNo="65561314",Email="member2@email.com" },
                new Member{MemberName="Member1",TeamID=5,ContactNo="65561314",Email="member1@email.com" },
                new Member{MemberName="Member2",TeamID=5,ContactNo="65561314",Email="member2@email.com" }
            };

            members.ForEach(s => context.Members.Add(s));
            context.SaveChanges();

            //base.Seed(context);
        }

    }
}