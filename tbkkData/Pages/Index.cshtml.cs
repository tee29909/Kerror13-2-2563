using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using tbkkData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace tbkkData.Pages
{
    public class IndexModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public IndexModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public Login Login { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {

            string Username = Request.Form["Username"];
            string Password = Request.Form["Password"];
            Debug.WriteLine(Username);
            if (Username == string.Empty && Password == string.Empty)
            {
                return Page();

            }


            Login = await _context.Login.Include(e => e.Employee)
                .FirstOrDefaultAsync(u => u.Username.Equals(Username));

            if (Login == null)
            {
                return Page();
            }
            if (!Login.Password.Equals(Password))
            {
                return Page();
            }
            //ViewData["Login_EmployeeID"] = new SelectList(_context.Set<Employee>(), "EmployeeID", "EmployeeID");
            Debug.WriteLine(Login.EmployeeID);


            HttpContext.Session.SetLogin(Login.Employee);
            return RedirectToPage("./Home/Home", new { id = Login.Employee.EmployeeID });

        }
    }
}
