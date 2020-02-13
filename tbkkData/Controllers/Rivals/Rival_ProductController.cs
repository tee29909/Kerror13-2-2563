using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Controllers.Rivals
{
    public class ArchiveEntry
    {
        public string product { get; set; }
        
        

        public int y { get; set; }
        public string x { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class Rival_ProductController : ControllerBase
    {
        private readonly tbkkDataContext _context;

        public Rival_ProductController(tbkkDataContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Rival_Product Rival_Product { get; set; }
        public Product Product { get; set; }
        // GET: api/Rival_Product
        [HttpGet]
        public List<object> GetComplain()
        {
            List<object> list = new List<object>();
          
            list.Add(
                _context.Product
                
                .Select(s => new
                {
                    y = s.SellingPrice,
                    x = s.ProductID,
                })
                .ToArray()
                ) ;
            list.Add(
                _context.Rival_Product.Include(r => r.Product)
                .GroupBy(g => new
                {
                    product = g.Product.Name
                })
                .Select(s => new
                {
                    y = s.Average(a => a.Price),
                    x = s.ElementAt(0).ProductID,
                })
                .ToArray()
                ) ; ;


            return list;
        }

        // GET: api/Rival_Product/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRival_Product([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var rival_Product = await _context.Rival_Product
                .Include(r => r.Product)
                .Include(r => r.Rival).ToListAsync();

            if (rival_Product == null)
            {
                return NotFound();
            }

            return Ok(rival_Product);
        }

        // PUT: api/Rival_Product/5
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

        // POST: api/Rival_Product
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

        // DELETE: api/Rival_Product/5
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