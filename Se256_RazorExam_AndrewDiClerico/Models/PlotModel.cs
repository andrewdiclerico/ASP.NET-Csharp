using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Se256_RazorExam_AndrewDiClerico.Models
{
    public class PlotModel
    {
        [Required]
        public int PlotID { get; set; }

        [Required]
        public int PlotNumber { get; set; }

        [Required(ErrorMessage = "Please Enter First Name"), StringLength(75)]
        public String FirstName { get; set; }

        [StringLength(75)]
        public String MiddleName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name"), StringLength(75)]
        public String LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Date Of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please Enter Date Of Death")]
        [DataType(DataType.Date)]
        public DateTime DOD { get; set; }

        [Required(ErrorMessage = "Please Enter Stone Condtion")]
        public Double StoneCondition { get; set; }

        [Required(ErrorMessage = "Please Enter Plot Condition")]
        public Double PlotCondition { get; set; }

        
        public bool NeedsAttention { get; set; }

        [Required(ErrorMessage = "Please enter your Email"), EmailAddress]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public String RevEmail { get; set; }

        [Required(ErrorMessage = "Please Enter Date Last Reviewed")]
        [DataType(DataType.Date)]
        public DateTime DOLastRev { get; set; }

        public String Feedback { get; set; }



    }
}
