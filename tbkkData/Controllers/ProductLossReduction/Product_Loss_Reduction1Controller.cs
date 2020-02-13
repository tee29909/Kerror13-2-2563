using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Controllers.ProductLossReduction
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

        public int y { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class Product_Loss_Reduction1Controller : ControllerBase
    {
        private readonly tbkkDataContext _context;

        public Product_Loss_Reduction1Controller(tbkkDataContext context)
        {
            _context = context;
        }

        // GET: api/Product_Loss_Reduction1
        [HttpGet]
        public List<object> GetProduct_Loss_Reduction()
        {
            List<object> list = new List<object>();
            list.Add(
                 _context.Product_Loss_Reduction.Where(s => s.type_productLoossID == 2)
                 .GroupBy(g => new {
                     Year = g.Date.Year,
                     Month = g.Date.Month,
                 })
                 .Select(s => new
                 {
                     y = s.Sum(a => a.Limits),
                     x = s.ElementAt(0).Date.ToString("yyyy-MM-dd"),
                 })
                 .ToArray()
                 ); ;
            list.Add(
                _context.Product_Loss_Reduction.Where(s => s.type_productLoossID == 2)
                .GroupBy(g => new {
                    Year = g.Date.Year,
                    Month = g.Date.Month,
                })
                 .Select(s => new
                 {
                     y = s.Sum(a => a.Man_Hr_Per_pc),
                     x = s.ElementAt(0).Date.ToString("yyyy-MM-dd"),
                 })
                .ToArray()
                ); ;

            return list;
        }

        // GET: api/Product_Loss_Reduction1/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct_Loss_Reduction([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product_Loss_Reduction = await _context.Product_Loss_Reduction.FindAsync(id);

            if (product_Loss_Reduction == null)
            {
                return NotFound();
            }

            return Ok(product_Loss_Reduction);
        }

        // PUT: api/Product_Loss_Reduction1/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct_Loss_Reduction([FromRoute] int id, [FromBody] Product_Loss_Reduction product_Loss_Reduction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product_Loss_Reduction.Product_Loss_ReductionID)
            {
                return BadRequest();
            }

            _context.Entry(product_Loss_Reduction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Product_Loss_ReductionExists(id))
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

        // POST: api/Product_Loss_Reduction1
        [HttpPost]
        public async Task<IActionResult> PostProduct_Loss_Reduction([FromBody] Product_Loss_Reduction product_Loss_Reduction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Product_Loss_Reduction.Add(product_Loss_Reduction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct_Loss_Reduction", new { id = product_Loss_Reduction.Product_Loss_ReductionID }, product_Loss_Reduction);
        }

        // DELETE: api/Product_Loss_Reduction1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct_Loss_Reduction([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var product_Loss_Reduction = await _context.Product_Loss_Reduction.FindAsync(id);
            if (product_Loss_Reduction == null)
            {
                return NotFound();
            }

            _context.Product_Loss_Reduction.Remove(product_Loss_Reduction);
            await _context.SaveChangesAsync();

            return Ok(product_Loss_Reduction);
        }

        private bool Product_Loss_ReductionExists(int id)
        {
            return _context.Product_Loss_Reduction.Any(e => e.Product_Loss_ReductionID == id);
        }
    }
}