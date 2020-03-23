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
    public class StudiesController : ControllerBase
    {
        private readonly DataContext context;

        public StudiesController(DataContext context)
        {
            this.context = context;
        }

        // GET: api/Studies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Study>>> GetStudyForms()
        {
            return await context.Studies.ToListAsync();
        }

        // GET: api/Studies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Study>> GetStudy(int id)
        {
            var study = await context.Studies.FindAsync(id);

            if (study == null)
            {
                return NotFound();
            }

            return study;
        }

        // PUT: api/Studies/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudy(Guid id, Study study)
        {
            if (id != study.Id)
            {
                return BadRequest();
            }

            context.Entry(study).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudyExists(id))
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

        // POST: api/Studies
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Study>> PostStudy(Study study)
        {
            context.Studies.Add(study);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetStudy", new { id = study.Id }, study);
        }

        // DELETE: api/Studies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Study>> DeleteStudy(int id)
        {
            var study = await context.Studies.FindAsync(id);
            if (study == null)
            {
                return NotFound();
            }

            context.Studies.Remove(study);
            await context.SaveChangesAsync();

            return study;
        }

        private bool StudyExists(Guid id)
        {
            return context.Studies.Any(e => e.Id == id);
        }
    }
}