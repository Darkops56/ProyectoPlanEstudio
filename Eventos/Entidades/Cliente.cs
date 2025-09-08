using Eventos.Services;

namespace Eventos.Entidades;

public class Cliente
{
    public int DNI { get; set; }
    public string nombreCompleto { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    public string Contrasena { get; set; }

    public Cliente(int DNI, string nombreCompleto, string Email, string Telefono, string Contrasena)
    {
        Validaciones.Cadena(nombreCompleto);
        Validaciones.Email(Email);
        Validaciones.Entero(DNI);
        Validaciones.Cadena(Telefono);

        this.DNI = DNI;
        this.nombreCompleto = nombreCompleto;
        this.Email = Email;
        this.Telefono = Telefono;
        this.Contrasena = Contrasena;
    }
}
