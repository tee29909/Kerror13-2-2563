  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.QA
{
    public class ComplainModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public ComplainModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        //public IList<Complain> Complain { get;set; }
        
        public Order Order { get; set; }
        public Complain Complains { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<Complain> Complain { get; set; }
        public Claim Claim { get; set; }

        public IList<Employee> Employees { get; set; }
        public Employee Employee1 { get; set; }

        public async Task OnGetAsync()
        {
            Employee1 = HttpContext.Session.GetLogin(_context.Employee);


            Employees = await _context.Employee
                .Where(r => r.EmployeeID == Employee1.EmployeeID).ToListAsync();

            Complain = await _context.Complain
                .Include(c => c.Order)
              //  .Include(c => c.Status_Claim)
              .ToListAsync();

            Orders = await _context.Order
              .Include(c => c.Customer)
              .Include(c => c.Employee).ToListAsync();

            Complain = await _context.Complain
             .Include(c => c.Order).ToListAsync();

            Complain = Complain.Where(sad => sad.Status.Equals("InComplete")).ToList();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Complains = await _context.Complain.FirstOrDefaultAsync(m => m.ComplainID == id);
            Order = await _context.Order.FirstOrDefaultAsync(m => m.OrderID == Complains.OrderID);

            Order.Status = "Complete";
            Complains.Status = "Complete";
            _context.Attach(Order).State = EntityState.Modified;
            _context.Attach(Order).State = EntityState.Modified;

            if (Complain != null)
            {
                _context.Attach(Complain).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            var a = new Claim();
            a.DateClaim = DateTime.Now;
            a.Status = "Complete";
            a.ComplainID = Complains.ComplainID;

            Claim = a;
            _context.Claim.Add(Claim);
            await _context.SaveChangesAsync();



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

            return RedirectToPage("./Complain");
        }
        private bool OrderExists(int id)
        {
            return _context.SurveyOperators.Any(e => e.SurveyOperatorsID == id);
        }

    }
}
