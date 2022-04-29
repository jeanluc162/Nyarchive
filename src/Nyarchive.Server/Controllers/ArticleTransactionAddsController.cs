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
    public class ArticleTransactionAddsController : ControllerBase
    {
        private readonly NyarchiveDbContext _context;

        public ArticleTransactionAddsController(NyarchiveDbContext context)
        {
            _context = context;
        }

        // GET: api/ArticleTransactionAdds
        [HttpGet]
        [Authorize(Roles = Role.RoleNames.ArticleTransactionReader)]
        public async Task<ActionResult<IEnumerable<ArticleTransactionAdd>>> GetArticleTransactionAdds()
        {
            return await _context.ArticleTransactionAdds.ToListAsync();
        }

        // GET: api/ArticleTransactionAdds/5
        [HttpGet("{id}")]
        [Authorize(Roles = Role.RoleNames.ArticleTransactionReader)]
        public async Task<ActionResult<ArticleTransactionAdd>> GetArticleTransactionAdd(Guid id)
        {
            var articleTransactionAdd = await _context.ArticleTransactionAdds.FindAsync(id);

            if (articleTransactionAdd == null)
            {
                return NotFound();
            }

            return articleTransactionAdd;
        }

        // PUT: api/ArticleTransactionAdds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = Role.RoleNames.ArticleTransactionWriter)]
        public async Task<IActionResult> PutArticleTransactionAdd(Guid id, ArticleTransactionAdd articleTransactionAdd)
        {
            if (id != articleTransactionAdd.Id)
            {
                return BadRequest();
            }

            _context.Entry(articleTransactionAdd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticleTransactionAddExists(id))
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

        // POST: api/ArticleTransactionAdds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = Role.RoleNames.ArticleTransactionWriter)]
        public async Task<ActionResult<ArticleTransactionAdd>> PostArticleTransactionAdd(ArticleTransactionAdd articleTransactionAdd)
        {
            _context.ArticleTransactionAdds.Add(articleTransactionAdd);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticleTransactionAdd", new { id = articleTransactionAdd.Id }, articleTransactionAdd);
        }

        // DELETE: api/ArticleTransactionAdds/5
        [HttpDelete("{id}")]
        [Authorize(Roles = Role.RoleNames.ArticleTransactionWriter)]
        public async Task<IActionResult> DeleteArticleTransactionAdd(Guid id)
        {
            var articleTransactionAdd = await _context.ArticleTransactionAdds.FindAsync(id);
            if (articleTransactionAdd == null)
            {
                return NotFound();
            }

            _context.ArticleTransactionAdds.Remove(articleTransactionAdd);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticleTransactionAddExists(Guid id)
        {
            return _context.ArticleTransactionAdds.Any(e => e.Id == id);
        }
    }
}
