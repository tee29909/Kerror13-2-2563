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
    public class SafetysModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public SafetysModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public IList<Safety> Safety { get;set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }
        public async Task OnGetAsync()
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            Safety = await _context.Safety.ToListAsync();
        }
    }
}
