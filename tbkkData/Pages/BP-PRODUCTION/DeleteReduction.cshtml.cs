using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.BP_PRODUCTION
{
    public class DeleteReductionModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteReductionModel(tbkkData.Models.tbkkDataContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product_Loss_Reduction = await _context.Product_Loss_Reduction.FindAsync(id);

            if (Product_Loss_Reduction != null)
            {
                _context.Product_Loss_Reduction.Remove(Product_Loss_Reduction);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./ProductLossReduction");
        }
    }
}
