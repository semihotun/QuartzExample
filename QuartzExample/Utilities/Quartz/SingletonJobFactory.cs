
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Spi;
using System;

namespace QuartzExample.Utilities.Quartz
{
    public class SingletonJobFactory:IJobFactory
    {
        private readonly IServiceProvider _serviceProvier;

        public SingletonJobFactory(IServiceProvider serviceProvier)
        {
            this._serviceProvier = serviceProvier;
        }

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            return _serviceProvier.GetRequiredService(bundle.JobDetail.JobType) as IJob;
        }

        public void ReturnJob(IJob job) 
        {
            if (job is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }
    }
}
