using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LadyDriver_web.Pages
{
    public class step1Model : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var email = Request.Form["email"];
            var phoneNumber = Request.Form["phoneNumber"];
            var driverType = Request.Form["driverType"];
            var fullName = Request.Form["fullName"];
            // do something with emailAddress

            return new RedirectToPageResult("/step2");
        }

    }

}
