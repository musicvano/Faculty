﻿using Fit.Data;
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
    public class GroupsController : ControllerBase
    {
        private readonly DataContext context;

        public GroupsController(DataContext context)
        {
            this.context = context;
        }

        // GET: api/Groups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Group>>> GetGroup()
        {
            return await context.Groups.ToListAsync();
        }

        // GET: api/Groups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Group>> GetGroup(int id)
        {
            var @group = await context.Groups.FindAsync(id);

            if (@group == null)
            {
                return NotFound();
            }

            return @group;
        }

        // PUT: api/Groups/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroup(Guid id, Group @group)
        {
            if (id != @group.Id)
            {
                return BadRequest();
            }

            context.Entry(@group).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupExists(id))
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

        // POST: api/Groups
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Group>> PostGroup(Group @group)
        {
            context.Groups.Add(@group);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetGroup", new { id = @group.Id }, @group);
        }

        // DELETE: api/Groups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Group>> DeleteGroup(int id)
        {
            var @group = await context.Groups.FindAsync(id);
            if (@group == null)
            {
                return NotFound();
            }

            context.Groups.Remove(@group);
            await context.SaveChangesAsync();

            return @group;
        }

        private bool GroupExists(Guid id)
        {
            return context.Groups.Any(e => e.Id == id);
        }
    }
}
