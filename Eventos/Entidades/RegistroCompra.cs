namespace Eventos.Entidades;

public class RegistroCompra
{
    public int idRegistro { get; set; }
    public int idCliente { get; set; }
    public int idEntrada { get; set; }
    public DateTime Fecha { get; set; }

    public RegistroCompra(int idRegistro, int idCliente, int idEntrada, DateTime Fecha)
    {
        this.idRegistro = idRegistro;
        this.idCliente = idCliente;
        this.idEntrada = idEntrada;
        this.Fecha = Fecha;
    }
    
}
