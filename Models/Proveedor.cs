namespace aba_backend.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        

        public ICollection<Producto>? Productos { get; set; }
    }

}