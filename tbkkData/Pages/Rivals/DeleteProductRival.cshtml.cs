using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.Rivals
{
    public class DeleteProductRivalModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteProductRivalModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Rival_Product Rival_Product { get; set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rival_Product = await _context.Rival_Product
                .Include(r => r.Product)
                .Include(r => r.Rival).FirstOrDefaultAsync(m => m.RivProductID == id);
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();


            if (Rival_Product == null)
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

            Rival_Product = await _context.Rival_Product.FindAsync(id);

            if (Rival_Product != null)
            {
                _context.Rival_Product.Remove(Rival_Product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
