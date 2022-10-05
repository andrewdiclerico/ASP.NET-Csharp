using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

using Se256_RazorExam_AndrewDiClerico.Models;

namespace Se256_RazorExam_AndrewDiClerico.Pages
{
    public class AddPlotModel : PageModel
    {
        [BindProperty]
        public PlotModel tPlot { get; set; }

        private readonly IConfiguration _configuration;

        public AddPlotModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public void OnGet()
        {
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
                if (tPlot is null == false)
                {
                    PlotModelDataAccessLayer factory = new PlotModelDataAccessLayer(_configuration);

                    factory.Create(tPlot);
                }
                temp = RedirectToPage("/Index");
            }

            return temp;


        }
    }
}
