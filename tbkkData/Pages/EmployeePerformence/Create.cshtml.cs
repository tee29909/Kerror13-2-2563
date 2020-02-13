using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.EmployeePerformence
{
    public class CreateModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public CreateModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Employee Employee { get; set; }
   
        public IList<Employee> Employees { get; set; }
        [BindProperty]
        public Employee Employee1 { get; set; }
        public async Task OnGetAsync()
        {
           
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);
            Employees = await _context.Employee.Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            // ViewData["AgeGroupID"] = new SelectList(_context.AgeGroup, "AgeGroupID", "Age");
            ViewData["CompanyID"] = new SelectList(_context.Company, "CompanyID", "CompanyName");
            ViewData["DepartmentID"] = new SelectList(_context.Department, "DepartmentID", "DepartmentName");
            ViewData["EmployeeTypeID"] = new SelectList(_context.EmployeeType, "EmployeeTypeID", "EmployeeTypeName");
            //ViewData["GenderID"] = new SelectList(_context.Set<Gender>(), "GenderID", "SEX");
            ViewData["PositionID"] = new SelectList(_context.Position, "PositionID", "PositionName");

            
        }

        

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employee.Add(Employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}