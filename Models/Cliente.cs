namespace ProLivingPrime.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaRegistro { get; set; }
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();
    }
}
