using System.Collections.Generic;
using System.Linq;
using AdminLTE_DB.Data;
using AdminLTE_DB.Models;
using AdminLTE_DB.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace AdminLTE_DB.Repository
{
    public class RepoEmployee : MainRepository<Employee>, IRepoEmployee
    {
        private readonly ApplicationDbContext _context;

        public RepoEmployee(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        // 🔑 تسجيل دخول الموظف
        public Employee Login(string username, string password)
        {
            return _context.Employees
                .FirstOrDefault(e => e.Username == username && e.Password == password);
        }

        // 📜 جلب كل الموظفين غير المحذوفين
        public IEnumerable<Employee> FindAllEmployee()
        {
            return _context.Employees
                .Where(e => !e.IsDelete)
                .ToList();
        }
    }
}