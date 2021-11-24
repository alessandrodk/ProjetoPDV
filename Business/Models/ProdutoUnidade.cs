using System.Collections.Generic;

namespace Business.Models
{
    public class ProdutoUnidade : Entity
	{
		public string Sigla { get; set; }
		public string Descricao { get; set; }
		public string PodeFracionar { get; set; }
		public IEnumerable<Produto> Produtos { get; set; }
	}
}
