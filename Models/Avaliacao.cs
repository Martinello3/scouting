using System.ComponentModel.DataAnnotations;

namespace ScoutingApi.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }
        
        [Required]
        public int JogadorId { get; set; }
        public Jogador Jogador { get; set; } = null!;

        [Required]
        public int AvaliadorId { get; set; }
        public Usuario Avaliador { get; set; } = null!;

        [Required]
        public DateTime Data { get; set; }

        public int ControleBola { get; set; }
        public int Passe { get; set; }
        public int Finalizacao { get; set; }
        public int Drible { get; set; }
        public int Posicionamento { get; set; }
        public int LeituraJogo { get; set; }
        public int TomadaDecisao { get; set; }
        public int Velocidade { get; set; }
        public int Resistencia { get; set; }
        public int Forca { get; set; }
        public int Disciplina { get; set; }
        public int Lideranca { get; set; }
        public int Proatividade { get; set; }
        public int InteligenciaEmocional { get; set; }

        [MaxLength(255)]
        public string? Comentarios { get; set; }
    }
}