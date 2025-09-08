using Eventos.Services;

namespace Eventos.Entidades;

public class Evento
{
    public int idEvento { get; set; }
    public string Nombre { get; set; }
    public TipoEvento tipoEvento { get; set; }
    public DateTime fechaInicio { get; set; }
    public DateTime fechaFin { get; set; }

    public Evento(int idEvento, string Nombre, TipoEvento tipoEvento, DateTime fechaInicio, DateTime fechaFin)
    {
        Validaciones.Cadena(Nombre);
        
        this.idEvento = idEvento;
        this.Nombre = Nombre;
        this.tipoEvento = tipoEvento;
        this.fechaInicio = fechaInicio;
        this.fechaFin = fechaFin;
    }
}
