using AdminLTE_DB.Models;

namespace AdminLTE_DB.Repository.Base
{
    public interface IRepoCategory : IRepository<Category>
    {
        Category FindByUIdCategory(string uid);

    }
}