using System.Collections.Generic;

namespace NETCoreHelloWorldWebApi.ServiceModel
{
    public abstract class RequestBase : IHasValidationErrors
    {
        public bool IsValid => Validate();

        public Dictionary<string, string> Errors { get; set; }

        protected abstract bool Validate();
    }
}