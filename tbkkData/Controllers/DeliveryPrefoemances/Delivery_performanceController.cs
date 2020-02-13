using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Controllers.DeliveryPrefoemances
{
    public class ArchiveEntry
    {

        public int Year { get; set; }
        public int Month { get; set; }
        public string MonthName
        {
            get
            {
                return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(this.Month);
            }
        }

    }

    [Route("api/[controller]")]
    [ApiController]
    public class Delivery_performanceController : ControllerBase
    {
        private readonly tbkkDataContext _context;

        public Delivery_performanceController(tbkkDataContext context)
        {
            _context = context;
        }

        // GET: api/Delivery_performance
        [HttpGet]
        public List<object> GetDelivery_performance()
        {
            List<object> list = new List<object>();
            list.Add(
                _context.Delivery_performance
                .GroupBy(g => new {
                    Year = g.DateDelivery.Year,
                    Month = g.DateDelivery.Month,
                })
                .Select(s => new
                {
                    y = s.Sum(S => S.Complains_Delivery),
                    x = s.ElementAt(0).DateDelivery.ToString("yyyy-MM-dd"),
                })
                .ToArray()
                ); ;
            list.Add(
                _context.Delivery_performance
                .GroupBy(g => new {
                    Year = g.DateDelivery.Year,
                    Month = g.DateDelivery.Month,
                })
                .Select(s => new
                {
                    y = s.Sum(a => a.Claim_Delivery),
                    x = s.ElementAt(0).DateDelivery.ToString("yyyy-MM-dd"),
                })
                .ToArray()
                ); ;

            return list;
        }

        // GET: api/Delivery_performance/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDelivery_performance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var delivery_performance = await _context.Delivery_performance.FindAsync(id);

            if (delivery_performance == null)
            {
                return NotFound();
            }

            return Ok(delivery_performance);
        }

        // PUT: api/Delivery_performance/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDelivery_performance([FromRoute] int id, [FromBody] Delivery_performance delivery_performance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != delivery_performance.Delivery_performanceID)
            {
                return BadRequest();
            }

            _context.Entry(delivery_performance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Delivery_performanceExists(id))
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

        // POST: api/Delivery_performance
        [HttpPost]
        public async Task<IActionResult> PostDelivery_performance([FromBody] Delivery_performance delivery_performance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Delivery_performance.Add(delivery_performance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDelivery_performance", new { id = delivery_performance.Delivery_performanceID }, delivery_performance);
        }

        // DELETE: api/Delivery_performance/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDelivery_performance([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var delivery_performance = await _context.Delivery_performance.FindAsync(id);
            if (delivery_performance == null)
            {
                return NotFound();
            }

            _context.Delivery_performance.Remove(delivery_performance);
            await _context.SaveChangesAsync();

            return Ok(delivery_performance);
        }

        private bool Delivery_performanceExists(int id)
        {
            return _context.Delivery_performance.Any(e => e.Delivery_performanceID == id);
        }
    }
}