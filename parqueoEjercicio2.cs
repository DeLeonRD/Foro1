
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Escriba 'OK' para iniciar o 'SALIR' para cerrar:");
            Console.ResetColor();

            string inicio = Console.ReadLine()?.ToUpper();

            if (inicio == "SALIR")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saliendo del programa...");
                Console.ResetColor();
                return;
            }
            else if (inicio != "OK")
            {
                MostrarError("Entrada no válida.");
                continue;
            }

            SeleccionarVehiculo();
        }
    }

    static void SeleccionarVehiculo()
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Seleccione el tipo de vehículo:");
            Console.WriteLine("1. Automóvil");
            Console.WriteLine("2. Motocicleta");
            Console.WriteLine("3. Camión");
            Console.WriteLine("4. Salir");
            Console.ResetColor();

            if (!int.TryParse(Console.ReadLine(), out int opcion))
            {
                MostrarError("Entrada no válida.");
                continue;
            }
            if (opcion == 4) SalirPrograma();

            double tarifa = opcion switch
            {
                1 => 2.00,
                2 => 1.00,
                3 => 3.50,
                _ => -1
            };

            if (tarifa == -1)
            {
                MostrarError("Opción no válida.");
                continue;
            }

            CalcularCosto(tarifa);
        }
    }

    static void CalcularCosto(double tarifa)
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingrese las horas de estacionamiento (1 - 24):");
            Console.WriteLine("O presione '0' para regresar.");
            Console.ResetColor();

            if (!int.TryParse(Console.ReadLine(), out int horas))
            {
                MostrarError("Entrada no válida.");
                continue;
            }

            if (horas == 0) return;
            if (horas < 1 || horas > 24)
            {
                MostrarError("Cantidad de horas no válida.");
                continue;
            }

            double costoTotal = tarifa * horas;
            if (horas > 5) costoTotal *= 0.90; // Aplicar 10% de descuento

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\nEl costo total a pagar es: ${costoTotal:F2}");
            Console.ResetColor();

            Console.WriteLine("\n .... ");
            Thread.Sleep(5000);
            return;
        }
    }

    static void MostrarError(string mensaje)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(mensaje);
        Console.ResetColor();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }

    static void SalirPrograma()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Saliendo del programa...");
        Console.ResetColor();
        Environment.Exit(0);
    }
}