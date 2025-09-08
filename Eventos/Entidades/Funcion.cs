namespace Eventos.Entidades;

public class Funcion
{
    public int idFuncion { get; set; }
    public Evento evento { get; set; }
    public DateTime fecha { get; set; }

    public Funcion(int idFuncion, Evento evento, DateTime fecha)
    {
        this.idFuncion = idFuncion;
        this.evento = evento;
        this.fecha = fecha;
    }
}
