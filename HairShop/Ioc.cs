using DLL;
using DLL.EF;
using HairShop.View;
using HairShop.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HairShop
{
    public static class Ioc
    {
        private static readonly IServiceProvider _serviceProvider;

        static Ioc()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            _serviceProvider = serviceCollection.BuildServiceProvider();
            _serviceProvider.GetRequiredService<HairShopDbContext>().Database.EnsureCreated();

        }
        public static T Resolve<T>() => _serviceProvider.GetRequiredService<T>();

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HairShopDbContext>(options =>
                options.UseSqlServer(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString));

            services.AddRepositories();

            services.AddTransient<MainViewModel>();
            services.AddTransient<ProductList>();
            services.AddTransient<MainWindow>();
        }
    }
}
