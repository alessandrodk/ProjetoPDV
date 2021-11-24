using System;
namespace  Business.Models
{
    public class Cliente : Entity
	{	
		public int PessoaId { get; set; }
		public DateTime? Desde { get; set; }
		public DateTime? DataCadastro { get; set; }
		public decimal? TaxaDesconto { get; set; }
		public decimal? LimiteCredito { get; set; }
		public string Observacao { get; set; }
		public Pessoa Pessoa { get; set; }
    }
}
