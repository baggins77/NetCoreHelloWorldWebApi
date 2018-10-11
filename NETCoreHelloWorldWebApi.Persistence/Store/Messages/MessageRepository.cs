using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using NETCoreHelloWorldWebApi.Domain.Model;
using NETCoreHelloWorldWebApi.Persistence.Store.Authors;

namespace NETCoreHelloWorldWebApi.Persistence.Store.Messages
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepository;
        private readonly List<Model.Message> _dbMessages;

        public MessageRepository(IMapper mapper, IAuthorRepository authorRepository)
        {
            _mapper = mapper;
            _authorRepository = authorRepository;

            _dbMessages = new List<Model.Message>
            {
                new Model.Message { Id = 1, AuthorId = 1, Title = "My First Message", Content = "This is only a test. Don't worry." },
                new Model.Message { Id = 2, AuthorId = 2, Title = "Just Another Message", Content = "This is only a test. Don't worry." },
                new Model.Message { Id = 3, AuthorId = 5, Title = "The Best Message Ever", Content = "Hello World!" }
            };
        }

        public List<Message> GetAll()
        {
            var entities = _dbMessages;

            var authorIds = _dbMessages.Where(x => x.AuthorId.HasValue).Select(x => x.AuthorId.Value).Distinct().ToList();

            var authorEntities = _authorRepository.GetByIds(authorIds);

            var results = _mapper.Map<List<Message>>(entities);
            var authorResults = _mapper.Map<List<Author>>(authorEntities);

            entities.ForEach(x =>
            {
                if (x.AuthorId.HasValue)
                {
                    var result = results.SingleOrDefault(r => r.Id == x.Id);

                    if (result != null)
                    {
                        result.Author = authorResults.SingleOrDefault(a => a.Id == x.AuthorId);
                    }
                }
            });

            return results;
        }

        public Message GetById(int id)
        {
            //This is done for example purposes only. Normally, this is where we would be doing our data access.
            var entity = _dbMessages.SingleOrDefault(x => x.Id == id);

            var result = _mapper.Map<Message>(entity);

            if (entity?.AuthorId != null)
            {
                result.Author = _authorRepository.GetById(entity.AuthorId.Value);
            }

            return result;
        }
    }
}