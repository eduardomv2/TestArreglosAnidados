using System;

namespace TestArreglosAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarar un "jagged array" de enteros
            int[][] nombrearreglos = new int[3][];

            // Inicializar cada subarreglo con diferentes tamaños
            nombrearreglos[0] = new int[] { 1, 2, 3 };
            nombrearreglos[1] = new int[] { 4, 5, 6, 7 };
            nombrearreglos[2] = new int[] { 8, 9 };

            // Acceder a elementos individuales
            int elemento = nombrearreglos[1][2]; // Accede al número 6
            Console.WriteLine(elemento);

            // Iterar a través de los elementos
            for (int i = 0; i < nombrearreglos.Length; i++)
            {
                for (int j = 0; j < nombrearreglos[i].Length; j++)
                {
                    Console.Write(nombrearreglos[i][j] + " ");
                }
                Console.WriteLine();
            }

            //CREACION DE UNA ARREGLO BIDIMENSIONAL
            //LE DAMOS COMO NOMBRE calificaciones
            //DENTRO DE LA MATRIZ LE DAMOS EL PARAMETRO 3 Y 4
            //3 REPRESENTA LAS FILAS (estudiante)
            //4 REPRESENTA LAS COLUMNTAS (asignaturas)
            int[,] calificaciones = new int[3, 4];

            calificaciones[0, 0] = 85; // Calificación del estudiante 1 en asignatura 1
            calificaciones[0, 1] = 92; // Calificación del estudiante 1 en asignatura 2
            calificaciones[0, 2] = 78; // Calificación del estudiante 1 en asignatura 3
            calificaciones[0, 3] = 88; // Calificación del estudiante 1 en asignatura 4

            calificaciones[1, 0] = 75; // Calificación del estudiante 2 en asignatura 1
            calificaciones[1, 1] = 88; // Calificación del estudiante 2 en asignatura 2
            calificaciones[1, 2] = 95; // Calificación del estudiante 2 en asignatura 3
            calificaciones[1, 3] = 82; // Calificación del estudiante 2 en asignatura 4

            calificaciones[2, 0] = 90; // Calificación del estudiante 3 en asignatura 1
            calificaciones[2, 1] = 79; // Calificación del estudiante 3 en asignatura 2
            calificaciones[2, 2] = 88; // Calificación del estudiante 3 en asignatura 3
            calificaciones[2, 3] = 91; // Calificación del estudiante 3 en asignatura 4

            for (int estudiante = 0; estudiante < 3; estudiante++)
            {
                Console.WriteLine("Calificaciones del estudiante " + (estudiante + 1) + ":");
                for (int asignatura = 0; asignatura < 4; asignatura++)
                {
                    int calificacion = calificaciones[estudiante, asignatura];
                    Console.WriteLine("Asignatura " + (asignatura + 1) + ": " + calificacion);
                }
                Console.WriteLine();
            }

        }
    }
}
