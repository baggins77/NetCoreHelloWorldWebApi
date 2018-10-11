using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NETCoreHelloWorldWebApi.ServiceModel;
using NETCoreHelloWorldWebApi.ServiceModel.Exchange;
using NETCoreHelloWorldWebApi.Services.Interfaces;

namespace NETCoreHelloWorldWebApi.Controllers
{
    [Route("api/messages")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageManager _messageManager;
        private readonly IMapper _mapper;

        public MessagesController(IMessageManager messageManager, IMapper mapper)
        {
            _messageManager = messageManager;
            _mapper = mapper;
        }

        // GET api/messages
        [HttpGet]
        public IActionResult Get()
        {
            var domainMessages = _messageManager.GetAll();
            return Ok(_mapper.Map<List<Message>>(domainMessages));
        }

        // GET api/messages/3 -- this will get Hello World! by William Shakespeare
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var domainMessage = _messageManager.GetById(id);
            return Ok(_mapper.Map<Message>(domainMessage));
        }

        // POST api/messages
        [HttpPost]
        public IActionResult Post([FromBody] SaveMessage request)
        {
            /*
            if (!request.IsValid)
            {
                return BadRequest(request.Errors);
            }

            //Convert to domain model
            //Call manager to save
            //Covnert response to save to service model for response

            return Ok( new Message { Title = "Test", Content = "This is just a test." } );
            */
            throw new NotImplementedException();
        }

        // PUT api/messages/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/messages/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
