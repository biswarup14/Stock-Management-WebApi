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
    public class ChargeOrderController : ControllerBase
    {
        private readonly FinalStockManageContext _context;

        public ChargeOrderController(FinalStockManageContext context)
        {
            _context = context;
        }

        // GET: api/ChargeOrder
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChargeOrder>>> GetChargeOrder()
        {
          if (_context.ChargeOrder == null)
          {
              return NotFound();
          }
            return await _context.ChargeOrder.ToListAsync();
        }

        // GET: api/ChargeOrder/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChargeOrder>> GetChargeOrder(int id)
        {
          if (_context.ChargeOrder == null)
          {
              return NotFound();
          }
            var chargeOrder = await _context.ChargeOrder.FindAsync(id);

            if (chargeOrder == null)
            {
                return NotFound();
            }

            return chargeOrder;
        }

        // PUT: api/ChargeOrder/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChargeOrder(int id, ChargeOrder chargeOrder)
        {
            if (id != chargeOrder.ChargeOrderId)
            {
                return BadRequest();
            }

            _context.Entry(chargeOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChargeOrderExists(id))
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

        // POST: api/ChargeOrder
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChargeOrder>> PostChargeOrder(ChargeOrder chargeOrder)
        {
          if (_context.ChargeOrder == null)
          {
              return Problem("Entity set 'FinalStockManageContext.ChargeOrder'  is null.");
          }
            _context.ChargeOrder.Add(chargeOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChargeOrder", new { id = chargeOrder.ChargeOrderId }, chargeOrder);
        }

        // DELETE: api/ChargeOrder/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChargeOrder(int id)
        {
            if (_context.ChargeOrder == null)
            {
                return NotFound();
            }
            var chargeOrder = await _context.ChargeOrder.FindAsync(id);
            if (chargeOrder == null)
            {
                return NotFound();
            }

            _context.ChargeOrder.Remove(chargeOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChargeOrderExists(int id)
        {
            return (_context.ChargeOrder?.Any(e => e.ChargeOrderId == id)).GetValueOrDefault();
        }
    }
}
