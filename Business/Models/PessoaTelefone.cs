namespace  Business.Models
{
    public class PessoaTelefone : Entity
	{	
		public int PessoaId { get; set; }
		public string Tipo { get; set; }
		public string Numero { get; set; }
		public Pessoa Pessoa { get; set; }
    }
}
