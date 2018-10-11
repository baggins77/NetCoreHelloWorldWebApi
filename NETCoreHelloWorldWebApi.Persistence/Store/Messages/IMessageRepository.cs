using System.Collections.Generic;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Persistence.Store.Messages
{
    public interface IMessageRepository
    {
        List<Message> GetAll();

        Message GetById(int id);
    }
}