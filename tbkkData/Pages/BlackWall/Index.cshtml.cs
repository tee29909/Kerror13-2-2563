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
    public class IndexModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public IndexModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get; set; }
        public IList<Product> Product { get; set; }
        public IList<Customer> Customer { get; set; }
        public IList<Order_Product> Order_Products { get; set; }
        public IList<groupProduct> groupProducts { get; set; }
        public Employee Employee1 { get; set; }

        public IList<Employee> Employees { get; set; }

        public async Task OnGetAsync()
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);


            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            Order = await _context.Order
                .Include(o => o.Customer)
                .Include(o => o.Employee).ToListAsync();

            Customer = await _context.Customer.ToListAsync();
            Product = await _context.Product.ToListAsync();
            Order_Products = await _context.Order_Product.ToListAsync();


            var a = new List<groupProduct>();

            foreach (var item in Product)
            {
                var z = new groupProduct();
                var group_product = Order_Products.Where(s => s.ProductID == item.ProductID).ToList();
                z.sum = group_product.Sum(s => s.Qty);
                z.product = item;
                a.Add(z);
            }
            groupProducts = a;

        }
        public class groupProduct
        {
            public Product product { get; set; }
            public int sum { get; set; }
        }

    }
}
