using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locus.Models
{
    public class Equipamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Tipo { get; set; } = string.Empty; // Agora é uma string flexível

        public string? Modelo { get; set; }

        [Required]
        public int SetorId { get; set; }

        [ForeignKey("SetorId")]
        public Setor? Setor { get; set; }

        public ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();
    }
}
