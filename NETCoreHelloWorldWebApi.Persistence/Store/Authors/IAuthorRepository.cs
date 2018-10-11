using System.Collections.Generic;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Persistence.Store.Authors
{
    public interface IAuthorRepository
    {
        Author GetById(int id);

        List<Author> GetByIds(List<int> ids);
    }
}