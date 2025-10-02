using AdminLTE_DB.Data;
using AdminLTE_DB.Models;
using AdminLTE_DB.Repository.Base;

namespace AdminLTE_DB.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) => _db = db;

        public void Update(Product product) => _db.Products.Update(product);

        public void UpdateRange(IEnumerable<Product> products) => _db.Products.UpdateRange(products);
    }
}