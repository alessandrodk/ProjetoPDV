using System;

namespace  Business.Models
{
    public class Fornecedor : Entity
	{	
		public int PessoaId { get; set; }
		public DateTime? Desde { get; set; }
		public DateTime? DataCadastro { get; set; }
		public string Observacao { get; set; }
		public Pessoa Pessoa { get; set; }
    }
}
