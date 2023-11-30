using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrecisoPRO.Models
{
    [Table("ESTADO")]
    public class Estado
    {
        [Key]
        public int ID { get; set; }

        [Column("ESTADO")]
        public string Descricao { get; set; }

        [Column("UF")]
        public string Uf { get; set; }
    }
}
