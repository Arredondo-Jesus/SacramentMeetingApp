using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingApp.Models
{
    public class Member
    {
        public int memberID { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime memberDate { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Display(Name = "Name")]
        public string memberName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string memberLastName { get; set; }

        [Required]
        [Display(Name = "Assignment")]
        public string assignment { get; set; }
        [Display(Name = "Member of the Bishop Brick")]
        public bool isBishopBrickMember { get; set; }

        [Required]
        [Display(Name = "Subject")]
        public string speakerSubject { get; set; }

        public Meeting Meeting { get; set; }
    }
}
