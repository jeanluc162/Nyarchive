#nullable disable
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
    public class LanguagesController : ControllerBase
    {
        private readonly NyarchiveDbContext _context;

        public LanguagesController(NyarchiveDbContext context)
        {
            _context = context;
        }

        // GET: api/Languages
        [HttpGet]
        [Authorize(Roles = Role.RoleNames.LanguagesReader)]
        public async Task<ActionResult<IEnumerable<Language>>> GetLanguages()
        {
            return await _context.Languages.ToListAsync();
        }

        // GET: api/Languages/5
        [HttpGet("{id}")]
        [Authorize(Roles = Role.RoleNames.LanguagesReader)]
        public async Task<ActionResult<Language>> GetLanguage(Guid id)
        {
            var language = await _context.Languages.FindAsync(id);

            if (language == null)
            {
                return NotFound();
            }

            return language;
        }

        // PUT: api/Languages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = Role.RoleNames.LanguagesWriter)]
        public async Task<IActionResult> PutLanguage(Guid id, Language language)
        {
            if (id != language.Id)
            {
                return BadRequest();
            }

            _context.Entry(language).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LanguageExists(id))
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

        // POST: api/Languages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = Role.RoleNames.LanguagesWriter)]
        public async Task<ActionResult<Language>> PostLanguage(Language language)
        {
            _context.Languages.Add(language);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLanguage", new { id = language.Id }, language);
        }

        // DELETE: api/Languages/5
        [HttpDelete("{id}")]
        [Authorize(Roles = Role.RoleNames.LanguagesWriter)]
        public async Task<IActionResult> DeleteLanguage(Guid id)
        {
            var language = await _context.Languages.FindAsync(id);
            if (language == null)
            {
                return NotFound();
            }

            _context.Languages.Remove(language);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LanguageExists(Guid id)
        {
            return _context.Languages.Any(e => e.Id == id);
        }
    }
}
