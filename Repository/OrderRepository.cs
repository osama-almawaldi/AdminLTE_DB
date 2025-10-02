using AdminLTE_DB.Data;
using AdminLTE_DB.Models;
using AdminLTE_DB.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE_DB.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderRepository(ApplicationDbContext db) => _db = db;

        public async Task AddAsync(Order order) => await _db.Orders.AddAsync(order);

        public Task<Order?> GetWithItemsAndProductsAsync(int orderId) =>
            _db.Orders
                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .FirstOrDefaultAsync(o => o.Id == orderId);
    }
}