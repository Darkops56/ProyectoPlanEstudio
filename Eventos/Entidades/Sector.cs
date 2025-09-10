namespace Eventos.Entidades;

public class Sector
{
    public int idSector { get; set; }
    public Local local { get; set; }
    public byte capacidad { get; set; }
    public List<Evento> Eventos { get; set; } = new List<Evento>();

    public Sector(int idSector, Local local, byte capacidad)
    {
        this.idSector = idSector;
        this.local = local;
        this.capacidad = capacidad;
    }

        // Métodos
    public void AgregarEvento(Evento evento)
    {
        Eventos.Add(evento);
    }

    public bool TieneDisponibilidad()
    {
        return capacidad > 0;
    }
}