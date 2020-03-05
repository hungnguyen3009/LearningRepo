using CQRS_Learning.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Repositories.Interfaces.Employee
{
    public interface IEmployeeRepository : IBaseRepository<EmployeeRM>
    {
        IEnumerable<EmployeeRM> GetAll();
    }
}
