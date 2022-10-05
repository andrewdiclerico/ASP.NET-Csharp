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
    public class EditShowModel : PageModel
    {
        private readonly IConfiguration _configuration;

        [BindProperty]
        public ShowModel tShow { get; set; }

        public ShowDataAccessLayer factory;

        public EditShowModel(IConfiguration configuration)
        {
            _configuration = configuration;

            factory = new ShowDataAccessLayer(_configuration);
        }

        public ActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                tShow = factory.GetOneRecord(id);
            }

            if (tShow == null)
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

            factory.UpdateShow(tShow);

            return RedirectToPage("/Admin/BL_ControlPanel");
        }

    }
}
