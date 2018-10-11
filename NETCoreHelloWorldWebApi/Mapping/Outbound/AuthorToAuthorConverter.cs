using NETCoreHelloWorldWebApi.Domain;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Mapping.Outbound
{
    public class AuthorToAuthorConverter : AbstractTypeConverter<Author, ServiceModel.Author>
    {
        protected override ServiceModel.Author Convert(Author source)
        {
            ServiceModel.Author dest = null;

            if (source != null)
            {
                dest = new ServiceModel.Author
                {
                    FirstName = source.FirstName,
                    LastName = source.LastName,
                    FullName = source.FullName
                };
            }

            return dest;
        }
    }
}