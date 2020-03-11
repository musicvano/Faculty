using Fit.Data;
using Fit.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalitiesController : ControllerBase
    {
        private readonly DataContext context;

        public LocalitiesController(DataContext context)
        {
            this.context = context;
        }

        // GET: api/Localities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Locality>>> GetLocalities()
        {
            return await context.Localities.ToListAsync();
        }

        // GET: api/Localities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Locality>> GetLocality(int id)
        {
            var Locality = await context.Localities.FindAsync(id);

            if (Locality == null)
            {
                return NotFound();
            }

            return Locality;
        }

        // PUT: api/Localities/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocality(Guid id, Locality Locality)
        {
            if (id != Locality.Id)
            {
                return BadRequest();
            }

            context.Entry(Locality).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocalityExists(id))
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

        // POST: api/Localities
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Locality>> PostLocality(Locality Locality)
        {
            context.Localities.Add(Locality);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetLocality", new { id = Locality.Id }, Locality);
        }

        // DELETE: api/Localities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Locality>> DeleteLocality(int id)
        {
            var Locality = await context.Localities.FindAsync(id);
            if (Locality == null)
            {
                return NotFound();
            }

            context.Localities.Remove(Locality);
            await context.SaveChangesAsync();

            return Locality;
        }

        private bool LocalityExists(Guid id)
        {
            return context.Localities.Any(e => e.Id == id);
        }
    }
}
