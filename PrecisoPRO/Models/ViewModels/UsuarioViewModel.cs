using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PrecisoPRO.Models.ViewModels
{
    public class UsuarioViewModel
    {

        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Login { get; set; }

        public string? Celular { get; set; }
             
        public required string Senha { get; set; }

        public string? ConfirmarSenha { get; set; }

        public required string Email { get; set; }

        public int? EmpresaId { get; set; }

        public Empresa? Empresa { get; set; }

        public IFormFile? Imagem { get; set; }

        public string? URL { get; set; }
                
        public sbyte Status { get; set; }
                
        public DateTime? Data_Cad { get; set; }

        public DateTime? Data_Alt { get; set; }


    }
}
