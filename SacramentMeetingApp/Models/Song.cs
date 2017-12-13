using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingApp.Models
{
    public class Song
    {
        public int songID { get; set; }
        public int songNumber { get; set; }
        public string songName { get; set; }

        public Meeting Meeting { get; set; }
    }
}
