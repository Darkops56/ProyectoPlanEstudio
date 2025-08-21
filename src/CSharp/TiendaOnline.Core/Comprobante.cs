namespace TiendaOnline.Core;

public class Comprobante
{
    public uint idComprobante { get; set; }
    public Pedidos pedidos { get; set; }
    public Usuario usuario { get; set; }
    public DateOnly fecha { get; set; }
    public string formaPago { get; set; }
    public string estadoPago { get; set; }
    public int montoTotal { get; set; }
}
