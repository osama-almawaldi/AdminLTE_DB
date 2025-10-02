namespace AdminLTE_DB.Repository.Base;
using System.Collections.Generic;
using AdminLTE_DB.Models;


    public interface IRepoEmployee : IRepository<Employee>
    {

        Employee Login(string username, string password);

        IEnumerable<Employee> FindAllEmployee();
    }
