namespace TiendaOnline.Core;

public class Envios
{
    public Empleado empleado { get; set; }
    public DateTime fechaEnvio { get; set; }
    public Producto producto { get; set; }
    public Envios envios { get; set; }
}
