using EspacioClases;


        string[] descrip = { "Codear", "Comer", "Rezar", "Trabajar", "Procesar", "Estudiar", "Practicar", "Dormir", "Vacunarse" };

        List<Tarea> tareasPendientes = new List<Tarea>();
        List<Tarea> tareasRealizadas = new List<Tarea>();

        Random rnd = new Random();

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("----- MENÚ PRINCIPAL -----");
            Console.WriteLine("1. Generar tareas pendientes aleatorias");
            Console.WriteLine("2. Mostrar tareas pendientes");
            Console.WriteLine("3. Mostrar tareas realizadas");
            Console.WriteLine("4. Marcar tarea como realizada");
            Console.WriteLine("5. Buscar tarea por descripción");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese una opción: ");

            string opcion = Console.ReadLine();
            Console.Clear();

            switch (opcion)
            {
                case "1":
                    int N = rnd.Next(1, 11);
                    Console.WriteLine($"Se generarán {N} tareas pendientes aleatorias.\n");

                    tareasPendientes.Clear();

                    for (int i = 0; i < N; i++)
                    {
                        int M = rnd.Next(0, descrip.Length);
                        int id = i + 1;
                        string descripcion = descrip[M];
                        int duracion = rnd.Next(10, 101);

                        Tarea nuevaTarea = new Tarea(id, descripcion, duracion);
                        tareasPendientes.Add(nuevaTarea);
                    }
                    Console.WriteLine("Tareas generadas correctamente.\n");
                    break;

                case "2":
                    if (tareasPendientes.Count > 0)
                        Tarea.MostrarTareas(tareasPendientes, "Tareas Pendientes:");
                    else
                        Console.WriteLine("No hay tareas pendientes para mostrar.");
                    Console.WriteLine();
                    break;

                case "3":
                    if (tareasRealizadas.Count > 0)
                        Tarea.MostrarTareas(tareasRealizadas, "Tareas Realizadas:");
                    else
                        Console.WriteLine("No hay tareas realizadas para mostrar.");
                    Console.WriteLine();
                    break;

                case "4":
                    if (tareasPendientes.Count == 0)
                    {
                        Console.WriteLine("No hay tareas pendientes para marcar como realizadas.\n");
                        break;
                    }

                    Tarea.MostrarTareas(tareasPendientes, "Tareas Pendientes:");
                    Console.Write("\nIngrese el ID de la tarea que desea marcar como realizada: ");

                    if (int.TryParse(Console.ReadLine(), out int idSeleccionado))
                    {
                        Tarea tarea = tareasPendientes.Find(t => t.TareaID == idSeleccionado);
                        if (tarea != null)
                        {
                            tareasPendientes.Remove(tarea);
                            tareasRealizadas.Add(tarea);
                            Console.WriteLine("Tarea movida a realizadas.\n");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró la tarea con ese ID.\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.\n");
                    }
                    break;

                case "5":
                    if (tareasPendientes.Count == 0)
                    {
                        Console.WriteLine("No hay tareas pendientes para buscar.\n");
                        break;
                    }

                    Console.Write("Ingrese una descripción (o parte) a buscar en tareas pendientes: ");
                    string texto = Console.ReadLine();
                    Tarea.BuscarPorDescripcion(tareasPendientes, texto);
                    Console.WriteLine();
                    break;

                case "6":
                    salir = true;
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.\n");
                    break;
            }
        }
    
