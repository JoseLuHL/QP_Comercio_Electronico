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
    public class TiendumsController : ControllerBase
    {
        private readonly JosephTutos_PedidosContext _context;

        public TiendumsController(JosephTutos_PedidosContext context)
        {
            _context = context;
        }

        // GET: api/Tiendums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tiendum>>> GetTienda()
        {
            return await _context.Tienda.ToListAsync();
        }

        // GET: api/Tiendums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tiendum>> GetTiendum(int id)
        {
            var tiendum = await _context.Tienda.FindAsync(id);

            if (tiendum == null)
            {
                return NotFound();
            }

            return tiendum;
        }

        // PUT: api/Tiendums/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiendum(int id, Tiendum tiendum)
        {
            if (id != tiendum.TienId)
            {
                return BadRequest();
            }

            _context.Entry(tiendum).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiendumExists(id))
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

        // POST: api/Tiendums
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Tiendum>> PostTiendum(Tiendum tiendum)
        {
            _context.Tienda.Add(tiendum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTiendum", new { id = tiendum.TienId }, tiendum);
        }

        // DELETE: api/Tiendums/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Tiendum>> DeleteTiendum(int id)
        {
            var tiendum = await _context.Tienda.FindAsync(id);
            if (tiendum == null)
            {
                return NotFound();
            }

            _context.Tienda.Remove(tiendum);
            await _context.SaveChangesAsync();

            return tiendum;
        }

        private bool TiendumExists(int id)
        {
            return _context.Tienda.Any(e => e.TienId == id);
        }
    }
}
