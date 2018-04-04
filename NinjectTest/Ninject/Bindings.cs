using Ninject.Modules;
using NinjectTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectTest.Ninject
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<Entities>().To<Entities>();
        }
    }
}