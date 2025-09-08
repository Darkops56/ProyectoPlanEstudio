namespace Eventos.Entidades;

public class Sector
{
    public int idSector { get; set; }
    public Local local { get; set; }
    public byte capacidad { get; set; }

    public Sector(int idSector, Local local, byte capacidad)
    {
        this.idSector = idSector;
        this.local = local;
        this.capacidad = capacidad;
    }
}
