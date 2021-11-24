using System;
namespace  Business.Models
{
    public class PessoaJuridica : Entity
    {
        public int PessoaId { get; set; }
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public DateTime? DataConstituicao { get; set; }
        public string TipoRegime { get; set; }
        public string Crt { get; set; }
        public string Cnae { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
