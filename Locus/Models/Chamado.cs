using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locus.Models
{
    public class Chamado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DataAbertura { get; set; } = DateTime.UtcNow;

        [Required]
        public string Descricao { get; set; } = string.Empty;

        [Required]
        public StatusChamado Status { get; set; } = StatusChamado.Aberto;

        [Required]
        public int SetorId { get; set; }

        [ForeignKey("SetorId")]
        public Setor? Setor { get; set; }

        public int? EquipamentoId { get; set; }

        [ForeignKey("EquipamentoId")]
        public Equipamento? Equipamento { get; set; }

        [Required]
        public int TipoServicoId { get; set; }

        [ForeignKey("TipoServicoId")]
        public TipoServico? TipoServico { get; set; }
    }
}
