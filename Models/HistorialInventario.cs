using aba_backend.Models.Enums;
namespace aba_backend.Models
{
    public class HistorialInventario
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }

        public TipoMovimiento TipoMovimiento { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string? Comentario { get; set; }
        
    }
}