﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nyarchive.Server.Model;
using Nyarchive.Server.Model.Auth;

namespace Nyarchive.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController : ControllerBase
    {
        private readonly NyarchiveDbContext _context;

        public UnitsController(NyarchiveDbContext context)
        {
            _context = context;
        }

        // GET: api/Units
        [HttpGet]
        [Authorize(Roles = Role.RoleNames.UnitsReader)]
        public async Task<ActionResult<IEnumerable<Unit>>> GetUnits()
        {
            return await _context.Units.ToListAsync();
        }

        // GET: api/Units/5
        [HttpGet("{id}")]
        [Authorize(Roles = Role.RoleNames.UnitsReader)]
        public async Task<ActionResult<Unit>> GetUnit(Guid id)
        {
            var unit = await _context.Units.FindAsync(id);

            if (unit == null)
            {
                return NotFound();
            }

            return unit;
        }

        // PUT: api/Units/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = Role.RoleNames.UnitsWriter)]
        public async Task<IActionResult> PutUnit(Guid id, Unit unit)
        {
            if (id != unit.Id)
            {
                return BadRequest();
            }

            _context.Entry(unit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UnitExists(id))
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

        // POST: api/Units
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = Role.RoleNames.UnitsWriter)]
        public async Task<ActionResult<Unit>> PostUnit(Unit unit)
        {
            _context.Units.Add(unit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUnit", new { id = unit.Id }, unit);
        }

        // DELETE: api/Units/5
        [HttpDelete("{id}")]
        [Authorize(Roles = Role.RoleNames.UnitsWriter)]
        public async Task<IActionResult> DeleteUnit(Guid id)
        {
            var unit = await _context.Units.FindAsync(id);
            if (unit == null)
            {
                return NotFound();
            }

            _context.Units.Remove(unit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UnitExists(Guid id)
        {
            return _context.Units.Any(e => e.Id == id);
        }
    }
}
