#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nyarchive.Server.Model;

namespace Nyarchive.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignedNutritionalValuesController : ControllerBase
    {
        private readonly NyarchiveDbContext _context;

        public AssignedNutritionalValuesController(NyarchiveDbContext context)
        {
            _context = context;
        }

        // GET: api/AssignedNutritionalValues
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssignedNutritionalValue>>> GetAssignedNutritionalValues()
        {
            return await _context.AssignedNutritionalValues.ToListAsync();
        }

        // GET: api/AssignedNutritionalValues/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssignedNutritionalValue>> GetAssignedNutritionalValue(Guid id)
        {
            var assignedNutritionalValue = await _context.AssignedNutritionalValues.FindAsync(id);

            if (assignedNutritionalValue == null)
            {
                return NotFound();
            }

            return assignedNutritionalValue;
        }

        // PUT: api/AssignedNutritionalValues/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssignedNutritionalValue(Guid id, AssignedNutritionalValue assignedNutritionalValue)
        {
            if (id != assignedNutritionalValue.Id)
            {
                return BadRequest();
            }

            _context.Entry(assignedNutritionalValue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssignedNutritionalValueExists(id))
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

        // POST: api/AssignedNutritionalValues
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AssignedNutritionalValue>> PostAssignedNutritionalValue(AssignedNutritionalValue assignedNutritionalValue)
        {
            _context.AssignedNutritionalValues.Add(assignedNutritionalValue);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssignedNutritionalValue", new { id = assignedNutritionalValue.Id }, assignedNutritionalValue);
        }

        // DELETE: api/AssignedNutritionalValues/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssignedNutritionalValue(Guid id)
        {
            var assignedNutritionalValue = await _context.AssignedNutritionalValues.FindAsync(id);
            if (assignedNutritionalValue == null)
            {
                return NotFound();
            }

            _context.AssignedNutritionalValues.Remove(assignedNutritionalValue);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssignedNutritionalValueExists(Guid id)
        {
            return _context.AssignedNutritionalValues.Any(e => e.Id == id);
        }
    }
}
