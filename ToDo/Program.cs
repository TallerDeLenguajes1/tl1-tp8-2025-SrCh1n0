using System;
using System.IO;
using System.IO.Compression;

List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();

int id = 1, opcion, duracion;
string? descripcion;
do
{
    Console.WriteLine("--- Menu ---\n1- Cargar Nuevas tareas\n2- Marcar como Realizada\n3- Buscar Tarea\n4- Mostrar Lista de Pendientes\n5- Mostrar Lista de Realizadas\n0- Salir");
    int.TryParse(Console.ReadLine(), out opcion);
    switch (opcion)
    {
        case 1:
            crearTareas(tareasPendientes, id);
            break;
        case 2:
            moverTareas(tareasPendientes, tareasRealizadas);
            break;
        case 3:
            /* buscarTarea(tareasPendientes); */
            break;
        case 4:
            Console.WriteLine($"Tareas Pendientes: ");
            mostrarLista(tareasPendientes);
            break;
        case 5:
            Console.WriteLine($"Tareas Realizadas: ");
            mostrarLista(tareasRealizadas);
            break;
        default:
            Console.WriteLine("Saliendo");
            break;
    }
} while (opcion != 0);


void crearTareas(List<Tarea> tareas, int id )
{
    Random rand = new Random();
    int cantTareas = rand.Next(3, 6);
    for (int i = 0; i < cantTareas; i++)
    {
        Console.WriteLine($"Duracion de la tarea: ");
        duracion = Convert.ToInt32(Console.ReadLine());
        if (duracion > 100 || duracion < 10)
        {
            do
            {
                Console.WriteLine("La duracion de la tarea tiene que estar entre 100 y 10");
                Console.WriteLine("Ingrese nuevamente la duracion de la tarea:");
                duracion = Convert.ToInt32(Console.ReadLine());
            } while (duracion > 100 || duracion < 10);
        }

        Console.WriteLine($"Descripcion de la Tarea {id}: ");
        descripcion = Console.ReadLine();

        tareas.Add(new Tarea(i + 1, descripcion, duracion));
        id++;
    }
}

void moverTareas(List<Tarea> pendientes, List<Tarea> realizadas)
{
    Console.WriteLine("Que tarea desea marcar como realizada (ingresar ID):");
    int id;
    id = Convert.ToInt32(Console.ReadLine());

    foreach (Tarea tarea in pendientes)
    {
        if (tarea.TareaId == id)
        {
            realizadas.Add(tarea);
        }
    }
    pendientes.RemoveAt(id - 1);
}

static void MostrarTarea(Tarea tarea)
{
    Console.WriteLine($"Id: " + tarea.TareaId);
    Console.WriteLine($"Descripcion: " + tarea.Descripcion);
    Console.WriteLine($"Duracion: " + tarea.Duracion);
}

void mostrarLista(List<Tarea> lista){
    foreach (Tarea tarea in lista)
    {
        MostrarTarea(tarea);
        Console.WriteLine("---------");
    }
}