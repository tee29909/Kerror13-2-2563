using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.ResultHalf
{
    public class DeleteSafetysModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteSafetysModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Safety Safety { get; set; }
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

            Safety = await _context.Safety.FirstOrDefaultAsync(m => m.SafetyID == id);

            if (Safety == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Safety = await _context.Safety.FindAsync(id);

            if (Safety != null)
            {
                _context.Safety.Remove(Safety);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Safetys");
        }
    }
}
