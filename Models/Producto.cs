namespace aba_backend.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal PrecioBase { get; set; }
        public decimal PrecioPublico { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Stock { get; set; }

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        public int ProveedorId { get; set; }
        public Proveedor? Proveedor { get; set; }

        public ICollection<TicketDetalle>? Detalles { get; set; }
        public ICollection<HistorialInventario>? HistorialInventarios { get; set; }
    }
}