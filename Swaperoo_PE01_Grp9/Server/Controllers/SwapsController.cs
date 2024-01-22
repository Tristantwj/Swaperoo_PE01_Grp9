using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swaperoo_PE01_Grp9.Server.Data;
using Swaperoo_PE01_Grp9.Shared.Domain;
using Swaperoo_PE01_Grp9.Server.Repository;
using Swaperoo_PE01_Grp9.Server.IRepository;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Swaperoo_PE01_Grp9.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SwapsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SwapsController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Swaps
        [HttpGet]
        public async Task<IActionResult> GetSwaps()
        {
            var swaps = await _unitOfWork.Swaps.GetAll(includes: q => q.Include(x => x.User).Include(x => x.Product));
            return Ok(swaps);
        }

        // GET: api/Swaps/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSwap(int id)
        {
            var swap = await _unitOfWork.Swaps.Get(q => q.Id == id);

            if (swap == null)
            {
                return NotFound();
            }

            return Ok(swap);
        }

        // PUT: api/Swaps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSwap(int id, Swap swap)
        {
            if (id != swap.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Swaps.Update(swap);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!SwapExists(id))
                if (!await SwapExists(id))
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

        // POST: api/Swaps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Swap>> PostSwap(Swap swap)
        {
            await _unitOfWork.Swaps.Insert(swap);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSwap", new { id = swap.Id }, swap);
        }

        // DELETE: api/Swaps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSwap(int id)
        {
            var swap = await _unitOfWork.Swaps.Get(q =>q.Id == id);
            if (swap == null)
            {
                return NotFound();
            }

            await _unitOfWork.Swaps.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool SwapExists(int id)
        private async Task<bool> SwapExists(int  id)
        {
            var swap = await _unitOfWork.Swaps.Get(q => q.Id == id);
            return swap != null;
        }
    }
}
