using System;
namespace  Business.Models
{
    public class PessoaFisica : Entity
	{	
		public int PessoaId { get; set; }
		public int NivelFormacaoId { get; set; }
		public int EstadoCivilId { get; set; }
		public string Cpf { get; set; }
		public string Rg { get; set; }
		public string OrgaoRg { get; set; }
		public DateTime? DataEmissaoRg { get; set; }
		public System.DateTime? DataNascimento { get; set; }
		public string Sexo { get; set; }
		public string Raca { get; set; }
		public string Nacionalidade { get; set; }
		public string Naturalidade { get; set; }
		public string NomePai { get; set; }
		public string NomeMae { get; set; }
		public Pessoa Pessoa { get; set; }
		public NivelFormacao NivelFormacao { get; set; }
		public EstadoCivil EstadoCivil { get; set; }
    }
}
