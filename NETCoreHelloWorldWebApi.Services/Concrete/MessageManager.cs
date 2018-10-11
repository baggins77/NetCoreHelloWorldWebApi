using System.Collections.Generic;
using NETCoreHelloWorldWebApi.Domain.Model;
using NETCoreHelloWorldWebApi.Persistence.Store.Messages;
using NETCoreHelloWorldWebApi.Services.Interfaces;

namespace NETCoreHelloWorldWebApi.Services.Concrete
{
    public class MessageManager : IMessageManager
    {
        private readonly IMessageRepository _messageRepository;

        public MessageManager(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }

        public List<Message> GetAll()
        {
            return _messageRepository.GetAll();
        }

        public Message GetById(int id)
        {
            return _messageRepository.GetById(id);
        }
    }
}