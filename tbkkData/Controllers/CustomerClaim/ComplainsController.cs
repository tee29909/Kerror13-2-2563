using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Controllers.CustomerClaim
{
    public class ArchiveEntry
    {
        public int Status_Claim { get; set; }
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
    public class ComplainsController : ControllerBase
    {
        private readonly tbkkDataContext _context;

        public ComplainsController(tbkkDataContext context)
        {
            _context = context;
        }

        // GET: api/Complains
        [HttpGet]
        public List<object> GetComplain()
        {
            List<object> list = new List<object>();
            
            list.Add(
                _context.Complain.Where(o => o.Status == "InComplete")
               
                .Select( s => new { 
                    y = s.Status,
                    x = s.DateComplain.ToString("yyyy-MM-dd")
                })
                .ToArray()
                ); ;
            list.Add(_context.Complain.Where(o => o.Status == "Complete")
                .GroupBy(g => new {
                    Year = g.DateComplain.Year,
                    Month = g.DateComplain.Month,
                })
                .Select( s => new {
                    y = s.Count(),
                    x = s.ElementAt(0).DateComplain.ToString("yyyy-MM-dd"),
                })
                .ToArray()
                );;

            return list;
        }

        // GET: api/Complains/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComplain([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var complain = await _context.Complain.FindAsync(id);

            if (complain == null)
            {
                return NotFound();
            }

            return Ok(complain);
        }

        // PUT: api/Complains/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutComplain([FromRoute] int id, [FromBody] Complain complain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != complain.ComplainID)
            {
                return BadRequest();
            }

            _context.Entry(complain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplainExists(id))
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

        // POST: api/Complains
        [HttpPost]
        public async Task<IActionResult> PostComplain([FromBody] Complain complain)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Complain.Add(complain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComplain", new { id = complain.ComplainID }, complain);
        }

        // DELETE: api/Complains/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComplain([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var complain = await _context.Complain.FindAsync(id);
            if (complain == null)
            {
                return NotFound();
            }

            _context.Complain.Remove(complain);
            await _context.SaveChangesAsync();

            return Ok(complain);
        }

        private bool ComplainExists(int id)
        {
            return _context.Complain.Any(e => e.ComplainID == id);
        }
    }
}