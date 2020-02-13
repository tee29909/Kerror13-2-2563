﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Controllers.QtyProduct
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductQtyController : ControllerBase
    {
        private readonly tbkkDataContext _context;

        public ProductQtyController(tbkkDataContext context)
        {
            _context = context;
        }
        public Order_Product Order_Product { get; set; }
        public Product Product { get; set; }

        // GET: api/ProductQty
        [HttpGet]
        public List<object> GetOrder_Product()
        {
            List<object> list = new List<object>();
            list.Add(
                 _context.Order_Product

                 .GroupBy(g => new {
                     Product = g.ProductID
                 })
                 .Select(s => new
                 {
                     y = s.Sum(a => a.Qty),
                     x = s.ElementAt(0).ProductID
                 })
                 .ToArray()
                 ); ;

            return list;
        }

        // GET: api/ProductQty/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder_Product([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var order_Product = await _context.Order_Product.FindAsync(id);

            if (order_Product == null)
            {
                return NotFound();
            }

            return Ok(order_Product);
        }

        // PUT: api/ProductQty/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder_Product([FromRoute] int id, [FromBody] Order_Product order_Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order_Product.Order_ProductID)
            {
                return BadRequest();
            }

            _context.Entry(order_Product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Order_ProductExists(id))
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

        // POST: api/ProductQty
        [HttpPost]
        public async Task<IActionResult> PostOrder_Product([FromBody] Order_Product order_Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Order_Product.Add(order_Product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder_Product", new { id = order_Product.Order_ProductID }, order_Product);
        }

        // DELETE: api/ProductQty/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder_Product([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var order_Product = await _context.Order_Product.FindAsync(id);
            if (order_Product == null)
            {
                return NotFound();
            }

            _context.Order_Product.Remove(order_Product);
            await _context.SaveChangesAsync();

            return Ok(order_Product);
        }

        private bool Order_ProductExists(int id)
        {
            return _context.Order_Product.Any(e => e.Order_ProductID == id);
        }
    }
}