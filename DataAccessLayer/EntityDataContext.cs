using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace DataAccessLayer
{
    public class EntityDataContext : DbContext
    {
        public EntityDataContext()
            : base("SQLEmployeesDb")
        { }

        public DbSet<Employee> Employees { get; set; }
    }
}
