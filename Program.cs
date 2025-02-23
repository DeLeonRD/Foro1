using System;

namespace CalculadoraDescuentosGrupo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configuración de colores
            Console.Title = " Calculadora de Descuentos - Tienda ";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            //  Encabezado del programa
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t***********************************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t*            CALCULADORA DE DESCUENTOS       *");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t***********************************************\n");

            // Entrada de datos
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t Ingrese su nombre: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string nombre = Console.ReadLine();

            double montoSinDescuento;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t Ingrese el monto de la compra: $");
                Console.ForegroundColor = ConsoleColor.Green;

                if (double.TryParse(Console.ReadLine(), out montoSinDescuento) && montoSinDescuento > 0)
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Error: Ingrese un monto válido mayor a 0.");
            }

            // Tipo de Cliente
            string tipoCliente;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\t Seleccione el Tipo de Cliente: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t   [N] Cliente Normal (0% Descuento)");
                Console.WriteLine("\t   [P] Cliente Premium (10% Descuento)");
                Console.WriteLine("\t   [V] Cliente VIP (20% Descuento)");
                Console.Write("\n Digite su opción [N, P, V]: ");
                Console.ForegroundColor = ConsoleColor.Green;
                tipoCliente = Console.ReadLine().ToUpper();

                if (tipoCliente == "N" || tipoCliente == "P" || tipoCliente == "V")
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t Error: Ingrese una opción válida (N, P o V).");
            }

            Console.WriteLine("\n");

            //Cálculo del descuento por tipo de cliente con IF-ELSE
            double descuento = 0;
            if (tipoCliente == "N")
            {
                descuento = 0;
            }
            else if (tipoCliente == "P")
            {
                descuento = montoSinDescuento * 0.10;
            }
            else if (tipoCliente == "V")
            {
                descuento = montoSinDescuento * 0.20;
            }

            // Aplicación del descuento adicional si el monto es mayor a $500
            double descuentoExtra = 0;
            if (montoSinDescuento > 500)
            {
                descuentoExtra = montoSinDescuento * 0.05;
            }

            //  Cálculo del monto final
            double montoTotal = montoSinDescuento - descuento - descuentoExtra;

            //  Resumen Final
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t***********************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                    RESUMEN DE LA CUENTA");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\t Cliente: {nombre}");
            Console.WriteLine($"\t Monto Original: ${montoSinDescuento:F2}");

            if (descuento > 0)
            {
                Console.WriteLine($"\t Descuento por tipo de cliente: ${descuento:F2}");
            }
            if (descuentoExtra > 0)
            {
                Console.WriteLine($"\t Descuento Extra (Monto > $500): ${descuentoExtra:F2}");
            }

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"\t TOTAL A PAGAR: ${montoTotal:F2}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t***********************************************");

            Console.ReadKey();
        }
    }
}
