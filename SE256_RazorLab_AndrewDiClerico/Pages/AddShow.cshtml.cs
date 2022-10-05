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
    public class AddShowModel : PageModel
    {
        [BindProperty]
        public ShowModel tShow { get; set; }

        private readonly IConfiguration _congifuration;

        public AddShowModel(IConfiguration configuration)
        {
            _congifuration = configuration;
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
                if (tShow is null == false)
                {
                    ShowDataAccessLayer factory = new ShowDataAccessLayer(_congifuration);

                    factory.Create(tShow);

                    Response.Redirect("Index");
                }

                temp = Page();
            }

            return temp;
        }
    }
}
