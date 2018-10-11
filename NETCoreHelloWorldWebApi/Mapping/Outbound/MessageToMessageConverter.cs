using AutoMapper;
using NETCoreHelloWorldWebApi.Domain;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Mapping.Outbound
{
    public class MessageToMessageConverter : AbstractTypeConverter<Message, ServiceModel.Message>
    {
        protected override ServiceModel.Message Convert(Message source)
        {
            ServiceModel.Message dest = null;

            if (source != null)
            {
                dest = new ServiceModel.Message
                {
                    Title = source.Title,
                    Content = source.Content,
                    Author = Mapper.Map<ServiceModel.Author>(source.Author)
                };
            }

            return dest;
        }
    }
}