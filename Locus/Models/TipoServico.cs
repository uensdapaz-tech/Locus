using System.ComponentModel.DataAnnotations;

namespace Locus.Models
{
    public class TipoServico
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; } = string.Empty;

        public ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();
    }
}
