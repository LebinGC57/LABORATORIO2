using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuarioCorrecto = "usuario";
            string claveCorrecta = "contraseña123";

            Console.WriteLine("Ingrese su nombre de usuario:");
            string usuarioIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese su contraseña:");
            string claveIngresada = Console.ReadLine();

            string mensajeAcceso = VerificarCredenciales(usuarioIngresado, claveIngresada, usuarioCorrecto, claveCorrecta);
            Console.WriteLine(mensajeAcceso);
        }

        static string VerificarCredenciales(string usuarioIngresado, string claveIngresada, string usuarioCorrecto, string claveCorrecta)
        {
            if (usuarioIngresado == usuarioCorrecto)
            {
                if (claveIngresada == claveCorrecta)
                {
                    return "Acceso concedido";
                }
                else
                {
                    return "Contraseña incorrecta";
                }
            }
            else
            {
                return "Usuario no registrado";
            }
        }
    }
}