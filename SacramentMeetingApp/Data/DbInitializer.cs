

using SacramentMeetingApp.Models;
using System;
using System.Linq;

namespace SacramentMeetingApp.Data
{
    internal class DbInitializer
    {
        public static void Initialize(SacramentMeetingAppContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Meetings.Any())
            {
                return;   // DB has been seeded
            }

            var meetings = new Meeting[]
            {
                new Meeting{ meetingLeader="Joseph Smith", meetingID=DateTime.Parse("2005-09-01")}
            };

            foreach (Meeting m in meetings)
            {
                context.Meetings.Add(m);
            }

            context.SaveChanges();

            var speakers = new Speaker[]
            {
                new Speaker{speakerName ="John", speakerLastName="Rogers", speakerSubject="Charity" }
            };

            foreach (Speaker sp in speakers)
            {
                context.Speakers.Add(sp);
            }
            context.SaveChanges();

            var songs = new Song[]
            {
                new Song{songName="Be still my soul", songNumber=11}
            };
            foreach (Song s in songs)
            {
                context.Songs.Add(s);
            }
            context.SaveChanges();
        }
    }
}