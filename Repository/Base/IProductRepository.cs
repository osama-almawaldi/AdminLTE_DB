using AdminLTE_DB.Models;

namespace AdminLTE_DB.Repository.Base
{
    public interface IProductRepository
    {
        void Update(Product product);
        void UpdateRange(IEnumerable<Product> products);
    }
}