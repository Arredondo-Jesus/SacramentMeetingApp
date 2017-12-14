using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingApp.Models
{
    public class Meeting
    {
        public int meetingID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime meetingDate { get; set; }
        public string ward { get; set; }

        public ICollection<Member> members { get; set; }
        public ICollection<Song> songs { get; set; }
    }
}
