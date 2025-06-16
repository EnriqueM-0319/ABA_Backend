using aba_backend.Models.Enums;

namespace aba_backend.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public FormaPago FormaPago { get; set; }

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public ICollection<TicketDetalle>? Detalles { get; set; }
    }
}