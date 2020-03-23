using Fit.Data;
using Fit.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fit.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DegreesController : ControllerBase
    {
        private readonly DataContext context;

        public DegreesController(DataContext context)
        {
            this.context = context;
        }

        // GET: api/Degrees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Degree>>> GetDegrees()
        {
            return await context.Degrees.ToListAsync();
        }

        // GET: api/Degrees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Degree>> GetDegree(int id)
        {
            var degree = await context.Degrees.FindAsync(id);

            if (degree == null)
            {
                return NotFound();
            }

            return degree;
        }

        // PUT: api/Degrees/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDegree(Guid id, Degree degree)
        {
            if (id != degree.Id)
            {
                return BadRequest();
            }

            context.Entry(degree).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DegreeExists(id))
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

        // POST: api/Degrees
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Degree>> PostDegree(Degree degree)
        {
            context.Degrees.Add(degree);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetDegree", new { id = degree.Id }, degree);
        }

        // DELETE: api/Degrees/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Degree>> DeleteDegree(int id)
        {
            var degree = await context.Degrees.FindAsync(id);
            if (degree == null)
            {
                return NotFound();
            }

            context.Degrees.Remove(degree);
            await context.SaveChangesAsync();

            return degree;
        }

        private bool DegreeExists(Guid id)
        {
            return context.Degrees.Any(e => e.Id == id);
        }
    }
}