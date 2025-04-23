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
    public class OwnedCardsController : ControllerBase
    {
        private readonly YtcgEguiudeDbContext _context;

        public OwnedCardsController(YtcgEguiudeDbContext context)
        {
            _context = context;
        }

        // GET: api/OwnedCards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OwnedCard>>> GetOwnedCards()
        {
            return await _context.OwnedCards.ToListAsync();
        }

        // GET: api/OwnedCards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OwnedCard>> GetOwnedCard(int id)
        {
            var ownedCard = await _context.OwnedCards.FindAsync(id);

            if (ownedCard == null)
            {
                return NotFound();
            }

            return ownedCard;
        }

        // PUT: api/OwnedCards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOwnedCard(int id, OwnedCard ownedCard)
        {
            if (id != ownedCard.Id)
            {
                return BadRequest();
            }

            _context.Entry(ownedCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OwnedCardExists(id))
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

        // POST: api/OwnedCards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OwnedCard>> PostOwnedCard(OwnedCard ownedCard)
        {
            _context.OwnedCards.Add(ownedCard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOwnedCard", new { id = ownedCard.Id }, ownedCard);
        }

        // DELETE: api/OwnedCards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOwnedCard(int id)
        {
            var ownedCard = await _context.OwnedCards.FindAsync(id);
            if (ownedCard == null)
            {
                return NotFound();
            }

            _context.OwnedCards.Remove(ownedCard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OwnedCardExists(int id)
        {
            return _context.OwnedCards.Any(e => e.Id == id);
        }
    }
}
