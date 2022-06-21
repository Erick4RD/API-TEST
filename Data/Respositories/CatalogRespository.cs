using Microsoft.EntityFrameworkCore;
using PK_API.Interfaces;
using PK_API.Models;

namespace PK_API.Data.Respositories
{
    public class CatalogRespository : ICatalogRespository
    {
        private readonly ApplicationDbContext _ctx;
        public CatalogRespository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Catalog> CreateCatalogAsync(Catalog catalog)
        {
            _ctx.Catalogs.Add(catalog);
            await _ctx.SaveChangesAsync();
            return catalog;
        }

        public async Task<Catalog> DeleteCatalogAsync(int id)
        {
         var CatDelete  = await _ctx.Catalogs.FirstOrDefaultAsync(Catalog => Catalog.Id == id);
            _ctx.Catalogs.Remove(CatDelete);
            await _ctx.SaveChangesAsync();
            return CatDelete;
        }

        public async Task<List<Catalog>> GetAllCatalogsAsync()
        {
            return await _ctx.Catalogs.ToListAsync();
        }

        public async Task<Catalog> GetCatalogById(int id)
        {
            return await _ctx.Catalogs.FirstOrDefaultAsync(Catalog => Catalog.Id == id);
        }

        public async Task<Catalog> UpdateCatalogAsync(Catalog catalog)
        {
           _ctx.Catalogs.Update(catalog);
            await _ctx.SaveChangesAsync();
            return catalog;
        }


    }
}
