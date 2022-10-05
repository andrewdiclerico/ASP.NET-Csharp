﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

using Se256_RazorExam_AndrewDiClerico.Models;

using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;


namespace Se256_RazorExam_AndrewDiClerico.Models
{
    public class AdminLogin
    {
        [Required]
        public int Admin_ID { get; set; }

        [Required(ErrorMessage = "Please enter your Email"), EmailAddress]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        [Display(Name = "Username")]
        public String Admin_Email { get; set; }
        
        [Required, StringLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String Admin_PW { get; set; }

        public String Feedback { get; set; }



    }
}
