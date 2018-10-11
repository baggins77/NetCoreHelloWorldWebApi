using AutoMapper;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Mapping
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            //Inbound Mapping
            //CreateMap<ServiceModel.Author, Author>().ConvertUsing<Inbound.AuthorToAuthorConverter>();
            //CreateMap<ServiceModel.Message, Message>().ConvertUsing<Inbound.MessageToMessageConverter>();

            //Outbound Mapping
            CreateMap<Author, ServiceModel.Author>().ConvertUsing<Outbound.AuthorToAuthorConverter>();
            CreateMap<Message, ServiceModel.Message>().ConvertUsing<Outbound.MessageToMessageConverter>();
        }
    }
}
