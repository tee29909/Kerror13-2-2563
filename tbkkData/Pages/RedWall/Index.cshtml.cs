using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.RedWall
{
    public class IndexModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public IndexModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public IList<Rival> Rival { get;set; }
        public IList<Customer> Customer { get; set; }
        public IList<Employee> Employees { get; set; }
        public Employee Employee1 { get; set; }
        public Rival_Product Rival_Product { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);


            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            Rival = await _context.Rival.ToListAsync();

            Customer = await _context.Customer.ToListAsync();

             ViewData["RivalID"] = new SelectList(_context.Rival, "RivaID", "Name");
            return Page();
        }
    }
}
