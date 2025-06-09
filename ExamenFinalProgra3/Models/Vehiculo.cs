using System.ComponentModel.DataAnnotations;

namespace ExamenFinalProgra3.Models
{
    public class Vehiculo
    {
        [Required]
        public string? numeroChasis { get; set; }
        [Required]
        public string? marca { get; set; }
        [Required]
        public string? fechaFabricacion { get; set; }

    }
}
