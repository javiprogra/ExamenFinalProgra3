using System.ComponentModel.DataAnnotations;

namespace ExamenFinalProgra3.Models
{
    public class Motocicleta : Vehiculo
    {
        [Required]
        public string? cilindrada { get; set; }
        [Required]
        public string? tipo { get; set; }

    }
}
