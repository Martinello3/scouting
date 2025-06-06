using System.ComponentModel.DataAnnotations;

namespace ScoutingApi.Models
{
    public class Jogador
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        public DateTime DataNascimento { get; set; }

        [MaxLength(50)]
        public string? Nacionalidade { get; set; }

        [MaxLength(50)]
        public string? Posicao { get; set; }
        public decimal? Altura { get; set; }
        public decimal? Peso { get; set; }

        [MaxLength(10)]
        public string? PeDominante { get; set; }
        public int? ClubeAtualId { get; set; }
        public Clube? ClubeAtual { get; set; }
        public string? Foto { get; set; }

        [MaxLength(255)]
        public string? Observacoes { get; set; }
    }
}