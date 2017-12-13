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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime meetingID { get; set; }
        public string ward { get; set; }
        public string meetingLeader { get; set; }
        public string songLeader { get; set; }

        public ICollection<Speaker> speakers { get; set; }
        public ICollection<Song> songs { get; set; }
    }
}
