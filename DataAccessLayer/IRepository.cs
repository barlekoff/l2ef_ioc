using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetEmpList();
        T GetEmpById(int id);
        void CreateEmp(T item);
        void UpdateEmp(T item);
        void DeleteEmp(int id);
        void Save();
    }
}
