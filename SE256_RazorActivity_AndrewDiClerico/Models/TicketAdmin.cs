using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using SE256_RazorActivity_AndrewDiClerico.Models;

using System.Data;
using System.Data.SqlClient;

using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;

namespace SE256_RazorActivity_AndrewDiClerico.Models
{
    public class TicketAdmin
    {

        [Required]
        public int TicketAdmin_ID { get; set; }

        [EmailAddress]
        [Display(Name = "Username")]
        public String TicketAdmin_Email { get; set; }

        [Required, StringLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public String TicketAdmin_PW { get; set; }

        public String Feedback { get; set; }



    }
}
