using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;

namespace QuartzExample.Utilities.Quartz
{
    public static class QuartzStartupExtension
    {
        public static void UseQuartz(this IServiceCollection services)
        {
            services.AddHostedService<QuartzHostedService>();
            services.AddSingleton<IJobFactory, SingletonJobFactory>();
            services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
        }
        public static void AddQuartzSingleton<TService>(this IServiceCollection services,string expression)
        {
            var serviceType = typeof(TService);
            services.AddSingleton(serviceType);
            services.AddSingleton(new MyJob(type: serviceType, expression: expression));
        }
    }
}
