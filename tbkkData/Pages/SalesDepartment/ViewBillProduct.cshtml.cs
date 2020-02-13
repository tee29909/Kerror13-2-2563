using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.SalesDepartment
{
    public class ViewBillProductModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public ViewBillProductModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Order Order { get; set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }
        public Complain Complain { get; set; }

        public double TotalPrice { get; set; }

        public int? emp { get; set; }
        public int? orderID { get; set; }


        //decimal TotalPrice = Product.Price * Project_Product.Qty;

        public IList<Order_Product> Order_Product { get; set; }
        
        public async Task<IActionResult> OnGetAsync(int? id,int? id2)
        {//ส่งไอดีProJect
            
            emp = id;
            orderID = id2;

            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order
                .Include(p => p.Employee)
                .Include(p => p.Customer).FirstOrDefaultAsync(m => m.OrderID == id2);

            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();


            if (Order == null)
            {
                return NotFound();
            }

            ViewData["EmployeeID"] = new SelectList(_context.Employee, "EmployeeID", "EmployeeID");
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "CustomerID");

            Order_Product = await _context.Order_Product.Include(e => e.Product).ToArrayAsync();

            Order_Product = Order_Product.Where(e => e.OrderID == id2).ToList();


            //decimal TotalPrice = Product.Price * Project_Product.Qty;
            return Page();

        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return Page();
            }

            
            Order.Status = "InComplete";
            if (Order != null)
            {
                _context.Attach(Order).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var a = new Complain();
            a.DateComplain = DateTime.Now;
            a.Status = "InComplete";
            a.OrderID = Order.OrderID;

            Complain = a;
            _context.Complain.Add(Complain);
            await _context.SaveChangesAsync();

            

            return RedirectToPage("./ViewOrder", new { id = Order.CustomerID});
        }


    }
}
