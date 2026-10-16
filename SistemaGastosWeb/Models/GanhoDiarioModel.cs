using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaGastosWeb.Models
{
    public class GanhoDiarioModel
    {
        public int Id { get; set; }

        [ForeignKey("FKUsuario")]
        public int FKUsuario { get; set; }

        public virtual UsuarioModel? Usuario { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorDoDia { get; set; }

        public string? Descricao { get; set; }

        public DateTime Data { get; set; }
    }
}
