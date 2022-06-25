using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalStockManage.Data;
using FinalStockManage.Models;

namespace FinalStockManage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly FinalStockManageContext _context;

        public SupplierController(FinalStockManageContext context)
        {
            _context = context;
        }

        // GET: api/Supplier
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Supplier>>> GetSupplier()
        {
          if (_context.Supplier == null)
          {
              return NotFound();
          }
            return await _context.Supplier.ToListAsync();
        }

        // GET: api/Supplier/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Supplier>> GetSupplier(int id)
        {
          if (_context.Supplier == null)
          {
              return NotFound();
          }
            var supplier = await _context.Supplier.FindAsync(id);

            if (supplier == null)
            {
                return NotFound();
            }

            return supplier;
        }

        // PUT: api/Supplier/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(int id, Supplier supplier)
        {
            if (id != supplier.SupplierId)
            {
                return BadRequest();
            }

            _context.Entry(supplier).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplierExists(id))
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

        // POST: api/Supplier
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Supplier>> PostSupplier(Supplier supplier)
        {
          if (_context.Supplier == null)
          {
              return Problem("Entity set 'FinalStockManageContext.Supplier'  is null.");
          }
            _context.Supplier.Add(supplier);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSupplier", new { id = supplier.SupplierId }, supplier);
        }

        // DELETE: api/Supplier/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            if (_context.Supplier == null)
            {
                return NotFound();
            }
            var supplier = await _context.Supplier.FindAsync(id);
            if (supplier == null)
            {
                return NotFound();
            }

            _context.Supplier.Remove(supplier);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupplierExists(int id)
        {
            return (_context.Supplier?.Any(e => e.SupplierId == id)).GetValueOrDefault();
        }
    }
}
