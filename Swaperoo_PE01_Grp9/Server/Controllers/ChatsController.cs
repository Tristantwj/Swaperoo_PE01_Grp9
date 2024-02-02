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
    public class ChatsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChatsController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Chats
        [HttpGet]
        public async Task<IActionResult> GetChats()
        {
            var chats = await _unitOfWork.Chats.GetAll(includes: q => q.Include(x => x.Purchase).ThenInclude(p => p.PurchaseProduct).ThenInclude(u => u.User).Include(x => x.Purchase).ThenInclude(p => p.User).Include(x => x.Swap).ThenInclude(p => p.SwapProduct).ThenInclude(c => c.User).Include(x => x.Swap).ThenInclude(p => p.OfferItem).ThenInclude(c => c.User));
            return Ok(chats);

        }

        // GET: api/Chats/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChat(int id)
        {
            var chat = await _unitOfWork.Chats.Get(q => q.Id == id, includes: q => q.Include(x => x.Purchase).ThenInclude(p => p.PurchaseProduct).ThenInclude(u => u.User).Include(x => x.Purchase).ThenInclude(p => p.User).Include(x => x.Swap).ThenInclude(p => p.SwapProduct).ThenInclude(c => c.User).Include(x => x.Swap).ThenInclude(p => p.OfferItem).ThenInclude(c => c.User));

            if (chat == null)
            {
                return NotFound();
            }

            return Ok(chat);
        }

        // PUT: api/Chats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChat(int id, Chat chat)
        {
            if (id != chat.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Chats.Update(chat);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!ChatExists(id))
                if (!await ChatExists(id))
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

        // POST: api/Chats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Chat>> PostChat(Chat chat)
        {
            await _unitOfWork.Chats.Insert(chat);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetChat", new { id = chat.Id }, chat);
        }

        // DELETE: api/Chats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChat(int id)
        {
            var chat = await _unitOfWork.Chats.Get(q =>q.Id == id);
            if (chat == null)
            {
                return NotFound();
            }

            await _unitOfWork.Chats.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool ChatExists(int id)
        private async Task<bool> ChatExists(int  id)
        {
            var chat = await _unitOfWork.Chats.Get(q => q.Id == id);
            return chat != null;
        }
    }
}
