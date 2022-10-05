using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Se256_RazorExam_AndrewDiClerico.Models;


namespace Se256_RazorExam_AndrewDiClerico.Pages
{
    public class IndexModel : PageModel
    {
        
        private readonly IConfiguration _configuration;

        PlotModelDataAccessLayer factory;

        public List<PlotModel> recs { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;

            factory = new PlotModelDataAccessLayer(_configuration);
        }

        public void OnGet()
        {
            recs = factory.GetActiveRecords().ToList();
        }
    }
}
