using System;

namespace Business.Models
{
    public class Produto : Entity
	{
		public int? TributoIcmsCustomCabId { get; set; }
		public int? TributoGrupoTributarioId { get; set; }
		public string Nome { get; set; }
		public string Descricao { get; set; }
		public string Gtin { get; set; }
		public string CodigoInterno { get; set; }
		public decimal? ValorCompra { get; set; }
		public decimal? ValorVenda { get; set; }
		public string CodigoNcm { get; set; }
		public decimal? EstoqueMinimo { get; set; }
		public decimal? EstoqueMaximo { get; set; }
		public decimal? QuantidadeEstoque { get; set; }
		public DateTime? DataCadastro { get; set; }
		public byte[] Foto { get; set; }

		//[Display(Name = "Produto Grupo Id")]
		//public int ProdutoGrupoId { get; set; }
		//public ProdutoGrupo ProdutoGrupo { get; set; }
		public int ProdutoSubGrupoId { get; set; }
		public ProdutoSubGrupo ProdutoSubGrupo { get; set; }
		public int ProdutoMarcaId { get; set; }
		public ProdutoMarca ProdutoMarca { get; set; }
		public int ProdutoUnidadeId { get; set; }
		public ProdutoUnidade ProdutoUnidade { get; set; }
		public TributoIcmsCustomCab TributoIcmsCustomCab { get; set; }
		public TributoGrupoTributario TributoGrupoTributario { get; set; }
	}
}
