using CQRS_Learning.ReadModels;
using CQRS_Learning.Repositories.Interfaces.Location;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Repositories.Implementations.Location
{
    public class LocationRepository : BaseRepository, ILocationRepository
    {
        public LocationRepository(IConnectionMultiplexer redis, string nameSpace) 
            : base(redis, nameSpace)
        {
        }

        public IEnumerable<LocationRM> GetAll()
        {
            throw new NotImplementedException();
        }

        public LocationRM GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeRM> GetEmployees(int locationId)
        {
            throw new NotImplementedException();
        }

        public new List<LocationRM> GetMultiple(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public bool HasEmployee(int locationId, int employeeId)
        {
            throw new NotImplementedException();
        }

        public void Save(LocationRM item)
        {
            throw new NotImplementedException();
        }
    }
}
