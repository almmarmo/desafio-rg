﻿using Contato.Domain;
using Contato.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Contato.Infra.Repository
{
    public class ContatoMemoryRepository : IContatoRepository
    {
        private static List<Domain.Contato> contatos;
        public ContatoMemoryRepository()
        {
            if (contatos == null)
            {
                contatos = new List<Domain.Contato>();
                Seed();
            }
        }

        public void Create(Domain.Contato contato)
        {
            if(contato != null)
                contatos.Add(contato);
        }

        public void Delete(Guid id)
        {
            var contato = contatos.FirstOrDefault(c => c.Id == id);
            if (contato != null)
                contatos.Remove(contato);
        }

        protected void Delete(Domain.Contato contato)
        {
            Delete(contato.Id);
        }

        public Domain.Contato Get(Guid id)
        {
            return contatos.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Domain.Contato> List(int page, int size)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Contato contato)
        {
            var contatoExistente = Get(contato.Id);
            if(contatoExistente != null)
            {
                Delete(contatoExistente);
                contatos.Add(contato);
            }
        }

        private void Seed()
        {
            contatos.Add(new Domain.Contato("Contato 1", "Celular", "923458877", "Teste", "b5e790d0-954e-4408-b70f-74f8eeab0a04"));
        }
    }
}
