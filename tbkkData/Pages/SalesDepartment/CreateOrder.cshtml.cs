using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.SalesDepartment
{
    public class CreateOrderModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public CreateOrderModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }
        public int CusID { get; set; }

        [BindProperty]
        public IList<Order> Orders { get; set; }
        public IList<Order> Order1 { get; set; }
        [BindProperty]
        public Order Order { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            CusID = id;
            Order = await _context.Order
               .Include(p => p.Customer)
               .Include(p => p.Employee).FirstOrDefaultAsync(m => m.OrderID == id);


            Employee1 = HttpContext.Session.GetLogin(_context.Employee);
            Employees = await _context.Employee.Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "FirsName");
            ViewData["EmployeeID"] = new SelectList(_context.Employee, "EmployeeID", "FirstName");
            
            return Page();
        }

       public IList<Customer> c { get; set; }

       // public Order Order { get; set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }

        public async Task<IActionResult> OnPostAsync()
        { 
            Order1 = await _context.Order
                .ToListAsync();

            StringBuilder a = new StringBuilder("INV-00");
            a.Append(Order1.Count().ToString());
            string b = a.ToString();

            Order.Invoice = b;

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Order.Add(Order);
            await _context.SaveChangesAsync();

           

            return RedirectToPage("./ViewOrder", new { id = Order.CustomerID });
        }
    }
}