using System.Collections.Generic;

namespace Business.Models
{
    public class ProdutoGrupo : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        //public IEnumerable<Produto> Produtos { get; set; }
        public IEnumerable<ProdutoSubGrupo> SubGrupos { get; set; }
    }
}
