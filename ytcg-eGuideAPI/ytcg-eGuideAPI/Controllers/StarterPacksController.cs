using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ytcg_eGuideAPI.Entities;

namespace ytcg_eGuideAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarterPacksController : ControllerBase
    {
        private readonly YtcgEguiudeDbContext _context;

        public StarterPacksController(YtcgEguiudeDbContext context)
        {
            _context = context;
        }

        // GET: api/StarterPacks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StarterPack>>> GetStarterPacks()
        {
            return await _context.StarterPacks.ToListAsync();
        }

        // GET: api/StarterPacks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StarterPack>> GetStarterPack(int id)
        {
            var starterPack = await _context.StarterPacks.FindAsync(id);

            if (starterPack == null)
            {
                return NotFound();
            }

            return starterPack;
        }

        // PUT: api/StarterPacks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStarterPack(int id, StarterPack starterPack)
        {
            if (id != starterPack.Id)
            {
                return BadRequest();
            }

            _context.Entry(starterPack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StarterPackExists(id))
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

        // POST: api/StarterPacks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StarterPack>> PostStarterPack(StarterPack starterPack)
        {
            _context.StarterPacks.Add(starterPack);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStarterPack", new { id = starterPack.Id }, starterPack);
        }

        // DELETE: api/StarterPacks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStarterPack(int id)
        {
            var starterPack = await _context.StarterPacks.FindAsync(id);
            if (starterPack == null)
            {
                return NotFound();
            }

            _context.StarterPacks.Remove(starterPack);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StarterPackExists(int id)
        {
            return _context.StarterPacks.Any(e => e.Id == id);
        }
    }
}
