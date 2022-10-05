using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

using SE256_RazorLab_AndrewDiClerico.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_RazorLab_AndrewDiClerico.Pages.Admin
{
    public class BL_ControlPanelModel : PageModel
    {
        private readonly IConfiguration _configuration;

        MovieDataAccessLayer factory;

        ShowDataAccessLayer fact;

        public List<MovieModel> mov { get; set; }

        public List<ShowModel> shw { get; set; }

        public BL_ControlPanelModel(IConfiguration configuration)
        {
            _configuration = configuration;

            factory = new MovieDataAccessLayer(_configuration);

            fact = new ShowDataAccessLayer(_configuration);
        }


        public IActionResult OnGet()
        {
            IActionResult temp;

            if (HttpContext.Session.GetString("BLAdmin_Email") is null)
            {
                temp = RedirectToPage("/Admin/Index");
            }
            else
            {
                mov = factory.GetActiveMovies().ToList();

                shw = fact.GetActiveShows().ToList();

                temp = Page();
            }

            return temp;
        }

    }
}
