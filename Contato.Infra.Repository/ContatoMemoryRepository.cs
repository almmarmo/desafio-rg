using Contrato.Domain;
using Contrato.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Contrato.Infra.Repository
{
    public class ContatoMemoryRepository : IContatoRepository
    {
        private static List<Contato> contatos;
        public ContatoMemoryRepository()
        {
            contatos = new List<Contato>();
            Seed();
        }

        public void Create(Contato contato)
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

        protected void Delete(Contato contato)
        {
            Delete(contato.Id);
        }

        public Contato Get(Guid id)
        {
            return contatos.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Contato> List(int page, int size)
        {
            throw new NotImplementedException();
        }

        public void Update(Contato contato)
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
            contatos.Add(new Contato("Contato 1", Canal.Celular, "923458877", "Teste", "b5e790d0-954e-4408-b70f-74f8eeab0a04"));
        }
    }
}
