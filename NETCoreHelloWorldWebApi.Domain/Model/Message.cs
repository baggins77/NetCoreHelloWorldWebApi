
namespace NETCoreHelloWorldWebApi.Domain.Model
{
    public class Message
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public Author Author { get; set; }
    }
}
