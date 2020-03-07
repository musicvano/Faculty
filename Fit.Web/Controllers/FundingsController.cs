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
    public class FundingsController : ControllerBase
    {
        private readonly DataContext context;

        public FundingsController(DataContext context)
        {
            this.context = context;
        }

        // GET: api/Fundings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Funding>>> GetFundings()
        {
            return await context.Fundings.ToListAsync();
        }

        // GET: api/Fundings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Funding>> GetFunding(int id)
        {
            var funding = await context.Fundings.FindAsync(id);

            if (funding == null)
            {
                return NotFound();
            }

            return funding;
        }

        // PUT: api/Fundings/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFunding(Guid id, Funding funding)
        {
            if (id != funding.Id)
            {
                return BadRequest();
            }

            context.Entry(funding).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FundingExists(id))
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

        // POST: api/Fundings
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Funding>> PostFunding(Funding funding)
        {
            context.Fundings.Add(funding);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetFunding", new { id = funding.Id }, funding);
        }

        // DELETE: api/Fundings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Funding>> DeleteFunding(int id)
        {
            var funding = await context.Fundings.FindAsync(id);
            if (funding == null)
            {
                return NotFound();
            }

            context.Fundings.Remove(funding);
            await context.SaveChangesAsync();

            return funding;
        }

        private bool FundingExists(Guid id)
        {
            return context.Fundings.Any(e => e.Id == id);
        }
    }
}
