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
    public class CreateDeliverysModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public CreateDeliverysModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);
            Employees = await _context.Employee.Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            ViewData["EmployeeID"] = new SelectList(_context.Employee, "EmployeeID", "FirstName");
            return Page();
        }

        [BindProperty]
        public Delivery_performance Delivery_performance { get; set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            _context.Delivery_performance.Add(Delivery_performance);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Deliverys");
        }
    }
}