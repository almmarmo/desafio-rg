using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contato.Application.Service;
using Contato.Application.Service.Messages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contato.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/contato")]
    public class ContatoController : Controller
    {
        private readonly IContatoApplicationService contatoApplicationService;

        public ContatoController(IContatoApplicationService contatoApplicationService)
        {
            this.contatoApplicationService = contatoApplicationService;
        }
        [HttpGet]
        [Route("{idContato}")]
        public IActionResult Get(string idContato)
        {
            var response = contatoApplicationService.Get(idContato);
            if (response == null)
                return NotFound("Contato não encontrado.");
            else
                return Ok(response);
        }

        [HttpPut]
        [Route("{idContato}")]
        public IActionResult Update(string idContato, [FromBody] ContatoUpdateRequest request)
        {
            return NoContent();
        }

        [HttpPost]
        [Route("")]
        public IActionResult Create([FromBody] ContatoCreateRequest request)
        {
            return Created("", "");
        }
    }
}