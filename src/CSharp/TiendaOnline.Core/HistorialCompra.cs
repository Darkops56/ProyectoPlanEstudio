namespace TiendaOnline.Core;

public class HistorialCompra
{
    public Producto producto { get; set; }
    public Categoria categoria { get; set; }
    public Pedidos pedidos { get; set; }
    public Usuario usuario { get; set; }
    public Ubicacion ubicacion { get; set; }
    public int precioUnitario { get; set; }
    public DateOnly fecha { get; set; }
}
