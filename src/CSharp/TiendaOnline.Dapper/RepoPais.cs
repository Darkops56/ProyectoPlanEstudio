using System.Data;
using TiendaOnline.Core;
using TiendaOnline.Core.Persistencia;
using Dapper;
using System.ComponentModel.Design;

namespace TiendaOnline.Dapper;

public class RepoPais : Repo, IRepoPais
{
    public RepoPais(IDbConnection conexion) : base(conexion) { }

    public void altaPais(Pais pais)
    {
        var Consulta = @"INSERT INTO Pais VALUES(@Nombre, @unidPais)";
        _conexion.Execute(
            Consulta, new
            {
                unidPais = pais.idPais,
                Nombre = pais.nombre
            }
        );
    }

    public Pais? DetallePais(uint idPais)
    {
        var Consulta = @"SELECT* FROM Pais Where idPais = @unidPais LIMIT 1";
        return _conexion.QueryFirstOrDefault(Consulta, new
        {
            unidPais = idPais
        });
    }

    public IEnumerable<Pais> ObtenerPaises()
    {
        var Consulta = @"SELECT* FROM Pais";
        return _conexion.Query<Pais>(Consulta).ToList();
    }
    
}
