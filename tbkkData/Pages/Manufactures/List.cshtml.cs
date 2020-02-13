using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData
{
    public class ListModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public ListModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public IList<Manufacture> Manufacture { get;set; }
        public Employee Employee1 { get; set; }

        public IList<Employee> Employees { get; set; }
        public async Task OnGetAsync()
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
             .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();
            Manufacture = await _context.Manufacture
               //.Include(m => m.Company)
                .Include(m => m.Employee.Company)
                .Include(m => m.Product).ToListAsync();

            
        }
    }
}
