using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SE256_RazorLab_AndrewDiClerico.Models;

using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

namespace SE256_RazorLab_AndrewDiClerico.Pages.Admin
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public BacklogAdmin bAdmin { get; set; }

        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            //
        }

        public IActionResult OnPost()
        {
            IActionResult temp;

            List<BacklogAdmin> lstBacklogAdmin = new List<BacklogAdmin>();

            if (ModelState.IsValid == false)
            {
                temp = Page();
            }
            else
            {
                if (bAdmin != null)
                {
                    BacklogAdminDataAccessLayer factory = new BacklogAdminDataAccessLayer(_configuration);

                    lstBacklogAdmin = factory.getAdminLogin(bAdmin).ToList();

                    if (lstBacklogAdmin.Count > 0)
                    {
                        HttpContext.Session.SetInt32("BLAdmin_ID", lstBacklogAdmin[0].BLAdmin_ID);
                        HttpContext.Session.SetString("BLAdmin_Email", lstBacklogAdmin[0].BLAdmin_Email);

                        temp = Redirect("/Admin/BL_ControlPanel");
                    }
                    else
                    {
                        bAdmin.Feedback = "Incorrect Login Credentials";

                        temp = Page();
                    }

                }
                else
                {
                    temp = Page();
                }

            }

            return temp;
        }

    }
}
