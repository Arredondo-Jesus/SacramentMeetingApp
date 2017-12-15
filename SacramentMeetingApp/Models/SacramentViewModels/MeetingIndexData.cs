using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingApp.Models.SacramentViewModels
{
    public class MeetingIndexData
    {
        public IEnumerable<Song> Songs { get; set; }
        public IEnumerable<Member> Members { get; set; }
    }
}
