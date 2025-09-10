namespace Eventos.Services;

using System.Text.RegularExpressions;

public static class Validaciones
{
    public static string Cadena(string cadena)
    {
        if (string.IsNullOrWhiteSpace(cadena))
            throw new ArgumentNullException(nameof(cadena), "La cadena no puede estar vacía.");
        return cadena.Trim();
    }

    public static int Entero(int numero)
    {
        if (numero < 0)
            throw new ArgumentOutOfRangeException(nameof(numero), "El número debe ser mayor o igual a 0.");
        return numero;
    }

    public static decimal DecimalPositivo(decimal numero)
    {
        if (numero < 0)
            throw new ArgumentOutOfRangeException(nameof(numero), "El número decimal debe ser mayor o igual a 0.");
        return numero;
    }

    public static string Email(string email)
    {
        string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, patron, RegexOptions.IgnoreCase))
            throw new ArgumentException("El email no es válido.", nameof(email));
        return email.Trim();
    }

    public static string Telefono(string telefono)
    {
        string patron = @"^[0-9]{7,15}$"; 
        if (string.IsNullOrWhiteSpace(telefono) || !Regex.IsMatch(telefono, patron))
            throw new ArgumentException("El número de teléfono no es válido.", nameof(telefono));
        return telefono;
    }

    public static DateTime FechaPasada(DateTime fecha)
    {
        if (fecha > DateTime.Now)
            throw new ArgumentException("La fecha no puede ser futura.", nameof(fecha));
        return fecha;
    }

    public static void RangoFechas(DateTime inicio, DateTime fin)
    {
        if (inicio >= fin)
            throw new ArgumentException("La fecha de inicio debe ser menor a la fecha de fin.");
    }

    public static byte Stock(byte cantidad)
    {
        if (cantidad < 0)
            throw new ArgumentOutOfRangeException(nameof(cantidad), "El stock no puede ser negativo.");
        return cantidad;
    }

    public static string Url(string url)
    {
        string patron = @"^(http|https)://";
        if (string.IsNullOrWhiteSpace(url) || !Regex.IsMatch(url, patron))
            throw new ArgumentException("La URL no es válida.", nameof(url));
        return url.Trim();
    }

    public static string Contrasena(string contrasena)
    {
        string patron = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$";
        if (string.IsNullOrWhiteSpace(contrasena) || !Regex.IsMatch(contrasena, patron))
            throw new ArgumentException("La contraseña debe tener al menos 6 caracteres, incluyendo letras y números.", nameof(contrasena));
        return contrasena;
    }
}