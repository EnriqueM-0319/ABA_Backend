using aba_backend.Models.Enums;

namespace aba_backend.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public RolUsuario Rol { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow; 
        public IColletion<Ticket>? Tickets { get; set; }

    }
}