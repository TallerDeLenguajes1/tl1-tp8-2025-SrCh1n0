// See https://aka.ms/new-console-template for more information

Random random = new Random();
int cantTareas = random.Next(3, 6);

List<Tarea> tareasPendientes = new List<Tarea>();
string descripcion;
int duracion;
for (int i = 0; i < cantTareas; i++)
{

    Console.WriteLine($"Descripcion de la Tarea: ");
    descripcion = Console.ReadLine();
    Console.WriteLine($"Duracion de la tarea: ");
    duracion = Convert.ToInt32(Console.ReadLine());
    tareasPendientes.Add(new Tarea(i + 1, descripcion, duracion));
}
foreach (Tarea pendiente in tareasPendientes)
{
    Console.WriteLine($"Id: " + pendiente.TareaId);
    Console.WriteLine($"Descripcion: " + pendiente.Descripcion);
    Console.WriteLine($"Duracion: " + pendiente.Duracion);
}
List<Tarea> tareasRealizadas = new List<Tarea>();
