using System;
using PostSharp.Aspects;

namespace Intercept
{
    [Serializable]
    public class RetryOnExceptionAttribute : MethodInterceptionAspect
    {
        private readonly int _maxRetries;

        public RetryOnExceptionAttribute(int maxRetries)
        {
            _maxRetries = maxRetries;
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
