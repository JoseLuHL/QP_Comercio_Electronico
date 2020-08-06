using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QP_Comercio_Electronico.Models;

namespace QP_Comercio_Electronico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediopagoesController : ControllerBase
    {
        private readonly JosephTutos_PedidosContext _context;

        public MediopagoesController(JosephTutos_PedidosContext context)
        {
            _context = context;
        }

        // GET: api/Mediopagoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mediopago>>> GetMediopagos()
        {
            return await _context.Mediopagos.ToListAsync();
        }

        // GET: api/Mediopagoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mediopago>> GetMediopago(int id)
        {
            var mediopago = await _context.Mediopagos.FindAsync(id);

            if (mediopago == null)
            {
                return NotFound();
            }

            return mediopago;
        }

        // PUT: api/Mediopagoes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMediopago(int id, Mediopago mediopago)
        {
            if (id != mediopago.MepId)
            {
                return BadRequest();
            }

            _context.Entry(mediopago).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MediopagoExists(id))
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

        // POST: api/Mediopagoes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Mediopago>> PostMediopago(Mediopago mediopago)
        {
            _context.Mediopagos.Add(mediopago);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMediopago", new { id = mediopago.MepId }, mediopago);
        }

        // DELETE: api/Mediopagoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Mediopago>> DeleteMediopago(int id)
        {
            var mediopago = await _context.Mediopagos.FindAsync(id);
            if (mediopago == null)
            {
                return NotFound();
            }

            _context.Mediopagos.Remove(mediopago);
            await _context.SaveChangesAsync();

            return mediopago;
        }

        private bool MediopagoExists(int id)
        {
            return _context.Mediopagos.Any(e => e.MepId == id);
        }
    }
}
