﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData
{
    public class DeleteModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DeleteModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Manufacture Manufacture { get; set; }
        public Employee Employee1 { get; set; }

        public IList<Employee> Employees { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);

            Employees = await _context.Employee
             .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();
            if (id == null)
            {
                return NotFound();
            }

            Manufacture = await _context.Manufacture
                //.Include(m => m.Company)
                .Include(m => m.Employee.Company)
                .Include(m => m.Product).FirstOrDefaultAsync(m => m.ManufactureID == id);

            if (Manufacture == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manufacture = await _context.Manufacture.FindAsync(id);

            if (Manufacture != null)
            {
                _context.Manufacture.Remove(Manufacture);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./List");
        }
    }
}
