using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Learning.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetMultiple(List<int> ids);
        bool Exists(int id);
        void Save(T item);
    }
}
