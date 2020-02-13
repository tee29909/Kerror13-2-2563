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
    public class AddProductRivalModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public AddProductRivalModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }
        //public int RivID { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            //RivID = id;

            Rival = await _context.Rival.FirstOrDefaultAsync(m => m.RivaID == id);

            Employee1 = HttpContext.Session.GetLogin(_context.Employee);
            Employees = await _context.Employee.Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "Name");
            ViewData["RivalID"] = new SelectList(_context.Rival, "RivaID", "Name");
            return Page();
        }

        [BindProperty]
        public Rival_Product Rival_Product { get; set; }
        public Rival Rival { get; set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Rival_Product.Add(Rival_Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}