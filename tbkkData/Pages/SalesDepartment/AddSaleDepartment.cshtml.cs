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
    public class AddSaleDepartmentModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public AddSaleDepartmentModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        //public Order Order { get; set; }
        public Order Order { get; set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Order = await _context.Order
                .Include(p => p.Customer)
                .Include(p => p.Employee).FirstOrDefaultAsync(m => m.OrderID == id);

            ViewData["OrderID"] = new SelectList(_context.Order, "OrderID", "Invoice");
         ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "Name");

            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();


            return Page();
        }

        [BindProperty]
        public Order_Product Order_Product { get; set; }
        public Product Product { get; set; }
        

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            Product = await _context.Product.FirstOrDefaultAsync(m => m.ProductID == Order_Product.ProductID);
            double Price = Product.SellingPrice;
            int Qty = Order_Product.Qty;
            int IDOrder = Order_Product.OrderID;

            _context.Order_Product.Add(Order_Product);
            await _context.SaveChangesAsync();

            double SumTotalPrice = Qty * Price;
            Order = await _context.Order.FirstOrDefaultAsync(m => m.OrderID == IDOrder);
            Order.Total = Order.Total + SumTotalPrice;

            _context.Attach(Order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(Order.OrderID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }


            return RedirectToPage("./ViewOrder", new { id = Order.CustomerID });
        }



        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderID == id);
        }
    }
}