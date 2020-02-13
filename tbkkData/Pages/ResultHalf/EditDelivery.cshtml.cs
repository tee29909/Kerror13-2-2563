using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.ResultHalf
{
    public class EditDeliveryModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public EditDeliveryModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Delivery_performance Delivery_performance { get; set; }
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

            Delivery_performance = await _context.Delivery_performance
                .Include(d => d.Employee).FirstOrDefaultAsync(m => m.Delivery_performanceID == id);

            if (Delivery_performance == null)
            {
                return NotFound();
            }
           ViewData["EmployeeID"] = new SelectList(_context.Employee, "EmployeeID", "FirstName");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Delivery_performance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Delivery_performanceExists(Delivery_performance.Delivery_performanceID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Deliverys");
        }

        private bool Delivery_performanceExists(int id)
        {
            return _context.Delivery_performance.Any(e => e.Delivery_performanceID == id);
        }
    }
}
