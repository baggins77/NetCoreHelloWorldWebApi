using NETCoreHelloWorldWebApi.Domain;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Persistence.Mapping.Outbound
{
    public class MessageToMessageConverter : AbstractTypeConverter<Model.Message, Message>
    {
        protected override Message Convert(Model.Message source)
        {
            Message dest = null;

            if (source != null)
            {
                dest = new Message
                {
                    Id = source.Id,
                    Title = source.Title,
                    Content = source.Content
                };
            }

            return dest;
        }
    }
}