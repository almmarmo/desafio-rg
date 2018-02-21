using System;
using System.Net.Http;
using Contato.Application.Service.Messages;
using Contrato.Domain.Service;
using Newtonsoft.Json;

namespace Contato.Application.Service
{
    public class ContatoApplicationService : IContatoApplicationService
    {
        private readonly IContatoService contatoService;

        public ContatoApplicationService(IContatoService contatoService)
        {
            this.contatoService = contatoService;
        }

        public ContatoGetResponseMessage Get(string id)
        {
            var contato = contatoService.Get(Guid.Parse(id));

            ContatoGetResponseMessage response = null;
            if(contato != null)
            {
                response = new ContatoGetResponseMessage();
                response.Canal = contato.Canal.ToString();
                response.Id = contato.Id;
                response.Nome = contato.Nome;
                response.Observacao = contato.Observacao;
                response.Valor = contato.Valor;
            }

            return response;
        }
    }
}
