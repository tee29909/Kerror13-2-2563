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
    public class Claim_HistoryModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public Claim_HistoryModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        
        public IList<Complain> Complain { get; set; }
        public IList<Claim> Claim { get; set; }
        public Employee Employee1 { get; set; }

        public IList<Employee> Employees { get; set; }
        public async Task OnGetAsync()
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
             .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();
            Complain = await _context.Complain.Include(p => p.Order).ToListAsync();
            Claim = await _context.Claim.Include(p => p.Complain).ToListAsync();
        }
    }
    
}
