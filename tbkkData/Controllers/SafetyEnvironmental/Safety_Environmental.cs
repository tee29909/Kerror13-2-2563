using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Controllers.SafetyEnvironmental
{
    public class ArchiveEntry
    {
        public int SafetyID { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string MonthName
        {
            get
            {
                return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(this.Month);

            }
        }

        public int y { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class Safety_Environmental : ControllerBase
    {
        private readonly tbkkDataContext _context;

        public Safety_Environmental(tbkkDataContext context)
        {
            _context = context;
        }

        // GET: api/Safety_Environmental
        [HttpGet]
        public List<object> GetSafety()
        {
            List<object> list = new List<object>();
            list.Add(
                 _context.Safety
                 .GroupBy(g => new {
                     Year = g.DateIncident.Year,
                     Month = g.DateIncident.Month,
                 })
                 .Select(s => new
                 {
                     y = s.Sum(a => a.incident),
                     x = s.ElementAt(0).DateIncident.ToString("yyyy-MM-dd"),
                 })
                 .ToArray()
                 ); ;

           
            list.Add(
                 _context.Safety
                 .GroupBy(g => new {
                     Year = g.DateIncident.Year,
                     Month = g.DateIncident.Month,
                 })
                 .Select(s => new
                 {
                     y = s.Sum(a => a.Total_Incident),
                     x = s.ElementAt(0).DateIncident.ToString("yyyy-MM-dd"),
                 })
                 .ToArray()
                 ); ;


            return list;
        }

        // GET: api/Safety_Environmental/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSafety([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var safety = await _context.Safety.FindAsync(id);

            if (safety == null)
            {
                return NotFound();
            }

            return Ok(safety);
        }

        // PUT: api/Safety_Environmental/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSafety([FromRoute] int id, [FromBody] Safety safety)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != safety.SafetyID)
            {
                return BadRequest();
            }

            _context.Entry(safety).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SafetyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Safety_Environmental
        [HttpPost]
        public async Task<IActionResult> PostSafety([FromBody] Safety safety)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Safety.Add(safety);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSafety", new { id = safety.SafetyID }, safety);
        }

        // DELETE: api/Safety_Environmental/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSafety([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var safety = await _context.Safety.FindAsync(id);
            if (safety == null)
            {
                return NotFound();
            }

            _context.Safety.Remove(safety);
            await _context.SaveChangesAsync();

            return Ok(safety);
        }

        private bool SafetyExists(int id)
        {
            return _context.Safety.Any(e => e.SafetyID == id);
        }
    }
}