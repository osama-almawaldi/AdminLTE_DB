using AdminLTE_DB.Models;

namespace AdminLTE_DB.Repository.Base
{
    public interface ICartItemRepository
    {
        Task<List<CartItem>> GetByCustomerWithProductAsync(int customerId);
        void RemoveRange(IEnumerable<CartItem> items);
    }
}