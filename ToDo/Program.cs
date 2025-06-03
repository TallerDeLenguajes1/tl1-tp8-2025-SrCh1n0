// See https://aka.ms/new-console-template for more information

Random random = new Random();
int cantTareas = random.Next(3, 6);

List<Tarea> tareasPendientes = new List<Tarea>();
string descripcion;
int duracion, idRealizado;
for (int i = 0; i < cantTareas; i++)
{
    Console.WriteLine($"Descripcion de la Tarea: ");
    descripcion = Console.ReadLine();
    Console.WriteLine($"Duracion de la tarea: ");
    duracion = Convert.ToInt32(Console.ReadLine());
    tareasPendientes.Add(new Tarea(i + 1, descripcion, duracion));
}

Console.WriteLine($"Tareas Pendientes: ");
foreach (Tarea pendiente in tareasPendientes)
{
    MostrarTarea(pendiente);
}
List<Tarea> tareasRealizadas = new List<Tarea>();

Console.WriteLine($"Id a Realizadas: ");
idRealizado = Convert.ToInt32(Console.ReadLine());

foreach (Tarea pendiente in tareasPendientes)
{
    if (pendiente.TareaId == idRealizado)
    {
        tareasRealizadas.Add(pendiente);
    }
}
tareasPendientes.RemoveAt(idRealizado - 1);

Console.WriteLine($"Tareas Pendientes: ");
foreach (Tarea pendiente in tareasPendientes)
{
    MostrarTarea(pendiente);
}

Console.WriteLine($"Tareas Realizadas: ");
foreach (Tarea realizado in tareasRealizadas)
{
    MostrarTarea(realizado);
}

static void MostrarTarea(Tarea tarea)
{
    Console.WriteLine($"Id: " + tarea.TareaId);
    Console.WriteLine($"Descripcion: " + tarea.Descripcion);
    Console.WriteLine($"Duracion: " + tarea.Duracion);
}