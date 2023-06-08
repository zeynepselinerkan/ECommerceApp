using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace ECommerceApp.Application.IoC
{
    public class DependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // IoC --> Interface çağırdığım zaman bana onun concrete yapısını getirmesi gerektiği işlemi burada söylüyorum.

            // ÖRNEK :  builder.RegisterType<BaseRepo>().As<IBaseRepo>().InstancePerLifeTimeScope();

            // program.cs tarafında yapacağım eklemeleri buradan yapabilirim.

            // Örnek olarak automapper eklenmesini buradan yapabilirim.

            base.Load(builder);
        }
        
    }
}
