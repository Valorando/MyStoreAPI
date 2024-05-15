using MySql.Data;
using MyStoreAPI.Models;
using MyStoreAPI.Interfaces;

namespace MyStoreAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly string _connectionString;
        private readonly Dictionary<string, string> _sqlQueries;

        public OrderService(string connectionString, Dictionary<string, string> sqlQueries)
        {
            _connectionString = connectionString;
            _sqlQueries = sqlQueries;
        }

        public async Task AddOrder(OrderModel orderModel)
        {
            throw new NotImplementedException();
        }
    }
}
