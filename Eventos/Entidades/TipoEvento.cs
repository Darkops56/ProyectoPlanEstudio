namespace Eventos.Entidades;

public class TipoEvento
{
    public int idTipoEvento { get; set; }
    public string tipoEvento { get; set; }
    public TipoEvento(int idTipoEvento, string tipoEvento)
    {
        this.idTipoEvento = idTipoEvento;
        this.tipoEvento = tipoEvento;
    }
}
