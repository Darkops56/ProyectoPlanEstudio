namespace TiendaOnline.Core;

public class Comentario
{
    public uint idComentario { get; set; }
    public Usuario usuario { get; set; }
    public Valoracion valoracion { get; set; }
    public string comentario { get; set; }
}
