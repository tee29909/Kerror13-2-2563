using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.BP_PRODUCTION
{
    public class EditReductionModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public EditReductionModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product_Loss_Reduction Product_Loss_Reduction { get; set; }
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

            Product_Loss_Reduction = await _context.Product_Loss_Reduction
                 .Include(p => p.type_productLooss).FirstOrDefaultAsync(m => m.Product_Loss_ReductionID == id);

            if (Product_Loss_Reduction == null)
            {
                return NotFound();
            }
            ViewData["type_productLoossID"] = new SelectList(_context.type_productLooss, "type_productLoossID", "Name");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Product_Loss_Reduction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_Loss_ReductionExists(Product_Loss_Reduction.Product_Loss_ReductionID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./ProductLossReduction");
        }

        private bool Product_Loss_ReductionExists(int id)
        {
            return _context.Product_Loss_Reduction.Any(e => e.Product_Loss_ReductionID == id);
        }
    }
}
