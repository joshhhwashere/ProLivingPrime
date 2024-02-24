namespace ProLivingPrime.Models
{
    public class PedidoDetalle
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal Precio { get; set; }
    }
}
