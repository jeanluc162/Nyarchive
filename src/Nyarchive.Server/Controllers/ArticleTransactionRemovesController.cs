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
    public class ArticleTransactionRemovesController : ControllerBase
    {
        private readonly NyarchiveDbContext _context;

        public ArticleTransactionRemovesController(NyarchiveDbContext context)
        {
            _context = context;
        }

        // GET: api/ArticleTransactionRemoves
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticleTransactionRemove>>> GetArticleTransactionRemoves()
        {
            return await _context.ArticleTransactionRemoves.ToListAsync();
        }

        // GET: api/ArticleTransactionRemoves/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArticleTransactionRemove>> GetArticleTransactionRemove(Guid id)
        {
            var articleTransactionRemove = await _context.ArticleTransactionRemoves.FindAsync(id);

            if (articleTransactionRemove == null)
            {
                return NotFound();
            }

            return articleTransactionRemove;
        }

        // PUT: api/ArticleTransactionRemoves/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticleTransactionRemove(Guid id, ArticleTransactionRemove articleTransactionRemove)
        {
            if (id != articleTransactionRemove.Id)
            {
                return BadRequest();
            }

            _context.Entry(articleTransactionRemove).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleTransactionRemoveExists(id))
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

        // POST: api/ArticleTransactionRemoves
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ArticleTransactionRemove>> PostArticleTransactionRemove(ArticleTransactionRemove articleTransactionRemove)
        {
            _context.ArticleTransactionRemoves.Add(articleTransactionRemove);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticleTransactionRemove", new { id = articleTransactionRemove.Id }, articleTransactionRemove);
        }

        // DELETE: api/ArticleTransactionRemoves/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticleTransactionRemove(Guid id)
        {
            var articleTransactionRemove = await _context.ArticleTransactionRemoves.FindAsync(id);
            if (articleTransactionRemove == null)
            {
                return NotFound();
            }

            _context.ArticleTransactionRemoves.Remove(articleTransactionRemove);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticleTransactionRemoveExists(Guid id)
        {
            return _context.ArticleTransactionRemoves.Any(e => e.Id == id);
        }
    }
}
