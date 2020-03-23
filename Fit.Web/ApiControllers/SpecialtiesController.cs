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
    public class SpecialtiesController : ControllerBase
    {
        private readonly DataContext context;

        public SpecialtiesController(DataContext context)
        {
            this.context = context;
        }

        // GET: api/Specialties
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Specialty>>> GetSpecialties()
        {
            return await context.Specialties.ToListAsync();
        }

        // GET: api/Specialties/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Specialty>> GetSpecialty(int id)
        {
            var specialty = await context.Specialties.FindAsync(id);

            if (specialty == null)
            {
                return NotFound();
            }

            return specialty;
        }

        // PUT: api/Specialties/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSpecialty(Guid id, Specialty specialty)
        {
            if (id != specialty.Id)
            {
                return BadRequest();
            }

            context.Entry(specialty).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecialtyExists(id))
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

        // POST: api/Specialties
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Specialty>> PostSpecialty(Specialty specialty)
        {
            context.Specialties.Add(specialty);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetSpecialty", new { id = specialty.Id }, specialty);
        }

        // DELETE: api/Specialties/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Specialty>> DeleteSpecialty(int id)
        {
            var specialty = await context.Specialties.FindAsync(id);
            if (specialty == null)
            {
                return NotFound();
            }

            context.Specialties.Remove(specialty);
            await context.SaveChangesAsync();

            return specialty;
        }

        private bool SpecialtyExists(Guid id)
        {
            return context.Specialties.Any(e => e.Id == id);
        }
    }
}
