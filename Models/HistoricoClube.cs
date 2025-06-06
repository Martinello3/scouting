using System.ComponentModel.DataAnnotations;

namespace ScoutingApi.Models
{
    public class HistoricoClube
    {
        public int Id { get; set; }

        [Required]
        public int JogadorId { get; set; }
        public Jogador Jogador { get; set; } = null!;

        [Required]
        public int ClubeId { get; set; }
        public Clube Clube { get; set; } = null!;
        public DateTime? DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }

        [MaxLength(255)]
        public string? Observacoes { get; set; }
    }
}
