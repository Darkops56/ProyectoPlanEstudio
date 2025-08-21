namespace TiendaOnline.Core.Persistencia;

public interface IRepoPais
{
    IEnumerable<Pais> ObtenerPaises();
    void altaPais(Pais pais);
    Pais? DetallePais(uint idPais);
}
