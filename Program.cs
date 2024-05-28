using Tarea;
Console.WriteLine("Hello, World!");

List<Tareas> tareasPendientes = new List<Tareas>();
List<Tareas> tareasRealizadas = new List<Tareas>();

Random random = new Random();

int n = random.Next(1,20);

for (int i = 0; i < n; i++)
{
    Tareas tarea = new Tareas(i, $"Tarea Pendiente {i+1}",20,estadoTarea.Pendiente);
    tareasPendientes.Add(tarea);
}

foreach (Tareas mostrarTarea in tareasPendientes)
{
    Console.WriteLine(mostrarTarea.Descripcion);
}

moverTareas(tareasPendientes,tareasRealizadas);


static void moverTareas(List<Tareas> tareasPendientes,List<Tareas> tareasRealizadas)
{
    foreach (Tareas buscar in tareasPendientes)
    {
        tareasRealizadas.Add(buscar);
        tareasPendientes.Remove(buscar);
    }
}






