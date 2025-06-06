using System.ComponentModel.DataAnnotations;

namespace ScoutingApi.Models
{
    public class Video
    {
        public int Id { get; set; }

        [Required]
        public int JogadorId { get; set; }
        public Jogador Jogador { get; set; } = null!;

        [MaxLength(255)]
        public string CaminhoVideo { get; set; } = string.Empty;
        public DateTime DataEnvio { get; set; } = DateTime.Now;

        [MaxLength(255)]
        public string? Marcacoes { get; set; }
    }
}