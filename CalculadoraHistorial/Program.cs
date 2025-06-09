
using EspacioCalculadora;

        Console.Write("Ingrese un valor inicial para la calculadora: ");
        double valorInicial = Convert.ToDouble(Console.ReadLine());

        Calculadora calc = new Calculadora(valorInicial);
        string opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("===== CALCULADORA =====");
            Console.WriteLine($"Resultado actual: {calc.Resultado}\n");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Limpiar");
            Console.WriteLine("6 - Ver historial");
            Console.WriteLine("0 - Salir");
            Console.Write("Opción: ");
            opcion = Console.ReadLine();

            double valor;

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese valor a sumar: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    calc.Sumar(valor);
                    break;

                case "2":
                    Console.Write("Ingrese valor a restar: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    calc.Restar(valor);
                    break;

                case "3":
                    Console.Write("Ingrese valor a multiplicar: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    calc.Multiplicar(valor);
                    break;

                case "4":
                    Console.Write("Ingrese valor a dividir: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    calc.Dividir(valor);
                    break;

                case "5":
                    calc.Limpiar();
                    Console.WriteLine("Resultado y operación limpiados.");
                    break;

                case "6":
                    calc.MostrarHistorial();
                    break;

                case "0":
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            if (opcion != "0")
            {
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != "0");
 