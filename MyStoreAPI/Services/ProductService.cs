using MySql.Data.MySqlClient;
using System.Data;
using MyStoreAPI.Models;
using MyStoreAPI.Interfaces;

namespace MyStoreAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly string _connectionString;
        private readonly Dictionary<string, string> _sqlQueries;

        public ProductService(string connectionString, Dictionary<string, string> sqlQueries)
        {
            _connectionString = connectionString;
            _sqlQueries = sqlQueries;
        }

        public Task<List<ProductModel>> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}

