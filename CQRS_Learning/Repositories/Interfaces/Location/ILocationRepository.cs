using CQRS_Learning.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Repositories.Interfaces.Location
{
    public interface ILocationRepository : IBaseRepository<LocationRM>
    {
        IEnumerable<LocationRM> GetAll();
        IEnumerable<EmployeeRM> GetEmployees(int locationId);
        bool HasEmployee(int locationId, int employeeId);
    }
}
