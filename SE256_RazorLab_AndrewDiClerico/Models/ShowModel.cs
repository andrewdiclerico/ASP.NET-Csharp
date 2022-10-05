using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SE256_RazorLab_AndrewDiClerico.Models
{
    public class ShowModel
    {
        [Required]
        public int Show_ID { get; set; }

        
        public String User_Name { get; set; }

        [Required(ErrorMessage = "Please enter a Title"), StringLength(50)]
        public String Show_Title { get; set; }

        [Required(ErrorMessage = "Please enter a Director"), StringLength(40)]
        public String Show_Director { get; set; }

        [Required(ErrorMessage = "Please enter the number of Seasons")]
        public int Show_Seasons { get; set; }

        [Required(ErrorMessage = "Please enter the number of Episodes")]
        public int Show_Episodes { get; set; }


        public double Show_Rating { get; set; }


        public String Show_Opinion { get; set; }


        [Required(ErrorMessage = "Please enter your Email"), EmailAddress]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public String Show_Email { get; set; }

        [Required]
        public bool Show_Watched { get; set; }

        public DateTime Show_DateWatched { get; set; }

        public String Feedback { get; set; }


    }
}
