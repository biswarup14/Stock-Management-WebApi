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
    public class CashOrderController : ControllerBase
    {
        private readonly FinalStockManageContext _context;

        public CashOrderController(FinalStockManageContext context)
        {
            _context = context;
        }

        // GET: api/CashOrder
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CashOrder>>> GetCashOrder()
        {
          if (_context.CashOrder == null)
          {
              return NotFound();
          }
            return await _context.CashOrder.ToListAsync();
        }

        // GET: api/CashOrder/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CashOrder>> GetCashOrder(int id)
        {
          if (_context.CashOrder == null)
          {
              return NotFound();
          }
            var cashOrder = await _context.CashOrder.FindAsync(id);

            if (cashOrder == null)
            {
                return NotFound();
            }

            return cashOrder;
        }

        // PUT: api/CashOrder/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCashOrder(int id, CashOrder cashOrder)
        {
            if (id != cashOrder.CashOrderId)
            {
                return BadRequest();
            }

            _context.Entry(cashOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CashOrderExists(id))
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

        // POST: api/CashOrder
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CashOrder>> PostCashOrder(CashOrder cashOrder)
        {
          if (_context.CashOrder == null)
          {
              return Problem("Entity set 'FinalStockManageContext.CashOrder'  is null.");
          }
            _context.CashOrder.Add(cashOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCashOrder", new { id = cashOrder.CashOrderId }, cashOrder);
        }

        // DELETE: api/CashOrder/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCashOrder(int id)
        {
            if (_context.CashOrder == null)
            {
                return NotFound();
            }
            var cashOrder = await _context.CashOrder.FindAsync(id);
            if (cashOrder == null)
            {
                return NotFound();
            }

            _context.CashOrder.Remove(cashOrder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CashOrderExists(int id)
        {
            return (_context.CashOrder?.Any(e => e.CashOrderId == id)).GetValueOrDefault();
        }
    }
}
