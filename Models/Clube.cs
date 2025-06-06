using System.ComponentModel.DataAnnotations;

namespace ScoutingApi.Models
{
    public class Clube
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Cidade { get; set; }

        [MaxLength(50)]
        public string? Estado { get; set; }

        [MaxLength(50)]
        public string? Pais { get; set; }
    }
}