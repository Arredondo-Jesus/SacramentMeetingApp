using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingApp.Models
{
    public class Speaker
    {
        public int speakerID { get; set; }
        public string speakerName { get; set; }
        public string speakerLastName { get; set; }
        public string speakerSubject { get; set; }

        public Meeting Meeting { get; set; }
    }
}
