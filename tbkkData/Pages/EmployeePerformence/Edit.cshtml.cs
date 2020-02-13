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
    public class EditModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public EditModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employee Employee { get; set; }
        [BindProperty]
        public Employee Employee1 { get; set; }
        [BindProperty]
        public IList<Employee> Employees { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee = await _context.Employee
                            //.Include(e => e.AgeGroup)
                            .Include(e => e.Company)
                            .Include(e => e.Department)
                            .Include(e => e.EmployeeType)
                            //.Include(e => e.Gender)
                            .Include(e => e.Position).FirstOrDefaultAsync(m => m.EmployeeID == id);


            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();


            
            if (Employee == null)
            {
                return NotFound();
            }
            //ViewData["AgeGroupID"] = new SelectList(_context.AgeGroup, "AgeGroupID", "Age");
            ViewData["CompanyID"] = new SelectList(_context.Company, "CompanyID", "CompanyName");
            ViewData["DepartmentID"] = new SelectList(_context.Department, "DepartmentID", "DepartmentName");
            ViewData["EmployeeTypeID"] = new SelectList(_context.EmployeeType, "EmployeeTypeID", "EmployeeTypeName");
            //ViewData["GenderID"] = new SelectList(_context.Set<Gender>(), "GenderID", "SEX");
            ViewData["PositionID"] = new SelectList(_context.Position, "PositionID", "PositionName");
            ViewData["CompanyID"] = new SelectList(_context.Company, "CompanyID", "Category");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(Employee.EmployeeID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeID == id);
        }
    }
}
