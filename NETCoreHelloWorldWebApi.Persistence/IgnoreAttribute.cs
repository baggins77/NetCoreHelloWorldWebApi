using System;

namespace NETCoreHelloWorldWebApi.Persistence
{
    //Just for demonstration, theoretically tells the persistence layer to ignore a property on a persistence model as it pertains to the actual db model. This allows us to include the property on the model prior to mapping to the domain.
    public class IgnoreAttribute : Attribute
    {
        
    }
}