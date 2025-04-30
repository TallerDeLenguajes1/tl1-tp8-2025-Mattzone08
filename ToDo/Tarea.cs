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

        } // Validar que esté entre 10 y 100

        // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario


        public Tarea(int tareaID, string descripcion, int duracion)
        {
            this.TareaID = tareaID;
            this.Descripcion = descripcion;
            this.Duracion = duracion;
        }


    }


}