using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.BlueWall
{
    public class IndexModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public IndexModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }
        public int Qty { get; set; }

        public IList<Employee> Employee { get; set; }
       
       // public IList<AgeGroup> AgeGroup { get; set; }
        public IList<Department> Department { get; set; }
        public IList<EmployeeType> EmployeeType { get; set; }
        public IList<Order_Product> Order_Products { get; set; }

        public Employee Employee1 { get; set; }

        public IList<Employee> Employees { get; set; }

        public async Task OnGetAsync()
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);


            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();


            Employee = await _context.Employee.ToListAsync();

            Order_Products = await _context.Order_Product.ToListAsync();





        }
    }

}
