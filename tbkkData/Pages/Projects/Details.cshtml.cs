using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.Projects
{
    public class DetailsModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DetailsModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public Project Project { get; set; }
       
        public double TotalPrice { get; set; }

        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }

        //decimal TotalPrice = Product.Price * Project_Product.Qty;

        public IList<Project_Product> project_Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {//ส่งไอดีProJect
            if (id == null)
            {
                return NotFound();
            }

            Project = await _context.Project
                .Include(p => p.Employee).FirstOrDefaultAsync(m => m.ProjectID == id);
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            if (Project == null)
            {
                return NotFound();
            }
            project_Product = await _context.Project_Product.Include(e => e.Product).ToArrayAsync();

            project_Product = project_Product.Where(e => e.ProjectID == id).ToList();
            
            

            

            //decimal TotalPrice = Product.Price * Project_Product.Qty;
            return Page();

            
        }

        
    }
}
