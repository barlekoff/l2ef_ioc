using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace l2_entity_ioc
{
    class Program
    {
        static void Main(string[] args)
        {
            using (EntityDataContext db = new EntityDataContext())
            {
                Employee e1 = new Employee { Name = "Kirill", Age = 28, Post = "Director", Salary = 2000 };
                Employee e2 = new Employee { Name = "Semen", Age = 25, Post = "Manager", Salary = 1500 };

                db.Employees.Add(e1);
                db.Employees.Add(e2);

                db.SaveChanges();

                Console.WriteLine("Ребятки добавлены");
                Console.ReadKey();
            }
        }
    }
}
