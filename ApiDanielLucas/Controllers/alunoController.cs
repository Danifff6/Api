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
    public class alunoController : ControllerBase
    {
        private readonly ApiDanielLucasContext _context;

        public alunoController(ApiDanielLucasContext context)
        {
            _context = context;
        }

        // GET: api/aluno
        [HttpGet]
        public async Task<ActionResult<IEnumerable<aluno>>> Getaluno()
        {
            return await _context.aluno.ToListAsync();
        }

        // GET: api/aluno/5
        [HttpGet("{id}")]
        public async Task<ActionResult<aluno>> Getaluno(int id)
        {
            var aluno = await _context.aluno.FindAsync(id);

            if (aluno == null)
            {
                return NotFound();
            }

            return aluno;
        }

        // PUT: api/aluno/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putaluno(int id, aluno aluno)
        {
            if (id != aluno.id)
            {
                return BadRequest();
            }

            _context.Entry(aluno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!alunoExists(id))
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

        // POST: api/aluno
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<aluno>> Postaluno(aluno aluno)
        {
            _context.aluno.Add(aluno);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getaluno", new { id = aluno.id }, aluno);
        }

        // DELETE: api/aluno/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletealuno(int id)
        {
            var aluno = await _context.aluno.FindAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }

            _context.aluno.Remove(aluno);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool alunoExists(int id)
        {
            return _context.aluno.Any(e => e.id == id);
        }
    }
}
