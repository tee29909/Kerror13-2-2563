using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.EmployeePerformence
{
    public class DetailsModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DetailsModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();


            Employee = await _context.Employee
                //.Include(e => e.AgeGroup)
                .Include(e => e.Company)
                .Include(e => e.Department)
                .Include(e => e.EmployeeType)
                .Include(e => e.Company)
                .Include(e => e.Position).FirstOrDefaultAsync(m => m.EmployeeID == id);

            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
