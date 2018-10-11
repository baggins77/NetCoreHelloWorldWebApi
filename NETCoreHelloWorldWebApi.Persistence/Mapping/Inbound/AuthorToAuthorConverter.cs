using System;
using NETCoreHelloWorldWebApi.Domain;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Persistence.Mapping.Inbound
{
    public class AuthorToAuthorConverter : AbstractTypeConverter<Author, Model.Author>
    {
        protected override Model.Author Convert(Author source)
        {
            throw new NotImplementedException();
        }
    }
}