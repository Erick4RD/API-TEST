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
            try
            {
                var CatDelete = await _ctx.Catalogs.FirstOrDefaultAsync(Catalog => Catalog.Id == id);
                _ctx.Catalogs.Remove(CatDelete);
                await _ctx.SaveChangesAsync();
                return (Catalog) CatDelete;
            }

            catch(Exception)
            {
                throw new Exception($"Message: It has not been removed.");
            }

        }

        public async Task<List<Catalog>> GetAllCatalogsAsync()
        {
            try
            {
                return await _ctx.Catalogs.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Message: {ex} ");
            }

        }

        public async Task<Catalog> GetCatalogById(int id)
        {
              return await _ctx.Catalogs.FirstOrDefaultAsync(Catalog => Catalog.Id == id);                 
        }

        public async Task<Catalog> UpdateCatalogAsync(Catalog catalog)
        {
            try
            {
                _ctx.Catalogs.Update(catalog);
                await _ctx.SaveChangesAsync();
                return catalog;
            }

            catch(Exception ex)
            {
                throw new Exception($"Message: It has not been Update by {ex} ");
            }
        }


    }
}
