using Tarea;

List<Tareas> tareasPendientes = new List<Tareas>();
List<Tareas> tareasRealizadas = new List<Tareas>();
Random random = new Random();
int n = random.Next(1,20);
string tareaBuscar;

tareasPendientes = crearTareasPendientes(n);
mostrarTareas(tareasPendientes);
moverTareas(tareasPendientes, tareasRealizadas);

Console.WriteLine("Ingrese la tarea a buscar");
tareaBuscar = Console.ReadLine();
buscarTarea(tareasPendientes, tareaBuscar);

static List<Tareas> crearTareasPendientes(int n)
{

    List<Tareas> tareas = new List<Tareas>();
    for (int i = 0; i < n; i++)
    {
        Tareas tarea = new Tareas(i+1, $"Tarea Pendiente {i+1}",20,estadoTarea.Pendiente);
        tareas.Add(tarea);
    }
    return tareas;
}

static void mostrarTareas(List<Tareas> tareasPendientes)
{
    foreach (var elementos in tareasPendientes)
    {
        Console.WriteLine(elementos.TareaID);
        Console.WriteLine(elementos.Descripcion);
        Console.WriteLine(elementos.Duracion);
        Console.WriteLine(elementos.Estado);
    }
}

static void moverTareas(List<Tareas> tareasPendientes, List<Tareas> tareasRealizadas)
{
    foreach (var elementos in tareasPendientes)
    {
        elementos.Estado = estadoTarea.Realizada;
        tareasRealizadas.Add(elementos);
    }
}

static void buscarTarea(List<Tareas> tareasPendientes, string tareaBuscar)
{
    foreach (var tareaP in tareasPendientes)
    {
        if(tareaP.Descripcion == tareaBuscar)
        {
            Console.WriteLine($"El numero de la tarea buscada es: {tareaP.TareaID} ");
        }
    }
}


