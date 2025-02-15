using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número del 1 al 7:");
            int numeroIngresado = int.Parse(Console.ReadLine());
            string diaDeLaSemana = ObtenerNombreDia(numeroIngresado);
            Console.WriteLine($"Día de la semana: {diaDeLaSemana}");
        }

        static string ObtenerNombreDia(int numero)
        {
            switch (numero)
            {
                case 1:
                    return "Lunes";
                case 2:
                    return "Martes";
                case 3:
                    return "Miércoles";
                case 4:
                    return "Jueves";
                case 5:
                    return "Viernes";
                case 6:
                    return "Sábado";
                case 7:
                    return "Domingo";
                default:
                    return "Número inválido";
            }
        }
    }
}
