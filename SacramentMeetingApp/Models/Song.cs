using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingApp.Models
{
    public class Song
    {
        public int songID { get; set; }

        [Required]
        [Display(Name = "Hymn Number")]
        public int songNumber { get; set; }

        [Required]
        [Display(Name = "Hymn Title")]
        public string songName { get; set; }

        public Meeting Meeting { get; set; }
    }
}
