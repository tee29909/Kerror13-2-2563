using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Controllers.ServayOperator
{
    public class ArchiveEntry
    {
        public int TypeSureyID { get; set; }
        public string survey { get; set; }
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
    public class SurveyOperatorsController : ControllerBase
    {
        private readonly tbkkDataContext _context;

        public SurveyOperatorsController(tbkkDataContext context)
        {
            _context = context;
        }
        public SurveyOperators SurveyOperators { get; set; }
        public Survey Survey { get; set; }




        // GET: api/SurveyOperators
        [HttpGet]
        public List<object> GetSurveyOperators()
        {
            List<object> list = new List<object>();
            list.Add(
                _context.SurveyOperators.Where(s => s.Type_SurveyID == 1)
                .GroupBy(g => new
                {
                    survey = g.SurveyID

                })
                .Select(s => new
                {

                    y = s.Sum(S => S.SurveyCount),
                    x = s.ElementAt(0).SurveyID,
                })
                .ToArray()
                ); ;
            list.Add(
                _context.SurveyOperators.Where(s => s.Type_SurveyID == 2)
                .GroupBy(g => new
                {
                    survey = g.SurveyID
                })
                .Select(s => new
                {
                    y = s.Sum(S => S.SurveyCount),
                    x = s.ElementAt(0).SurveyID,
                })
                .ToArray()
                ); ;
            return list;
        }

        // GET: api/SurveyOperators/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSurveyOperators([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var surveyOperators = await _context.SurveyOperators.FindAsync(id);

            if (surveyOperators == null)
            {
                return NotFound();
            }

            return Ok(surveyOperators);
        }

        // PUT: api/SurveyOperators/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSurveyOperators([FromRoute] int id, [FromBody] SurveyOperators surveyOperators)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != surveyOperators.SurveyOperatorsID)
            {
                return BadRequest();
            }

            _context.Entry(surveyOperators).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SurveyOperatorsExists(id))
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

        // POST: api/SurveyOperators
        [HttpPost]
        public async Task<IActionResult> PostSurveyOperators([FromBody] SurveyOperators surveyOperators)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SurveyOperators.Add(surveyOperators);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSurveyOperators", new { id = surveyOperators.SurveyOperatorsID }, surveyOperators);
        }

        // DELETE: api/SurveyOperators/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSurveyOperators([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var surveyOperators = await _context.SurveyOperators.FindAsync(id);
            if (surveyOperators == null)
            {
                return NotFound();
            }

            _context.SurveyOperators.Remove(surveyOperators);
            await _context.SaveChangesAsync();

            return Ok(surveyOperators);
        }



        private bool SurveyOperatorsExists(int id)
        {
            return _context.SurveyOperators.Any(e => e.SurveyOperatorsID == id);
        }


    }
}