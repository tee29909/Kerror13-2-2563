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
    public class CreateReductionModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public CreateReductionModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> OnGetAsync()
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);
            Employees = await _context.Employee.Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            ViewData["type_productLoossID"] = new SelectList(_context.type_productLooss, "type_productLoossID", "Name");
            return Page();
        }

        [BindProperty]
        public Product_Loss_Reduction Product_Loss_Reduction { get; set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product_Loss_Reduction.Add(Product_Loss_Reduction);
            await _context.SaveChangesAsync();

            return RedirectToPage("./ProductLossReduction");
        }
    }
}