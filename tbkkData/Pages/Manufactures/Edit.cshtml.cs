using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData
{
    public class EditModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public EditModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Manufacture Manufacture { get; set; }
        public Employee Employee1 { get; set; }

        public IList<Employee> Employees { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
             .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Manufacture = await _context.Manufacture
                //.Include(m => m.Company)
                .Include(m => m.Employee)
                .Include(m => m.Product).FirstOrDefaultAsync(m => m.ManufactureID == id);

            if (Manufacture == null)
            {
                return NotFound();
            }
          
           ViewData["EmployeeID"] = new SelectList(_context.Employee, "EmployeeID", "FirstName");
           ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Manufacture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManufactureExists(Manufacture.ManufactureID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./List");
        }

        private bool ManufactureExists(int id)
        {
            return _context.Manufacture.Any(e => e.ManufactureID == id);
        }
    }
}
