using System.ComponentModel.DataAnnotations;

namespace ScoutingApi.Models
{
    public class Relatorio
    {
        public int Id { get; set; }

        [Required]
        public int JogadorId { get; set; }
        public Jogador Jogador { get; set; } = null!;

        [Required]
        public int AvaliacaoId { get; set; }
        public Avaliacao Avaliacao { get; set; } = null!;

        [MaxLength(255)]
        public string CaminhoPdf { get; set; } = string.Empty;
        public DateTime DataGeracao { get; set; } = DateTime.Now;
    }
}