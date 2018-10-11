using System.Collections.Generic;
using System.Linq;

namespace NETCoreHelloWorldWebApi.ServiceModel.Exchange
{
    public class SaveMessage : RequestBase
    {
        public Message Message { get; set; }

        //This is just for the purpose of this example. This should be split out to its own validator using something like Fluent Validation.
        protected override bool Validate()
        {
            Errors = new Dictionary<string, string>();

            if (Message == null)
            {
                Errors.Add("Message", "Message is required.");
            }

            return !Errors.Any();
        }
    }
}