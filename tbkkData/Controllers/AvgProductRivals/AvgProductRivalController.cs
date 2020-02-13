using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Controllers.AvgProductRivals
{
    public class ArchiveEntry
    {
        public int type_productLoossID { get; set; }
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
    public class AvgProductRivalController : ControllerBase
    {
        private readonly tbkkDataContext _context;

        public AvgProductRivalController(tbkkDataContext context)
        {
            _context = context;
        }

        // GET: api/AvgProductRival
        [HttpGet]
        public List<object> GetRival_Product()
        {
            List<object> list = new List<object>();
            list.Add(
                 _context.Rival_Product.Where(s => s.ProductID == 1)
                 .GroupBy(g => new {
                     Year = g.RivDate.Year,
                     Month = g.RivDate.Month,
                 })
                 .Select(s => new
                 {
                     y = s.Average(a => a.Price),
                     x = s.ElementAt(0).RivDate.ToString("yyyy-MM-dd"),
                 })
                 .ToArray()
                 ); ;
            list.Add(
                 _context.Rival_Product.Where(s => s.ProductID == 2)
                 .GroupBy(g => new {
                     Year = g.RivDate.Year,
                     Month = g.RivDate.Month,
                 })
                 .Select(s => new
                 {
                     y = s.Average(a => a.Price),
                     x = s.ElementAt(0).RivDate.ToString("yyyy-MM-dd"),
                 })
                 .ToArray()
                 ); ;
            list.Add(
                 _context.Rival_Product.Where(s => s.ProductID == 3)
                 .GroupBy(g => new {
                     Year = g.RivDate.Year,
                     Month = g.RivDate.Month,
                 })
                 .Select(s => new
                 {
                     y = s.Average(a => a.Price),
                     x = s.ElementAt(0).RivDate.ToString("yyyy-MM-dd"),
                 })
                 .ToArray()
                 ); ;
            list.Add(
                 _context.Rival_Product.Where(s => s.ProductID == 4)
                 .GroupBy(g => new {
                     Year = g.RivDate.Year,
                     Month = g.RivDate.Month,
                 })
                 .Select(s => new
                 {
                     y = s.Average(a => a.Price),
                     x = s.ElementAt(0).RivDate.ToString("yyyy-MM-dd"),
                 })
                 .ToArray()
                 ); ;
            list.Add(
                 _context.Rival_Product.Where(s => s.ProductID == 5)
                 .GroupBy(g => new {
                     Year = g.RivDate.Year,
                     Month = g.RivDate.Month,
                 })
                 .Select(s => new
                 {
                     y = s.Average(a => a.Price),
                     x = s.ElementAt(0).RivDate.ToString("yyyy-MM-dd"),
                 })
                 .ToArray()
                 ); ;

            return list;
        }

        // GET: api/AvgProductRival/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRival_Product([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rival_Product = await _context.Rival_Product.FindAsync(id);

            if (rival_Product == null)
            {
                return NotFound();
            }

            return Ok(rival_Product);
        }

        // PUT: api/AvgProductRival/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRival_Product([FromRoute] int id, [FromBody] Rival_Product rival_Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rival_Product.RivProductID)
            {
                return BadRequest();
            }

            _context.Entry(rival_Product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Rival_ProductExists(id))
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

        // POST: api/AvgProductRival
        [HttpPost]
        public async Task<IActionResult> PostRival_Product([FromBody] Rival_Product rival_Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Rival_Product.Add(rival_Product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRival_Product", new { id = rival_Product.RivProductID }, rival_Product);
        }

        // DELETE: api/AvgProductRival/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRival_Product([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rival_Product = await _context.Rival_Product.FindAsync(id);
            if (rival_Product == null)
            {
                return NotFound();
            }

            _context.Rival_Product.Remove(rival_Product);
            await _context.SaveChangesAsync();

            return Ok(rival_Product);
        }

        private bool Rival_ProductExists(int id)
        {
            return _context.Rival_Product.Any(e => e.RivProductID == id);
        }
    }
}