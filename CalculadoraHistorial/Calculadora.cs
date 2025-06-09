namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        // Historial de operaciones
        private List<Operacion> historial;

        public double Resultado => dato;

        public List<Operacion> Historial => historial;

        public Calculadora(double valorInicial)
        {
            dato = valorInicial;
            historial = new List<Operacion>();
        }

        public void Sumar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Suma));
            dato += termino;
        }

        public void Restar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Resta));
            dato -= termino;
        }

        public void Multiplicar(double termino)
        {
            historial.Add(new Operacion(dato, termino, TipoOperacion.Multiplicacion));
            dato *= termino;
        }

        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                historial.Add(new Operacion(dato, termino, TipoOperacion.Division));
                dato /= termino;
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
        }

        public void Limpiar()
        {
            historial.Add(new Operacion(dato, 0, TipoOperacion.Limpiar));
            dato = 0;
        }

        public void MostrarHistorial()
        {
            Console.WriteLine("\nHistorial de operaciones:");
            foreach (var op in historial)
            {
                Console.WriteLine(op);
            }
        }
    }
}