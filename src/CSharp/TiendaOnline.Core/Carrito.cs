namespace TiendaOnline.Core;

public class Carrito
{
    public uint idCarrito { get; set; }
    public decimal precioTotal { get; set; }
    public Producto idProducto { get; set; }
    public Usuario idUsuario { get; set; }
}
