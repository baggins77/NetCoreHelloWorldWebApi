using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NETCoreHelloWorldWebApi.Domain.Model;

namespace NETCoreHelloWorldWebApi.Tests
{
    [TestClass]
    public class AuthorName
    {
        private readonly Author _author;

        public AuthorName()
        {
            _author = new Author
            {
                FirstName = "Jim",
                LastName = "Bob"
            };
        }

        [TestMethod]
        public void FullNameIsValid()
        {
            var fullName = _author.FullName;
            
            var nameRegex = new Regex(@"^[A-Za-z]{1,}[\.]{0,1} [A-Za-z]{0,}$");

            var regexMatch = nameRegex.IsMatch(fullName);

            Assert.IsTrue(regexMatch, "Full name should match regex");
        }
    }
}
