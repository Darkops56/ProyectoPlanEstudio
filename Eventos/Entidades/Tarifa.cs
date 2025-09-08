namespace Eventos.Entidades;

public class Tarifa
{
    public int idTarifa { get; set; }
    public byte Stock { get; set; }
    public string Tipo { get; set; }

    public Tarifa(int idTarifa, byte Stock, string Tipo)
    {
        this.idTarifa = idTarifa;
        this.Stock = Stock;
        this.Tipo = Tipo;
    }
}
