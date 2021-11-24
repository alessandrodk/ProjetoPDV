namespace  Business.Models
{
    public class PessoaEndereco : Entity
	{	
		public int PessoaId { get; set; }
		public string Logradouro { get; set; }
		public string Numero { get; set; }
		public string Bairro { get; set; }
		public int MunicipioIbge { get; set; }
		public string Uf { get; set; }
		public string Cep { get; set; }
		public string Cidade { get; set; }
		public string Complemento { get; set; }
		public string Principal { get; set; }
		public string Entrega { get; set; }
		public string Cobranca { get; set; }
		public string Correspondencia { get; set; }
		public Pessoa Pessoa { get; set; }
    }
}
