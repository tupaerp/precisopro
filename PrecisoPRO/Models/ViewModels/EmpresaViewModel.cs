using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrecisoPRO.Models.ViewModels
{
    public class EmpresaViewModel
    {
        public int Id { get; set; }

        public required string Razao { get; set; }

        public required string Fantasia { get; set; }

        public string? Endereco { get; set; }

        public string? Numero { get; set; }

        public string? Cidade { get; set; }

        public string? UF { get; set; }

        public string? Cep { get; set; }

        public string? Bairro { get; set; }


        public string? Ie { get; set; }


        public required string Cnpj { get; set; }


      
        public string? Celular { get; set; }

       
        public sbyte Status { get; set; }

        public DateTime? Data_Cad { get; set; }

              
        public DateTime? Data_Alt { get; set; }

       
    }
}
