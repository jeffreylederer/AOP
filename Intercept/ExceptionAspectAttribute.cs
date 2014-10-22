using System;
using PostSharp.Aspects;

namespace Intercept
{
    [Serializable]
    public class ExceptionAspectAttribute : OnExceptionAspect
    {
        private Type _expectedException;

        public ExceptionAspectAttribute(Type ExpectedException)
        {
            _expectedException = ExpectedException;
        }

        public override void OnException(MethodExecutionArgs args)
        {
            args.FlowBehavior = FlowBehavior.Return;
            args.ReturnValue = "Not valid";
            Console.Write("\n{0} throw an exception: {1}\n\n", args.Method.Name, args.Exception.GetType());

        }
    }
}
