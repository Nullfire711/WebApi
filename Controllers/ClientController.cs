using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.ClientData;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class ClientController : Controller
    {

        private IClientData _clientData;

        public ClientController(IClientData clientData)
        {

            _clientData = clientData;
        }


        [HttpGet]
        [Route("api/[controller]")]

        public IActionResult GetClients()
        {
            return Ok(_clientData.GetClients());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]

        public IActionResult GetClient(Guid id)
        {
            var client = _clientData.GetClient(id);

            if (client != null)
            {
                return Ok(_clientData.GetClient(id));
            }

            return NotFound($"Client with Id: {id} was not found");
        }

        //[HttpGet]
        //[Route("api/[controller]/{date}")]

        //public IActionResult GetDate(DateTime date)
        //{
        //    var client = _clientData.GetDate(date);

        //    if (client != null)
        //    {
        //        return Ok(_clientData.GetDate(date));
        //    }
        //    return NotFound($"Deal with date: {date} was not found");
        //}

        [HttpPost]
        [Route("api/[controller]")]

        public IActionResult AddClient(Client client)
        {
            _clientData.AddClient(client);

            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + client.Id,
                client);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]

        public IActionResult DeleteClient(Guid id)
        {
            var client = _clientData.GetClient(id);

            if (client != null)
            {
                _clientData.DeleteClient(client);
                return Ok();
            }

            return NotFound($"Client with Id: {id} was not found");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]

        public IActionResult EditClient(Guid id, Client client)
        {
            var existingClient = _clientData.GetClient(id);

            if (existingClient != null)
            {
                client.Id = existingClient.Id;
                _clientData.DeleteClient(client);
                return Ok();
            }

            return Ok(client);
        }

    }
}
