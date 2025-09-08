using Eventos.Services;

namespace Eventos.Entidades;

public class Entrada
{
    public int idEntrada { get; set; }
    public int Precio { get; set; }
    public Evento evento { get; set; }
    public Tarifa tarifa { get; set; }

    public Entrada(int idEntrada, int Precio, Evento evento, Tarifa tarifa)
    {
        Validaciones.Entero(Precio);

        this.idEntrada = idEntrada;
        this.Precio = Precio;
        this.evento = evento;
        this.tarifa = tarifa;
    }
}
