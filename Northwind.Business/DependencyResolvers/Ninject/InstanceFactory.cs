using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.DependencyResolvers.Ninject
{
    public static class InstanceFactory
    {
        //public static T GetInstance<T>(NinjectModule module)
        public static T GetInstance<T>()
        {
            //var kernel = new StandardKernel(module);
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
