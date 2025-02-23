using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Foro1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.Title = "Calculadora de Descuentos en una Tienda";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\t*                 Ejercicio #1 Foro #1                  *");
            Console.Write("\n\t<<<      Calculadora de Descuentos en una Tienda      >>>");
            Console.WriteLine("\n");
            //Declaracion de Variables
            string Nombre, TipodeCliente;
            double MontoTotal=0, MontoSinDescuento=0, descuento=0, descuentoextra=0,VMSD=0;
            //Entrada de datos
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("\tIngresar el nombre del cliente [Nombre,Apellido]: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Nombre = Console.ReadLine();
            //Validacion del monto de compra
            while (VMSD <= 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write("\n\tIngresar el monto de la compra: $");
                Console.ForegroundColor = ConsoleColor.Green;
                MontoSinDescuento = double.Parse(Console.ReadLine());
                if (MontoSinDescuento > 0)
                {
                    VMSD = MontoSinDescuento;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tEl dato ingresado no es válido, intente de nuevo");
                }
            }
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\tSeleccione el Tipo de Cliente : ");
                Console.WriteLine("\t    N = Cliente Normal");
                Console.WriteLine("\t    P = Cliente Premium");
                Console.WriteLine("\t    V = Cliente VIP");
                Console.Write("\n\tDigite su opción [N,P,V] : ");
                Console.ForegroundColor = ConsoleColor.Green;
                TipodeCliente = Console.ReadLine().ToUpper();
                if (TipodeCliente == "N" || TipodeCliente == "P" || TipodeCliente == "V")
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tEl tipo de cliente no es válido, intente de nuevo");
                }
            }
            Console.WriteLine("\n");
            //Procesos
            if (TipodeCliente == "N")
                {
                    descuento = 0;
                }
            else
                    if (TipodeCliente == "P")
                {
                    descuento = MontoSinDescuento * 0.10;
                }
            else
                    if (TipodeCliente == "V")
                {
                    descuento = MontoSinDescuento * 0.20;
                }
            //Aplicando el descuento adicional si el monto es mayor a 500
            if (MontoSinDescuento > 500)
                {
                    descuentoextra = MontoSinDescuento * 0.05;
                }
            //Calculo de cuenta final
            MontoTotal = MontoSinDescuento - descuento - descuentoextra;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\t*********************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n\t   El total de " + Nombre + " a cancelar es: $" + Math.Round(MontoTotal,2)+" dólares.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\t*********************************************************");
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }
}
