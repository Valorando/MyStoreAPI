using MyStoreAPI.Models;

namespace MyStoreAPI.Interfaces
{
    public interface IProductService
    {
        public Task<List<ProductModel>> GetAllProducts();
    }
}
