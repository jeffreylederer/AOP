﻿using System;
using System.Reflection;
using PostSharp;
using PostSharp.Aspects;
using PostSharp.Extensibility;

namespace BeforeAfter
{
    [Serializable]
    public class ExecutionDurationAspect : OnMethodBoundaryAspect
    {
        private string _methodName;
        public override void CompileTimeInitialize(System.Reflection.MethodBase method, AspectInfo aspectInfo)
        {
            _methodName = method.Name;
        }

        public override bool CompileTimeValidate(MethodBase method)
        {
            var info = method as MethodInfo;
            if (info == null || info.ReturnType.ToString() != "System.String")
            {
                Message.Write(MessageLocation.Of(method), SeverityType.Error, "987",
                    "Methods using this aspect can only return a string. You applied it on type {0}",
                    info == null ? "Unknown" : info.ReturnType.ToString());
              
                return false;
            }
            return true;
        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = DateTime.Now;
        }

        

        public override void OnSuccess(MethodExecutionArgs args)
        {
            var start = (DateTime)args.MethodExecutionTag;
            TimeSpan ts = DateTime.Now.Subtract(start);
            Console.Write("\nTiming: {0} executed in {1:0} milliseconds\n\n", _methodName,
                                               ts.Milliseconds);
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Console.Write("\n{0} throw an exception: {1}\n\n", _methodName, args.Exception.GetType());
            args.FlowBehavior = FlowBehavior.Return;
            if (args.Arguments.Count > 0)
                args.ReturnValue = string.Format("Timing: {0} is a bad parameter", args.Arguments[0]);
            else
                args.ReturnValue = string.Format("failed");
        }
    }
}