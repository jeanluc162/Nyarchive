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
    public class TranslationsController : ControllerBase
    {
        private readonly NyarchiveDbContext _context;

        public TranslationsController(NyarchiveDbContext context)
        {
            _context = context;
        }

        // GET: api/Translations
        [HttpGet]
        [Authorize(Roles = Role.RoleNames.LabelingReader)]
        public async Task<ActionResult<IEnumerable<Translation>>> GetTranslations()
        {
            return await _context.Translations.ToListAsync();
        }

        // GET: api/Translations/5
        [HttpGet("{id}")]
        [Authorize(Roles = Role.RoleNames.LabelingReader)]
        public async Task<ActionResult<Translation>> GetTranslation(Guid id)
        {
            var translation = await _context.Translations.FindAsync(id);

            if (translation == null)
            {
                return NotFound();
            }

            return translation;
        }

        // PUT: api/Translations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = Role.RoleNames.LabelingWriter)]
        public async Task<IActionResult> PutTranslation(Guid id, Translation translation)
        {
            if (id != translation.Id)
            {
                return BadRequest();
            }

            _context.Entry(translation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TranslationExists(id))
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

        // POST: api/Translations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = Role.RoleNames.LabelingWriter)]
        public async Task<ActionResult<Translation>> PostTranslation(Translation translation)
        {
            _context.Translations.Add(translation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTranslation", new { id = translation.Id }, translation);
        }

        // DELETE: api/Translations/5
        [HttpDelete("{id}")]
        [Authorize(Roles = Role.RoleNames.LabelingWriter)]
        public async Task<IActionResult> DeleteTranslation(Guid id)
        {
            var translation = await _context.Translations.FindAsync(id);
            if (translation == null)
            {
                return NotFound();
            }

            _context.Translations.Remove(translation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TranslationExists(Guid id)
        {
            return _context.Translations.Any(e => e.Id == id);
        }
    }
}
