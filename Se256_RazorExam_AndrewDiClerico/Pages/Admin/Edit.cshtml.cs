using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

using Se256_RazorExam_AndrewDiClerico.Models;



namespace Se256_RazorExam_AndrewDiClerico.Pages.Admin
{
    public class EditModel : PageModel
    {
        private readonly IConfiguration _configuration;

        [BindProperty]
        public PlotModel tPlot { get; set; }

        public PlotModelDataAccessLayer factory;

        public EditModel(IConfiguration configuration)
        {
            _configuration = configuration;

            factory = new PlotModelDataAccessLayer(_configuration);
        }

        public ActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                tPlot = factory.GetOneRecord(id);
            }

            if (tPlot == null)
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

            factory.UpdatePlot(tPlot);

            return RedirectToPage("/Admin/ControlPanel");
        }
    }
}
