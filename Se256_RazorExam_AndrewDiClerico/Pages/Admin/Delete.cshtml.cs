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
    public class DeleteModel : PageModel
    {
        PlotModelDataAccessLayer factory;

        public PlotModel tPlot { get; set; }

        private readonly IConfiguration _configuration;

        public DeleteModel(IConfiguration configuration)
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

            tPlot = factory.GetOneRecord(id);

            if (tPlot == null)
            {
                return NotFound();
            }

            return Page();

        }

        public ActionResult OnPost(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            factory.DeletePlot(id);

            return RedirectToPage("/Admin/ControlPanel");
        }

    }
}
