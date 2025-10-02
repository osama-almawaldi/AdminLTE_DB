using AdminLTE_DB.Models;

namespace AdminLTE_DB.Repository.Base
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);
        Task<Order?> GetWithItemsAndProductsAsync(int orderId);
    }
}