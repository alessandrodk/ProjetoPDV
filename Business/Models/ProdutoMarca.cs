using System.Collections.Generic;

namespace Business.Models
{
    public class ProdutoMarca : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
