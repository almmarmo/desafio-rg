using System;

namespace Contrato.Domain
{
    public class Contato
    {
        public Contato(string nome, Canal canal, string valor, string observacao, string id = null)
        {
            Nome = nome;
            Canal = canal;
            Valor = valor;
            Observacao = observacao;
            if (String.IsNullOrEmpty(id))
                Id = Guid.NewGuid();
            else
                Id = Guid.Parse(id);
        }
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Canal Canal { get; set; }
        public string Valor { get; set; }
        public string Observacao { get; set; }


    }
}
