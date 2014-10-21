using System;
using PostSharp.Aspects;

namespace Intercept
{
    [Serializable]
    public class ExceptionAspect : OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            args.FlowBehavior = FlowBehavior.Return;
            args.ReturnValue = "Not valid";
            Console.Write("\n{0} throw an exception: {1}\n\n", args.Method.Name, args.Exception.GetType());

        }
    }
}
