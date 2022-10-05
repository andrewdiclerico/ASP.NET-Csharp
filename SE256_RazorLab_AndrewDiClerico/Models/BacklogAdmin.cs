using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using SE256_RazorLab_AndrewDiClerico.Models;

using System.Data;
using System.Data.SqlClient;

using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace SE256_RazorLab_AndrewDiClerico.Models
{
    public class BacklogAdmin
    {

        [Required]
        public int BLAdmin_ID { get; set; }

        [EmailAddress]
        [Display(Name = "Username")]
        public String BLAdmin_Email { get; set; }

        [Required, StringLength(25)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String BLAdmin_PW { get; set; }

        public String Feedback { get; set; }

    }
}
