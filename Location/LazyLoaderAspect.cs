using System;
using PostSharp.Aspects;

namespace Location
{
    [Serializable]
    public class LazyLoaderAspect : LocationInterceptionAspect
    {

        private object _backingField;
        private object _syncRoot = new object();
        public override void OnGetValue(LocationInterceptionArgs args)
        {
            if (_backingField == null)
            {
                lock (_syncRoot)
                {
                    if (_backingField == null)
                    {
                        args.ProceedGetValue();
                        _backingField = args.Value;
                    }
                }
            }
            args.Value = _backingField;
        }
    }

}
