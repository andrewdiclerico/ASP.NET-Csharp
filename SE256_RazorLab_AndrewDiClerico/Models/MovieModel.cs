using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace SE256_RazorLab_AndrewDiClerico.Models
{
    public class MovieModel
    {
        [Required]
        public int Movie_ID { get; set; }

        
        public String User_Name { get; set; }

        [Required(ErrorMessage = "Please enter a Title"), StringLength(50)]
        public String Movie_Title { get; set; }

        [Required(ErrorMessage = "Please enter a Director"), StringLength(40)]
        public String Movie_Director { get; set; }

        [Required(ErrorMessage = "Please enter the Length")]
        public int Movie_Length { get; set; }


        public double Movie_Rating { get; set; }


        public String Movie_Opinion { get; set; }

    
        [Required(ErrorMessage = "Please enter your Email"), EmailAddress]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public String Movie_Email { get; set; }


        [Required]
        public bool Movie_Watched { get; set; }


        public DateTime Movie_DateWatched { get; set; }

        public String Feedback { get; set; }


    }
}
