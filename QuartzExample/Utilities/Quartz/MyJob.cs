using System;

namespace QuartzExample.Utilities.Quartz
{
    public class MyJob
    {
        public MyJob(Type type, string expression)
        {
            Type = type;
            Expression = expression;
        }

        public Type Type { get;  }
        public string Expression { get; set; }
    }
}
