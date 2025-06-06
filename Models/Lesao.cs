using System.ComponentModel.DataAnnotations;
using ScoutingApi.Models.Enums;

namespace ScoutingApi.Models
{
    public class Lesao
    {
        public int Id { get; set; }
        
        [Required]
        public int JogadorId { get; set; }
        public Jogador Jogador { get; set; } = null!;

        [Required, MaxLength(255)]
        public string Descricao { get; set; } = string.Empty;

        [Required]
        public DateTime DataOcorrencia { get; set; }
        public DateTime? DataRecuperacao { get; set; }

        [Required]
        public TipoLesao TipoLesao { get; set; }

        [Required]
        public LocalCorpo LocalCorpo { get; set; }

        [MaxLength(255)]
        public string? Observacoes { get; set; }
    }
}