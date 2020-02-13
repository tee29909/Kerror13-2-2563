using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.Rivals
{
    public class UpdateRivalModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public UpdateRivalModel(tbkkData.Models.tbkkDataContext context)
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
           ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "Name");
           ViewData["RivalID"] = new SelectList(_context.Rival, "RivaID", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Rival_Product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Rival_ProductExists(Rival_Product.RivProductID))
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

        private bool Rival_ProductExists(int id)
        {
            return _context.Rival_Product.Any(e => e.RivProductID == id);
        }
    }
}
