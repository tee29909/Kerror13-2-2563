﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.QA
{
    public class DetailsSurveyModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public DetailsSurveyModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public SurveyOperators SurveyOperators { get; set; }
        public IList<Employee> Employees { get; set; }
        public Employee Employee1 { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);


            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();
            SurveyOperators = await _context.SurveyOperators
                .Include(s => s.Survey)
                .Include(s => s.Type_Survey).FirstOrDefaultAsync(m => m.SurveyOperatorsID == id);

            if (SurveyOperators == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
