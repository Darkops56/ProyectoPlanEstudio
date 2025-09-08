namespace Eventos.Entidades;

public class Local
{
    public int idLocal { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Ubicacion { get; set; }

    public Local(int idLocal, string Nombre, string Ubicacion)
    {
        this.idLocal = idLocal;
        this.Nombre = Nombre;
        this.Ubicacion = Ubicacion;
    }
}
