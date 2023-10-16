using System.ComponentModel.DataAnnotations;

namespace MateoJijon_EjercicioEnClase2.Models
{
    public class Cita
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool Especialidad { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }
    }
}
