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
    public class DeleteDeliveryModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteDeliveryModel(tbkkData.Models.tbkkDataContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Delivery_performance = await _context.Delivery_performance.FindAsync(id);

            if (Delivery_performance != null)
            {
                _context.Delivery_performance.Remove(Delivery_performance);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Deliverys");
        }
    }
}
