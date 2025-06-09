namespace EspacioClases
{

    public class Tarea
    {

        public int TareaID { get; set; }
        public string Descripcion { get; set; }

        private int duracion;
        public int Duracion
        {
            get => duracion;
            set
            {

                if (value < 10 || value > 100)
                {

                    duracion = 0;

                }
                else
                {

                    duracion = value;

                }

            }

        }

        public Tarea(int tareaID, string descripcion, int duracion)
        {
            this.TareaID = tareaID;
            this.Descripcion = descripcion;
            this.Duracion = duracion;
        }


        public static void MostrarTareas(List<Tarea> lista, string titulo)
        {
            Console.WriteLine($"\n{titulo}");
            foreach (var tarea in lista)
            {
                Console.WriteLine($"ID:{tarea.TareaID} - Descripción:{tarea.Descripcion} - Duración:{tarea.Duracion} min");
            }
        }
        
        public static void BuscarPorDescripcion(List<Tarea> lista, string descripcionBuscada)
        {
            List<Tarea> tareasEncontradas = lista.Where(t => t.Descripcion.ToLower().Contains(descripcionBuscada.ToLower())).ToList();

            if (tareasEncontradas.Any())
            {
                Console.WriteLine($"\nTareas encontradas con descripción que contiene \"{descripcionBuscada}\":");
                foreach (var tarea in tareasEncontradas)
                {
                    Console.WriteLine($"ID:{tarea.TareaID} - Descripción:{tarea.Descripcion} - Duración:{tarea.Duracion} min");
                }
            }
            else
            {
                Console.WriteLine($"\nNo se encontraron tareas que contengan \"{descripcionBuscada}\".");
            }
        }


    }


}