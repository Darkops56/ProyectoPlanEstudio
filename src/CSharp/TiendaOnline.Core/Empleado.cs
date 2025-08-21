namespace TiendaOnline.Core;

public class Empleado
{
    public required uint idEmpleado { get; set; }
    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public string Puesto { get; set; }
    public DateTime fechaIngreso { get; set; }
    public DateTime contrato { get; set; }
    public uint salario { get; set; }

}
