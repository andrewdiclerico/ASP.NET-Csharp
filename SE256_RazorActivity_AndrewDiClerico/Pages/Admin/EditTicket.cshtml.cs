using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SE256_RazorActivity_AndrewDiClerico.Models;

using Microsoft.Extensions.Configuration;

namespace SE256_RazorActivity_AndrewDiClerico.Pages.Admin
{
    public class EditTicketModel : PageModel
    {
        private readonly IConfiguration _configuration;

        [BindProperty]
        public TroubleTicketModel tTicket { get; set; }

        public TroubleTicketDataAccessLayer factory;

        public EditTicketModel(IConfiguration configuration)
        {
            _configuration = configuration;

            factory = new TroubleTicketDataAccessLayer(_configuration);
        }

        public ActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                tTicket = factory.GetOneRecord(id);
            }

            if (tTicket == null)
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

            factory.UpdateTicket(tTicket);

            return RedirectToPage("/Admin/ControlPanel");
        }

    }
}
