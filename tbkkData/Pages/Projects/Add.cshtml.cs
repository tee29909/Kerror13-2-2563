using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.Projects
{
    public class AddModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public AddModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public Project Project { get; set; }
        public Employee Employee1 { get; set; }
        public IList<Employee> Employees { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Project = await _context.Project
                .Include(p => p.Employee).FirstOrDefaultAsync(m => m.ProjectID == id);
            ViewData["ProductID"] = new SelectList(_context.Product, "ProductID", "Name");
            ViewData["ProjectID"] = new SelectList(_context.Project, "ProjectID", "Name");

            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();


            return Page();
        }

        [BindProperty]
        public Project_Product Project_Product { get; set; }
        public Product Product { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.ProductID == Project_Product.ProductID);
            double Price = Product.CostPrice;
            int Qty = Project_Product.Qty;
            int IDProJect = Project_Product.ProjectID;

            Product = await _context.Product.FirstOrDefaultAsync(m => m.ProductID == Project_Product.ProductID);
            double Price2 = Product.SellingPrice;
            int Qty2 = Project_Product.Qty;
            int IDProJect2 = Project_Product.ProjectID;

            _context.Project_Product.Add(Project_Product);
            await _context.SaveChangesAsync();

            
            double SumTotalPrice = Qty * Price;
            Project = await _context.Project.FirstOrDefaultAsync(m => m.ProjectID == IDProJect);
            Project.Cost = Project.Cost + SumTotalPrice;

            double SumTotalPrice2 = Qty2 * Price2;
            Project = await _context.Project.FirstOrDefaultAsync(m => m.ProjectID == IDProJect2);
            Project.CostGoal = Project.CostGoal + SumTotalPrice2;



            _context.Attach(Project).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectExists(Project.ProjectID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }





            return RedirectToPage("./Index");
        }
        private bool ProjectExists(int id)
        {
            return _context.Project.Any(e => e.ProjectID == id);
        }
    }
}