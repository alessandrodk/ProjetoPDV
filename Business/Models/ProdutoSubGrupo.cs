using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  Business.Models
{
	public class ProdutoSubGrupo : Entity
	{
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public int ProdutoGrupoId { get; set; }
		public ProdutoGrupo ProdutoGrupo { get; set; }
		public IEnumerable<Produto> Produtos { get; set; }
	}
}
