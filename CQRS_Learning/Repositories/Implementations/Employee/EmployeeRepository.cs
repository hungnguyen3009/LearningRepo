using CQRS_Learning.Models;
using CQRS_Learning.ReadModels;
using CQRS_Learning.Repositories.Interfaces.Employee;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Repositories.Implementations.Employee
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(IConnectionMultiplexer redis, string nameSpace) 
            : base(redis, nameSpace)
        {
        }

        public IEnumerable<EmployeeRM> GetAll()
        {
            return Get<List<EmployeeRM>>("all");
        }

        public EmployeeRM GetById(int id)
        {
            return Get<EmployeeRM>(id);
        }

        public new List<EmployeeRM> GetMultiple(List<int> ids)
        {
            return GetMultiple<EmployeeRM>(ids);
        }

        public void Save(EmployeeRM item)
        {
            Save(item.EmployeeId, item);
            MergeIntoAllCollection(item);
        }

        private void MergeIntoAllCollection(EmployeeRM employee)
        {
            List<EmployeeRM> allEmployees = new List<EmployeeRM>();
            if (Exists("all"))
            {
                allEmployees = Get<List<EmployeeRM>>("all");
            }

            //If the district already exists in the ALL collection, remove that entry
            if (allEmployees.Any(x => x.EmployeeId == employee.EmployeeId))
            {
                allEmployees.Remove(allEmployees.First(x => x.EmployeeId == employee.EmployeeId));
            }

            //Add the modified district to the ALL collection
            allEmployees.Add(employee);

            Save("all", allEmployees);
        }
    }
}
