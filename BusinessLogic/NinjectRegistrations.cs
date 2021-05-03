using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Model;
using Ninject.Modules;

namespace BusinessLogic.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Employee>>().To<SQLEmpRepository>().InSingletonScope();
        }
    }
}
