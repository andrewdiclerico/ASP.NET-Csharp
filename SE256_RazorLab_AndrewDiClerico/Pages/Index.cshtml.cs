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
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public String FName { get; set; }

        private readonly IConfiguration _configuration;

        MovieDataAccessLayer factory;

        ShowDataAccessLayer fact;

        public List<MovieModel> mov { get; set; }

        public List<ShowModel> shw { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;

            factory = new MovieDataAccessLayer(_configuration);

            fact = new ShowDataAccessLayer(_configuration);
        }

        public void OnGet()
        {
            mov = factory.GetActiveMovies().ToList();

            shw = fact.GetActiveShows().ToList();
        }
    }
}
