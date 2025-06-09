namespace EspacioCalculadora{
    public class Operacion
    {
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacion;

        public double Resultado
        {
            get
            {
                return operacion switch
                {
                    TipoOperacion.Suma => resultadoAnterior + nuevoValor,
                    TipoOperacion.Resta => resultadoAnterior - nuevoValor,
                    TipoOperacion.Multiplicacion => resultadoAnterior * nuevoValor,
                    TipoOperacion.Division => nuevoValor != 0 ? resultadoAnterior / nuevoValor : 0,
                    TipoOperacion.Limpiar => 0,
                    _ => 0
                };
            }
        }

        public double NuevoValor => nuevoValor;
        public TipoOperacion Tipo => operacion;

        public Operacion(double anterior, double nuevo, TipoOperacion tipo)
        {
            resultadoAnterior = anterior;
            nuevoValor = nuevo;
            operacion = tipo;
        }

        public override string ToString()
        {
            return $"{operacion}: {resultadoAnterior} con {nuevoValor} = {Resultado}";
        }
    }
}