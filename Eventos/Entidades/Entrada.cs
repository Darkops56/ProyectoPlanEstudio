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
    //Métodos
        public void AplicarDescuento(int porcentaje)
    {
        if (porcentaje > 0 && porcentaje <= 100)
            Precio -= (Precio * porcentaje) / 100;
    }

    public string MostrarDetalle()
    {
        return $"Entrada {idEntrada} - Evento: {evento.Nombre} - Precio: ${Precio} - Tarifa: {tarifa.Tipo}";
    }
}
