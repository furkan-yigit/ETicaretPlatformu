using Autofac;
using AutoMapper;
using ETicaretPlatformu.Application.AutoMapper;
using ETicaretPlatformu.Application.Services.CartService;
using ETicaretPlatformu.Application.Services.CategoryService;
using ETicaretPlatformu.Application.Services.OrderDetailService;
using ETicaretPlatformu.Application.Services.OrderService;
using ETicaretPlatformu.Application.Services.ProductService;
using ETicaretPlatformu.Application.Services.UserService;
using ETicaretPlatformu.Domain.Entities;
using ETicaretPlatformu.Domain.Repositories;
using ETicaretPlatformu.InfraStructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretPlatformu.Application.IoC
{
    public class DependencyResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepo>().As<IUserRepo>().InstancePerLifetimeScope();
            builder.RegisterType<CartRepo>().As<ICartRepo>().InstancePerLifetimeScope();
            builder.RegisterType<CartLineRepo>().As<ICartLineRepo>().InstancePerLifetimeScope();
            builder.RegisterType<ProductRepo>().As<IProductRepo>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryRepo>().As<ICategoryRepo>().InstancePerLifetimeScope();
            builder.RegisterType<OrderDetailRepo>().As<IOrderDetailRepo>().InstancePerLifetimeScope();
            builder.RegisterType<OrderRepo>().As<IOrderRepo>().InstancePerLifetimeScope();

            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<CartService>().As<ICartService>().InstancePerLifetimeScope();
            builder.RegisterType<ProductService>().As<IProductService>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
            //builder.RegisterType<OrderDetailService>().As<IOrderDetailService>().InstancePerLifetimeScope();
            //builder.RegisterType<OrderService>().As<IOrderService>().InstancePerLifetimeScope();

            builder.Register(context => new MapperConfiguration(config =>
            {
                config.AddProfile<Mapping>();
            })).AsSelf().SingleInstance();

            builder.Register(c =>
            {
                var context = c.Resolve<IComponentContext>();
                var config = context.Resolve<MapperConfiguration>();

                return config.CreateMapper(context.Resolve);
            })
                .As<IMapper>()
                .InstancePerLifetimeScope();






            // Silmiyoruz.
            base.Load(builder);
        }
    }
}
