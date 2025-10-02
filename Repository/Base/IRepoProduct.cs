using AdminLTE_DB.Models;

namespace AdminLTE_DB.Repository.Base
{
    public interface IRepoProduct : IRepository<Product>
    {


        IEnumerable<Product> FindAllproducts();

        Product FindByIdproduct(int id);
        Product FindByUIdproduct(string uid);

    }
}