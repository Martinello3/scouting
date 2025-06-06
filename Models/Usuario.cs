using System.ComponentModel.DataAnnotations;
using ScoutingApi.Models.Enums;

namespace ScoutingApi.Models
{
    public class Usuario
    {
        public int Id { get; set; }

         [Required, MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required, MaxLength(100), EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MaxLength(255)]
        public string Senha { get; set; } = string.Empty;

        [Required]
        public Perfil Perfil { get; set; }

        public string? Foto { get; set; }
    }
}