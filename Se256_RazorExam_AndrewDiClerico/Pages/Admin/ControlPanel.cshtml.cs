using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

using Se256_RazorExam_AndrewDiClerico.Models;

using Microsoft.Extensions.Configuration;

namespace Se256_RazorExam_AndrewDiClerico.Pages.Admin
{
    public class ControlPanelModel : PageModel
    {
        private readonly IConfiguration _configuration;

        PlotModelDataAccessLayer factory;

        public List<PlotModel> recs { get; set; }

        public ControlPanelModel(IConfiguration configuration)
        {
            _configuration = configuration;

            factory = new PlotModelDataAccessLayer(_configuration);
        }

        public IActionResult OnGet()
        {
            IActionResult temp;

            if (HttpContext.Session.GetString("Admin_Email") is null)
            {
                temp = RedirectToPage("/Admin/Index");
            }
            else
            {
                recs = factory.GetActiveRecords().ToList();

                temp = Page();
            }

            return temp;

        }
    }
}
