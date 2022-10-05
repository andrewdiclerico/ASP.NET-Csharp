using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SE256_RazorLab_AndrewDiClerico.Models;
using Microsoft.Extensions.Configuration;

namespace SE256_RazorLab_AndrewDiClerico.Pages
{
    public class AddMovieModel : PageModel
    {
        [BindProperty]
        public MovieModel tMovie { get; set; }

        private readonly IConfiguration _configuration;

        public AddMovieModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {

            //

        }

        public IActionResult OnPost()
        {
            IActionResult temp;

            if (ModelState.IsValid == false)
            {
                temp = Page();
            }
            else
            {
                if (tMovie is null == false)
                {
                    MovieDataAccessLayer factory = new MovieDataAccessLayer(_configuration);

                    factory.Create(tMovie);

                    Response.Redirect("Index");
                }

                temp = Page();
            }

            return temp;
        }
    }
}
