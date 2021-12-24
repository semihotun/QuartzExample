using Quartz;
using QuartzExample.Utilities.Logs;
using System;
using System.Threading.Tasks;

namespace QuartzExample.Utilities.Quartz
{
    public class JobReminders : IJob
    {
        public JobReminders()
        {
        }


        public Task Execute(IJobExecutionContext context)
        {
            FileLog.Logs($"JobReminders at "+DateTime.Now.ToString(), "JobReminders"+ DateTime.Now.ToString("hhmmss"));

            return Task.CompletedTask;
        }
    }
}
