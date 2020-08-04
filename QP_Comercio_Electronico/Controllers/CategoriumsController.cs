﻿using System;
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
    public class CategoriumsController : ControllerBase
    {
        private readonly JosephTutos_PedidosContext _context;

        public CategoriumsController(JosephTutos_PedidosContext context)
        {
            _context = context;
        }

        // GET: api/Categoriums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categorium>>> GetCategoria()
        {
            return await _context.Categoria
                .Include(s=>s.Subcategoria)
                .Include(s => s.Detalletiendacategoria).ToListAsync();
        }

        // GET: api/Categoriums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categorium>> GetCategorium(int id)
        {
            var categorium = await _context.Categoria
                .Include(s => s.Subcategoria)
                .Include(s => s.Detalletiendacategoria)
                .FirstOrDefaultAsync(s=> s.CantId==id);

            if (categorium == null)
            {
                return NotFound();
            }

            return categorium;
        }

        // PUT: api/Categoriums/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategorium(int id, Categorium categorium)
        {
            if (id != categorium.CantId)
            {
                return BadRequest();
            }

            _context.Entry(categorium).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriumExists(id))
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

        // POST: api/Categoriums
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Categorium>> PostCategorium(Categorium categorium)
        {
            _context.Categoria.Add(categorium);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategorium", new { id = categorium.CantId }, categorium);
        }

        // DELETE: api/Categoriums/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Categorium>> DeleteCategorium(int id)
        {
            var categorium = await _context.Categoria.FindAsync(id);
            if (categorium == null)
            {
                return NotFound();
            }

            _context.Categoria.Remove(categorium);
            await _context.SaveChangesAsync();

            return categorium;
        }

        private bool CategoriumExists(int id)
        {
            return _context.Categoria.Any(e => e.CantId == id);
        }
    }
}
