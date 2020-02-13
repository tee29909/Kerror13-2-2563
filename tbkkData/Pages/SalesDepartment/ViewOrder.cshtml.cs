using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.SalesDepartment
{
    public class ViewOrderModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public ViewOrderModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get; set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }
        public int? emp { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id,int? id2)
        {
            emp = id;

            Order = await _context.Order
                .Include(o => o.Customer)
                .Include(o => o.Employee).ToListAsync();
            Order = Order.Where(o => o.CustomerID == id).ToList();

            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            return Page();
        }

       
    }
}