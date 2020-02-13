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
    public class DetailsRivalModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DetailsRivalModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public Rival Rival { get; set; }
        //public Rival_Product Rival_Product { get; set; }
        public IList<Rival_Product> Rival_Product { get;set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }

        public int? riv { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id, int? id2)
        {
            riv = id;
            if (id == null)
            {
                return NotFound();
            }

            Rival = await _context.Rival
                .FirstOrDefaultAsync(m => m.RivaID == id);
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();


            if (Rival == null)
            {
                return NotFound();
            }
            Rival_Product = await _context.Rival_Product.Include(e => e.Product).ToArrayAsync();

            Rival_Product = Rival_Product.Where(e => e.RivalID == id).ToList();



            return Page();
        }
    }
}
