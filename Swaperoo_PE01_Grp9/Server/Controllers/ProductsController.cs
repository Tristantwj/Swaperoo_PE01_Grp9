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
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductsController(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _unitOfWork.Products.GetAll();
            return Ok(products);
        }

        // GET: api/Products/5
        [HttpGet("Detail/{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _unitOfWork.Products.Get(q => q.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // GET: api/Products/Index
        [HttpGet("Index")]
        public async Task<IActionResult> Index(string id)
        {
            if (_unitOfWork.Products == null)
            {
                return Problem("Entity set 'Products' is null.");
            }

            var products = await _unitOfWork.Products.GetAll();

            if (!String.IsNullOrEmpty(id))
            {
                products = products.Where(p => p.Name.Contains(id, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            return Ok(products);
        }


        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Products.Update(product);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!ProductExists(id))
                if (!await ProductExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            await _unitOfWork.Products.Insert(product);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _unitOfWork.Products.Get(q =>q.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            await _unitOfWork.Products.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool ProductExists(int id)
        private async Task<bool> ProductExists(int  id)
        {
            var product = await _unitOfWork.Products.Get(q => q.Id == id);
            return product != null;
        }
    }
}
