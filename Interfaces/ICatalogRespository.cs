using PK_API.Models;

namespace PK_API.Interfaces
{
    public interface ICatalogRespository
    {
        Task<List<Catalog>> GetAllCatalogsAsync();
        Task<Catalog> GetCatalogById(int id);
        Task<Catalog> CreateCatalogAsync(Catalog catalog);
        Task<Catalog> UpdateCatalogAsync(Catalog catalog);
        Task<Catalog> DeleteCatalogAsync(int id);
    }
}
