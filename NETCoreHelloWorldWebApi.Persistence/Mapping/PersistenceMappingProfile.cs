using AutoMapper;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Persistence.Mapping
{
    public class PersistenceMappingProfile : Profile
    {
        public PersistenceMappingProfile()
        {
            //Inbound Mapping
            CreateMap<Author, Model.Author>().ConvertUsing<Inbound.AuthorToAuthorConverter>();
            CreateMap<Message, Model.Message>().ConvertUsing<Inbound.MessageToMessageConverter>();

            //Outbound Mapping
            CreateMap<Model.Author, Author>().ConvertUsing<Outbound.AuthorToAuthorConverter>();
            CreateMap<Model.Message, Message>().ConvertUsing<Outbound.MessageToMessageConverter>();
        }
    }
}