namespace TiendaOnline.Core;

public class DetalleVenta
{
    public uint idDetalleVenta { get; set; }
    public Venta venta { get; set; }
    public Producto producto { get; set; }
    public uint cantidad { get; set; }
    public uint precioUnitario { get; set; }
}
