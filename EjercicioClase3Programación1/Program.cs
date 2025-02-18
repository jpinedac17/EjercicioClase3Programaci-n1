using System;
using System.Collections.Generic;

class Program
{
    static List<string> estudiantes = new List<string>();
    static List<double> calificaciones = new List<double>();

    static void Main(string[] args)
    {
        // Modulos
        static void Menu() {
            Console.WriteLine("\n1. Agregar estudiante");
            Console.WriteLine("2. Mostrar lista de estudiantes");
            Console.WriteLine("3. Calcular promedio de calificaciones");
            Console.WriteLine("4. Mostrar estudiante con la calificación más alta");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static string Mensaje(string mensaje) {
            Console.WriteLine(mensaje);
            return mensaje; 
        }

        static void AgregarEstudiante() {
            Mensaje("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();
            Mensaje("Ingrese la calificación del estudiante: ");
            double calificacion = double.Parse(Console.ReadLine());
            estudiantes.Add(nombre);
            calificaciones.Add(calificacion);
            Mensaje("Estudiante agregado correctamente.");
        }

        static void ListaEstudiantes() {
            Mensaje("\nLista de estudiantes:");
                for (int i = 0; i < estudiantes.Count; i++)
                    {
                        Mensaje($"{estudiantes[i]} - Calificación: {calificaciones[i]}");
                    }
        }

        static void PromedioEstudiantes() {
            double suma = 0;
                foreach (double cal in calificaciones)
                {
                    suma += cal;
                }
                double promedio = suma / calificaciones.Count; 
                        
                Mensaje($"El promedio de calificaciones es: {promedio}");
        }

        static void CalidifacionMasAlta() {
            double maxCalificacion = calificaciones[0];
            string estudianteMax = estudiantes[0];
            for (int i = 1; i < calificaciones.Count; i++)
            {
                if (calificaciones[i] > maxCalificacion)
                {
                    maxCalificacion = calificaciones[i];
                    estudianteMax = estudiantes[i];
                }
            } 
                        
            Mensaje($"El estudiante con la calificación más alta (obtenida primero) es: {estudianteMax} con {maxCalificacion}");
        }

        static void Salir() {
            Mensaje("Saliendo del sistema...");
            Environment.Exit(0);
        }

        Mensaje("Bienvenido al sistema de gestión de estudiantes.");

        while (true)
        {
            Menu();
            int opcion = int.Parse(Console.ReadLine());
            
            switch (opcion) {
                case 1:
                    AgregarEstudiante();
                    break;
                case 2:
                    if (estudiantes.Count == 0)
                    {
                        Mensaje("No hay estudiantes registrados.");
                    }
                    else
                    {
                       ListaEstudiantes(); 
                    }
                    break;
                case 3:
                    if (calificaciones.Count == 0)
                    {
                        Mensaje("No hay calificaciones registradas.");
                    }
                    else
                    {
                        PromedioEstudiantes();
                    }
                    break;
                case 4:
                    if (calificaciones.Count == 0)
                    {
                        Mensaje("No hay calificaciones registradas.");
                    }
                    else
                    {
                        CalidifacionMasAlta();
                    }
                    break;
                case 5:
                    Salir();
                    break;
                default:
                    Mensaje("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}