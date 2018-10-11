namespace NETCoreHelloWorldWebApi.Persistence.Model
{
    public class Message : Entity
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public int? AuthorId { get; set; }

        //This attribute theoretically tells the persistence layer to ignore this property when doing data access for this entity. It is here so we can set it after fetching, but before mappign out to the domain.
        [Ignore]
        public Author Author { get; set; }
    }
}