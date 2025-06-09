using System.ComponentModel.DataAnnotations;

namespace ExamenFinalProgra3.Models
{
    public class Automovil: Vehiculo
    {
        [Required]
        public string? numeroPuertas {  get; set; }
        [Required]
        public string? tipoCombustible { get; set; }

    }
}
