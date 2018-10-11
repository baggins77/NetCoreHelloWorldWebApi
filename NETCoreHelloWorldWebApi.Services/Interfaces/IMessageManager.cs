using System.Collections.Generic;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Services.Interfaces
{
    public interface IMessageManager
    {
        List<Message> GetAll();

        Message GetById(int id);
    }
}