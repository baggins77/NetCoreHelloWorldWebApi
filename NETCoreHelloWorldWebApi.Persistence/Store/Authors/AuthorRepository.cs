using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Persistence.Store.Authors
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly List<Model.Author> _dbAuthors;
        private readonly IMapper _mapper;

        public AuthorRepository(IMapper mapper)
        {
            _mapper = mapper;

            _dbAuthors = new List<Model.Author>
            {
                new Model.Author{ Id = 1, FirstName = "Mark", LastName = "Twain"},
                new Model.Author{ Id = 2, FirstName = "Charles", LastName = "Dickens"},
                new Model.Author{ Id = 3, FirstName = "Ernest", LastName = "Hemingway"},
                new Model.Author{ Id = 4, FirstName = "George", LastName = "Orwell"},
                new Model.Author{ Id = 5, FirstName = "William", LastName = "Shakespeare"}
            };
        }

        public Author GetById(int id)
        {
            //This is done for example purposes only. Normally, this is where we would be doing our data access.
            var entity = _dbAuthors.SingleOrDefault(x => x.Id == id);

            return _mapper.Map<Author>(entity);
        }

        public List<Author> GetByIds(List<int> ids)
        {
            var entities = _dbAuthors.Where(x => ids.Contains(x.Id));

            return _mapper.Map<List<Author>>(entities);
        }
    }
}