using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.QA
{
    public class CreateSurveysModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public CreateSurveysModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);
            Employees = await _context.Employee.Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            ViewData["SurveyID"] = new SelectList(_context.Survey, "SurveyID", "NameSurvey");
        ViewData["Type_SurveyID"] = new SelectList(_context.Type_Survey, "Type_SurveyID", "TypeSurvey");
            return Page();
        }

        [BindProperty]
        public SurveyOperators SurveyOperators { get; set; }
        public IList<Employee> Employees { get; set; }
        public Employee Employee1 { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SurveyOperators.Add(SurveyOperators);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Surveys");
        }
    }
}