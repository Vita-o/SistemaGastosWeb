using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaGastosWeb.Models
{
    public class UsuarioModel
    {

        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public required string Senha { get; set; }
    }
}
