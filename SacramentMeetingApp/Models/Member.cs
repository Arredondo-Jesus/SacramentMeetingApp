using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingApp.Models
{
    public class Member
    {
        public int memberID { get; set; }
        public string memberName { get; set; }
        public string memberLastName { get; set; }
        public string assignment { get; set; }
        public bool isBishopBrickMember { get; set; }
        public string speakerSubject { get; set; }

        public Meeting Meeting { get; set; }
    }
}
