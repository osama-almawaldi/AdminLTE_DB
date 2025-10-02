using AdminLTE_DB.Data;
using AdminLTE_DB.Models;
using AdminLTE_DB.Repository.Base;

namespace AdminLTE_DB.Repository
{
    public class RepoCategory : MainRepository<Category>, IRepoCategory
    {
        private readonly ApplicationDbContext _context;
        public RepoCategory(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        
        public Category FindByUIdCategory(string uid)
        {
            Category Category= _context.Categories.FirstOrDefault(c => c.uid == uid);
            return Category;
        
        }

    }
}