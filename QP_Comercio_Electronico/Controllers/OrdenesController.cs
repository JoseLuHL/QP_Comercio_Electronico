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
    public class OrdenesController : ControllerBase
    {
        private readonly JosephTutos_PedidosContext _context;

        public OrdenesController(JosephTutos_PedidosContext context)
        {
            _context = context;
        }

        // GET: api/Ordenes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ordene>>> GetOrdenes()
        {
            var datos = await _context.Ordenes
                .Include(s => s.Ordendetalles)
                .ThenInclude(s=>s.DetordIdproductoNavigation)
                .Include(s => s.OrdIdclienteNavigation)
                .Where(s=>s.Ordendetalles!=null)
                .ToListAsync();
            //var datos = await _context.Clientes.Include(s => s.Ordenes).ThenInclude(s => s.Ordendetalles).ToListAsync();
            return Ok(datos);
        }

        // GET: api/Ordenes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ordene>> GetOrdene(int id)
        {
            //var ordene = await _context.Ordenes.FindAsync(id);
            var ordene = await _context.Ordenes
                .Include(s => s.Ordendetalles)
                .ThenInclude(s => s.DetordIdproductoNavigation)
                .Include(s=> s.OrdIdclienteNavigation)
                .FirstOrDefaultAsync(s => s.Ordendetalles != null);

            if (ordene == null)
            {
                return NotFound();
            }

            return ordene;
        }
        [HttpGet("tienda/{idtienda}")]
        public async Task<ActionResult<IEnumerable<Ordene>>> GetOrdenTienda(int? idtienda)
        {
            //var ordene = await _context.Ordenes.FindAsync(id);
            var ordene = await _context.Ordenes
                .Include(s => s.Ordendetalles)
                .ThenInclude(s => s.DetordIdproductoNavigation)
                .Include(s => s.OrdIdclienteNavigation)
                .Where(s => s.Ordendetalles != null && s.OrdIdcliente==idtienda)
                .ToListAsync();

            if (ordene == null)
            {
                return NotFound();
            }

            return ordene;
        }

        // PUT: api/Ordenes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrdene(int id, Ordene ordene)
        {
            if (id != ordene.OrdId)
            {
                return BadRequest();
            }

            _context.Entry(ordene).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdeneExists(id))
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

        // POST: api/Ordenes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ordene>> PostOrdene(Ordene ordene)
        {
            _context.Ordenes.Add(ordene);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OrdeneExists(ordene.OrdId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOrdene", new { id = ordene.OrdId }, ordene);
        }

        // DELETE: api/Ordenes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ordene>> DeleteOrdene(int id)
        {
            var ordene = await _context.Ordenes.FindAsync(id);
            if (ordene == null)
            {
                return NotFound();
            }

            _context.Ordenes.Remove(ordene);
            await _context.SaveChangesAsync();

            return ordene;
        }

        private bool OrdeneExists(int id)
        {
            return _context.Ordenes.Any(e => e.OrdId == id);
        }
    }
}
