using System.ComponentModel.DataAnnotations;

namespace ExamenFinalProgra3.Models
{
    public class Camion: Vehiculo
    {
        [Required]
        public string? capacidadCarga {  get; set; }
        [Required]
        public string? cantidadLlantas { get; set; }

    }
}
