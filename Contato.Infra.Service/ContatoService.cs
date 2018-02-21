﻿using Contrato.Domain;
using Contrato.Domain.Repository;
using Contrato.Domain.Service;
using System;
using System.Collections.Generic;

namespace Contato.Infra.Service
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
        {
            this.contatoRepository = contatoRepository;
        }

        public void Delete(Guid id)
        {
            contatoRepository.Delete(id);
        }

        public Contrato.Domain.Contato Get(Guid id)
        {
            return contatoRepository.Get(id);
        }

        public IEnumerable<Contrato.Domain.Contato> List(int page, int size)
        {
            throw new NotImplementedException();
        }

        public void Update(Contrato.Domain.Contato contato)
        {
            contatoRepository.Update(contato);
        }
    }
}