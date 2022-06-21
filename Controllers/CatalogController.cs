using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PK_API.Data;
using PK_API.Interfaces;
using PK_API.Models;

namespace PK_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogRespository _catalogs;

        public CatalogController(ICatalogRespository catalogs)
        {
            _catalogs = catalogs;
        }


        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllCatalogs()
        {

            return Ok(await _catalogs.GetAllCatalogsAsync());
        }


        [HttpGet]
        [Route("id")]
        public async Task<IActionResult> GetCatalogsyId(int id)
        {
             var emp = await _catalogs.GetCatalogById(id);
             return Ok(emp);
        }


        [HttpPost]
        [Route("Creater")]
        public async Task<IActionResult> CreateCatalog([FromBody] Catalog catalog)
        {
            return Ok(await _catalogs.CreateCatalogAsync(catalog));
        }


        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> UpdateCatalog([FromBody] Catalog catalog)
        {
            return Ok( await _catalogs.UpdateCatalogAsync(catalog));
        }

        
        [Route("Delete/{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            return Ok(await _catalogs.DeleteCatalogAsync(id));
        }
    }
}
