using System.ComponentModel.DataAnnotations;

namespace Locus.Models
{
    public class Setor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        public ICollection<Equipamento> Equipamentos { get; set; } = new List<Equipamento>();
        public ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();
    }
}
