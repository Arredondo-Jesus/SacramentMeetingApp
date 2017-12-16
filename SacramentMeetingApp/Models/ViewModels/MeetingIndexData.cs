using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingApp.Models.ViewModels
{
    public class MeetingIndexData
    {
        public IEnumerable<Member> Members { get; set; }
        public IEnumerable<Song> Songs { get; set; }
        public IEnumerable<Meeting> Meetings { get; set; }
    }
}
