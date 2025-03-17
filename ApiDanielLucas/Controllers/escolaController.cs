using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiDanielLucas.Data;
using ApiDanielLucas.Models;

namespace ApiDanielLucas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class escolaController : ControllerBase
    {
        private readonly ApiDanielLucasContext _context;

        public escolaController(ApiDanielLucasContext context)
        {
            _context = context;
        }

        // GET: api/escola
        [HttpGet]
        public async Task<ActionResult<IEnumerable<escola>>> Getescola()
        {
            return await _context.escola.ToListAsync();
        }

        // GET: api/escola/5
        [HttpGet("{id}")]
        public async Task<ActionResult<escola>> Getescola(int id)
        {
            var escola = await _context.escola.FindAsync(id);

            if (escola == null)
            {
                return NotFound();
            }

            return escola;
        }

        // PUT: api/escola/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putescola(int id, escola escola)
        {
            if (id != escola.id)
            {
                return BadRequest();
            }

            _context.Entry(escola).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!escolaExists(id))
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

        // POST: api/escola
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<escola>> Postescola(escola escola)
        {
            _context.escola.Add(escola);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getescola", new { id = escola.id }, escola);
        }

        // DELETE: api/escola/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteescola(int id)
        {
            var escola = await _context.escola.FindAsync(id);
            if (escola == null)
            {
                return NotFound();
            }

            _context.escola.Remove(escola);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool escolaExists(int id)
        {
            return _context.escola.Any(e => e.id == id);
        }
    }
}
