using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SE256_RazorLab_AndrewDiClerico.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_RazorLab_AndrewDiClerico.Pages.Admin
{
    public class MovieDeleteModel : PageModel
    {
        MovieDataAccessLayer factory;

        public MovieModel movie { get; set; }

        private readonly IConfiguration _configuration;

        public MovieDeleteModel(IConfiguration configuration)
        {
            _configuration = configuration;

            factory = new MovieDataAccessLayer(_configuration);
        }

        public ActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            movie = factory.GetOneRecord(id);

            if (movie == null)
            {
                return NotFound();
            }

            return Page();
        }

        public ActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            factory.DeleteMovie(id);

            return RedirectToPage("/Admin/BL_ControlPanel");
        }

        
    }
}
