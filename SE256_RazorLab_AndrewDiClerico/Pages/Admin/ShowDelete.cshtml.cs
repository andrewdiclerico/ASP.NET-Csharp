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
    public class ShowDeleteModel : PageModel
    {
        ShowDataAccessLayer factory;

        public ShowModel show { get; set; }

        private readonly IConfiguration _configuration;

        public ShowDeleteModel(IConfiguration configuration)
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

            show = factory.GetOneRecord(id);

            if (show == null)
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

            factory.DeleteShow(id);

            return RedirectToPage("/Admin/BL_ControlPanel");
        }

    }
}
