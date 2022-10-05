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
    public class EditMovieModel : PageModel
    {
        private readonly IConfiguration _configuration;

        [BindProperty]
        public MovieModel tMovie { get; set; }

        public MovieDataAccessLayer factory;

        public EditMovieModel(IConfiguration configuration)
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
            else
            {
                tMovie = factory.GetOneRecord(id);
            }

            if (tMovie == null)
            {
                return NotFound();
            }

            return Page();
        }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            factory.UpdateMovie(tMovie);

            return RedirectToPage("/Admin/BL_ControlPanel");
        }

    }
}
