using NETCoreHelloWorldWebApi.Domain;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Persistence.Mapping.Outbound
{
    public class AuthorToAuthorConverter : AbstractTypeConverter<Model.Author, Author>
    {
        protected override Author Convert(Model.Author source)
        {
            Author dest = null;

            if (source != null)
            {
                dest = new Author
                {
                    Id = source.Id,
                    FirstName = source.FirstName,
                    LastName = source.LastName
                };
            }

            return dest;
        }
    }
}