using MyStoreAPI.Models;

namespace MyStoreAPI.Interfaces
{
    public interface IOrderService
    {
        public Task AddOrder(OrderModel orderModel);
    }
}
