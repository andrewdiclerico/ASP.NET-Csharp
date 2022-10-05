using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SE256_RazorActivity_AndrewDiClerico.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_RazorActivity_AndrewDiClerico.Pages
{
    public class IndexModel : PageModel
    {
        

        [BindProperty(SupportsGet = true)]
        public String FName { get; set; }

        private readonly IConfiguration _configuration;

        TroubleTicketDataAccessLayer factory;

        public List<TroubleTicketModel> tix { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;

            factory = new TroubleTicketDataAccessLayer(_configuration);
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(FName))
            {
                FName = "You!"; //default value
            }

            tix = factory.GetActiveRecords().ToList();
        }
    }
}
