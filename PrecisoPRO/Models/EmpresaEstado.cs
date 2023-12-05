using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrecisoPRO.Models
{
    [Table("EMPRESA-ESTADO")]
    public class EmpresaEstado
    {

        [Key]
        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }

        [Column("RAZAO_SOCIAL")]
        public string? RazaoSocial { get; set; }

        [Column("FANTASIA")]
        public string? Fantasia { get; set; }

        [Column("ENDERECO")]
        public string? Endereco { get; set; }


        [Column("NUMERO")]
        public string? Numero { get; set; }

        [Column("CIDADE")]
        public string? Cidade { get; set; }

        [Column("CEP")]
        public string? Cep { get; set; }

        [Column("BAIRRO")]
        public string? Bairro { get; set; }

        [Column("PRINCIPAL")]
        public sbyte? Principal { get; set; }

        [Column("ESTADO")]
        public string? Estado { get; set; }

        [Column("IE")]
        public string? InscEstadual { get; set; }

        [Column("CNPJ")]
        public string? Cnpj { get; set; }

        [Column("CELULAR")]
        public string? Celular { get; set; }

        [Column("TELEFONE")]
        public string? Telefone { get; set; }

        [Column("ID_ESTADO")]
        public int? IdEstado { get; set; }

        [Column("NOME_ESTADO")]
        public string? NomeEstado { get; set; }


        [Column("UF_ESTADO")]
        public string? UfEstado { get; set; }

        [Column("BAND_ESTADO")]
        public string? BandeiraEstado { get; set; }






    }
}
