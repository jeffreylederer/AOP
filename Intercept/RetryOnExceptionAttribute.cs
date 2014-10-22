using System;
using PostSharp.Aspects;

namespace Intercept
{
    [Serializable]
    public class RetryOnExceptionAttribute : MethodInterceptionAspect
    {
        private int _maxRetries { get; set; }

        public RetryOnExceptionAttribute(int MaxRetries)
        {
            _maxRetries = MaxRetries;
        }
       
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            int retriesCounter = 0;

            while ( true )
            {
                try
                {
                    args.Proceed();
                    return;
                }
                catch (Exception e)
                {
                    retriesCounter++;
                    if (retriesCounter > _maxRetries) throw;

                    Console.WriteLine(
                        "Exception during attempt {0} of calling method {1}.{2}: {3}",
                        retriesCounter, args.Method.DeclaringType, args.Method.Name, e.Message);
                }
            }
        }
    }
}
