using System.Data;

namespace TiendaOnline.Dapper;

abstract public class Repo
{
    protected IDbConnection _conexion { get; private set; }
    public Repo(IDbConnection conexion) => _conexion = conexion;
}
