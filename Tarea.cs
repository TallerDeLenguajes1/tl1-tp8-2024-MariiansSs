namespace Tarea;

public class Tareas
{
    private int tareaID;

    private string descripcion;

    private int duracion;

    private estadoTarea estado;

    public int TareaID
    {
        get
        {
            return tareaID;
        }
        set
        {
            tareaID = value;
        }
    }

    public string Descripcion
    {
        get
        {
            return descripcion;
        }
        set
        {
            descripcion = value;
        }
    }

    public int Duracion
    {
        get
        {
            return duracion;
        }
        set
        {
            duracion = value;
        }
    }

    public estadoTarea Estado { get => estado; set => estado = value; }

    public Tareas(int tareaID, string descripcion, int duracion, estadoTarea estadoDeTarea)
    {
        this.tareaID = tareaID;
        this.descripcion = descripcion;
        this.duracion = duracion;
        Estado = estadoDeTarea;
    }

}

public enum estadoTarea
{
    Pendiente,
    Realizada,
}