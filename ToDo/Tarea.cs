public class Tarea
{
    public int TareaId { get; set; }
    public string? Descripcion { get; set; }
    public int Duracion { get; set; }
    public Tarea(int tareaId, string descripcion, int duracion)
    {
        TareaId = tareaId;
        Descripcion = descripcion;
        Duracion = duracion;
    }
    public Tarea()
    {
        
    }
}
