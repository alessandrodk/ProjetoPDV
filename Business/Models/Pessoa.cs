using System.Collections.Generic;
namespace  Business.Models
{
    public class Pessoa : Entity
	{	
		public string Nome { get; set; }
		public string Tipo { get; set; }
		public string Site { get; set; }
		public string Email { get; set; }
		public string Cliente { get; set; }
		public string Fornecedor { get; set; }
		public PessoaFisica PessoaFisica { get; set; }
		public PessoaJuridica PessoaJuridica { get; set; }
		public IEnumerable<PessoaContato> ListaPessoaContato { get; set; }
		public IEnumerable<PessoaEndereco> ListaPessoaEndereco { get; set; }
		public IEnumerable<PessoaTelefone> ListaPessoaTelefone { get; set; }
	}
}
