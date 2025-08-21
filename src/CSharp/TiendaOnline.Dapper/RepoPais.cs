using System.Data;
using TiendaOnline.Core;
using TiendaOnline.Core.Persistencia;
using Dapper;

namespace TiendaOnline.Dapper;

public class RepoPais : Repo, IRepoPais
{
    public RepoPais(IDbConnection conexion) : base(conexion) { }

    public void altaPais(Pais pais)
    {
        var consulta = @"INSERT INTO Pais(idPais, nombre) VALUES(@idpais, @nombre)";
        _conexion.Execute(
            consulta,
            new
            {
                idPais = 10,
                nombre = "sisi"
            }
        );
    }

    public Pais? DetallePais(uint idpais)
    {
        var consulta = @"SELECT * FROM Pais WHERE idPais = @unidpais";
        return _conexion.QueryFirstOrDefault<Pais>(consulta, new { unidpais = idpais });
    }

    public IEnumerable<Pais> ObtenerPaises()
    {
        var consulta = "SELECT * FROM Pais";
        return _conexion.Query<Pais>(consulta).ToList();
    }
}
