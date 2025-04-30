    using EspacioClases;

            static void MostrarTareas(List<Tarea> lista, string titulo){

            Console.WriteLine($"\n{titulo}");
            foreach (var tarea in lista)
            {
                Console.WriteLine($"ID:{tarea.TareaID} - Descripcion:{tarea.Descripcion} - Duracion:{tarea.Duracion} min");
            }

            }

    string[] descrip = { "Codear", "Comer", "Rezar", "Trabajar", "Procesar", "estudiar", "practicar", "Dormir", "Vacunarse"};

    List<Tarea> tareasPendientes = new List<Tarea>();
    List<Tarea> tareasRealizadas = new List<Tarea>();

    Random rnd = new Random();

    int N = rnd.Next(1, 11);
    int M = 0;

    Console.WriteLine($"Se generaran {N} tareas Pendientes aleatorias. \n");

    for (int i = 0; i < N; i++)
    {
        M = rnd.Next(0,9);

        int id = i+1;
        string descripcion = descrip[M];
        int duracion = rnd.Next(10, 101);

        Tarea nuevaTarea = new Tarea(id, descripcion,duracion);
        tareasPendientes.Add(nuevaTarea);

    }

    string respuesta;

    do
    {
        
        MostrarTareas(tareasPendientes,"Tareas Pendientes:");

        Console.WriteLine("\nIngrese el ID de la tarea que desea marcar como realizada: ");

        if (int.TryParse(Console.ReadLine(), out int idSeleccionado))
        {
            Tarea tarea = tareasPendientes.Find(t => t.TareaID == idSeleccionado);

            if (tarea != null)
            {
                tareasPendientes.Remove(tarea);
                tareasRealizadas.Add(tarea);
                Console.WriteLine("Tarea movida a realizadas.");

            }
            else
            {
                Console.WriteLine("No se encontro La tarea con ese ID.");
            }
        }
        else
        {
            Console.WriteLine("Entrada Invalida.");
        }
    
        Console.Write("\n¿Desea mover otra tarea? (s/n): ");
        respuesta = Console.ReadLine().ToLower();
        Console.Clear();
    
    } while (respuesta == "s");


    MostrarTareas(tareasPendientes,"Tareas Pendientes:");
    MostrarTareas(tareasRealizadas,"Tareas Realizadas:");