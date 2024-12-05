using Proyecto_IContinua_01.Aplicacion.Servicios;
using Proyecto_IContinua_01.Infraestructura.Datos;
using System;

class Program
{
    static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("===========================================");
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Mi nombre es Alex");

        Console.WriteLine("Mi apellido es: Bautista");
        Console.WriteLine("===========================================");
        Console.WriteLine();
        Console.WriteLine("===========================================");

        var repositorioUsuario = new RepositorioUsuario();
        var servicioControlAcceso = new ServicioControlAcceso(repositorioUsuario);

        Console.WriteLine("            Control de Acceso            ");
        Console.WriteLine("===========================================");
        Console.WriteLine();
        Console.Write("Ingrese el nombre de usuario (Alex - Mario: ");
        string nombreUsuario = Console.ReadLine();

        Console.Write("Ingrese la contraseña: ");
        string contrasena = Console.ReadLine();

        bool autenticado = servicioControlAcceso.Autenticar(nombreUsuario, contrasena);

        if (autenticado)
        {
            Console.WriteLine("Acceso concedido.");
            Console.WriteLine("===========================================");
            Console.WriteLine("                 Bienvenido.               ");
            Console.WriteLine("===========================================");
        }
        else
        {
            Console.WriteLine("Acceso denegado.");
            Console.WriteLine("Intentalo de nuevo.");
        }
    }
}