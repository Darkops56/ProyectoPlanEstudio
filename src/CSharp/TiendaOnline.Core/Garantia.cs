namespace TiendaOnline.Core;

public class Garantia
{
    public uint idGarantia { get; set; }
    public string nombre { get; set; }
    public string tipoGarantia { get; set; }
    public DateTime caducidad { get; set; }
    public string condiciones { get; set; }
}
