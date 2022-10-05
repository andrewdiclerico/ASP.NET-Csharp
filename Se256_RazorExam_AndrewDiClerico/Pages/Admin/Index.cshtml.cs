using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;

using Se256_RazorExam_AndrewDiClerico.Models;

namespace Se256_RazorExam_AndrewDiClerico.Pages.Admin
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public AdminLogin tAdmin { get; set; }

        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult OnPost()
        {
            IActionResult temp;

            List<AdminLogin> lstAdmin = new List<AdminLogin>();

            if (ModelState.IsValid == false)
            {
                temp = Page();
            }
            else
            {
                if (tAdmin != null)
                {
                    AdminLoginDataAccessLayer factory = new AdminLoginDataAccessLayer(_configuration);

                    lstAdmin = factory.GetAdminLogin(tAdmin).ToList();

                    if (lstAdmin.Count > 0)
                    {
                        HttpContext.Session.SetInt32("Admin_ID", lstAdmin[0].Admin_ID);
                        HttpContext.Session.SetString("Admin_Email", lstAdmin[0].Admin_Email);

                        temp = Redirect("/Admin/ControlPanel");

                    }
                    else
                    {
                        tAdmin.Feedback = "Login Failed";

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
