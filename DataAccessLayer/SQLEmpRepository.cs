using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccessLayer
{
    public class SQLEmpRepository : IRepository<Employee>
    {
        private EntityDataContext db;

        private bool disposed = false;

        public SQLEmpRepository()
        {
            this.db = new EntityDataContext();
        }

        public void CreateEmp(Employee emp)
        {
            db.Employees.Add(emp);
        }

        public void DeleteEmp(int id)
        {
            Employee emp = db.Employees.Find(id);
            if (emp != null)
                db.Employees.Remove(emp);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Employee GetEmpById(int id)
        {
            return db.Employees.Find(id);
        }

        public IEnumerable<Employee> GetEmpList()
        {
            return db.Employees;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void UpdateEmp(Employee emp)
        {
            db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
