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
    public class EditSurveyModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public EditSurveyModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        [BindProperty]
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
            ViewData["SurveyID"] = new SelectList(_context.Survey, "SurveyID", "NameSurvey");
            ViewData["Type_SurveyID"] = new SelectList(_context.Type_Survey, "Type_SurveyID", "TypeSurvey");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SurveyOperators).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurveyOperatorsExists(SurveyOperators.SurveyOperatorsID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Surveys");
        }

        private bool SurveyOperatorsExists(int id)
        {
            return _context.SurveyOperators.Any(e => e.SurveyOperatorsID == id);
        }
    }
}