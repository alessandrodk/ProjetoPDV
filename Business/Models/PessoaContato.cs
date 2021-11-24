namespace  Business.Models
{
    public class PessoaContato : Entity
	{	
		public int PessoaId { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Observacao { get; set; }
		public Pessoa Pessoa { get; set; }
    }
}
