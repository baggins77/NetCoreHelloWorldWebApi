using System.Collections.Generic;

namespace NETCoreHelloWorldWebApi.ServiceModel
{
    public interface IHasValidationErrors
    {
        //The key would be field name, the value would be the error message
        Dictionary<string, string> Errors { get; set; }
    }
}