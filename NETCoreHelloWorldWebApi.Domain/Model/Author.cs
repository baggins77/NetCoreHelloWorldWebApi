
namespace NETCoreHelloWorldWebApi.Domain.Model
{
    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => CalculateFullName();

        #region Private Methods

        private string CalculateFullName()
        {
            if (!string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName))
            {
                return $"{FirstName} {LastName}";
            }

            return null;
        }

        #endregion Private Methods
    }
}