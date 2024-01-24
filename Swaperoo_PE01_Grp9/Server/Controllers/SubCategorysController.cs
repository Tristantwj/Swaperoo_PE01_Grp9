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
    public class SubCategorysController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public SubCategorysController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/SubCategorys
        [HttpGet]
        public async Task<IActionResult> GetSubCategorys()
        {
            var subcategorys = await _unitOfWork.SubCategorys.GetAll(includes: q => q.Include(x => x.Category));
            return Ok(subcategorys);
        }

        // GET: api/SubCategorys/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubCategory(int id)
        {
            var subcategory = await _unitOfWork.SubCategorys.Get(q => q.Id == id);

            if (subcategory == null)
            {
                return NotFound();
            }

            return Ok(subcategory);
        }

        // PUT: api/SubCategorys/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubCategory(int id, SubCategory subcategory)
        {
            if (id != subcategory.Id)
            {
                return BadRequest();
            }
            _unitOfWork.SubCategorys.Update(subcategory);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!SubCategoryExists(id))
                if (!await SubCategoryExists(id))
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

        // POST: api/SubCategorys
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SubCategory>> PostSubCategory(SubCategory subcategory)
        {
            await _unitOfWork.SubCategorys.Insert(subcategory);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSubCategory", new { id = subcategory.Id }, subcategory);
        }

        // DELETE: api/SubCategorys/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubCategory(int id)
        {
            var subcategory = await _unitOfWork.SubCategorys.Get(q =>q.Id == id);
            if (subcategory == null)
            {
                return NotFound();
            }

            await _unitOfWork.SubCategorys.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool SubCategoryExists(int id)
        private async Task<bool> SubCategoryExists(int  id)
        {
            var subcategory = await _unitOfWork.SubCategorys.Get(q => q.Id == id);
            return subcategory != null;
        }
    }
}
