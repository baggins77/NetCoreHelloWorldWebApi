using System;
using NETCoreHelloWorldWebApi.Domain;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Persistence.Mapping.Inbound
{
    public class MessageToMessageConverter : AbstractTypeConverter<Message, Model.Message>
    {
        protected override Model.Message Convert(Message source)
        {
            throw new NotImplementedException();
        }
    }
}