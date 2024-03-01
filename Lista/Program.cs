using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lista
{
    //Se crea la clase "Estudiante"
    class Estudiante
    {
        //Propiedad que almacena el nombre de los estudiantes.
        public string Nombre { get; set; }
        //Se crea una lista enlazada para almacenar las calificaciones de los estudiantes
        public LinkedList<Calificacion> Calificaciones { get; set; }
        //Se crea el constructor de la clase Estudiante
        public Estudiante(string nombre)
        {
            Nombre = nombre;
            //Inicia una lista enlazada de calificaciones cuando se crea un nuevo estudiante
            Calificaciones = new LinkedList<Calificacion>();
        }
    }
    //Se crea la clase "Calificacion"
    class Calificacion
    {
        //Propiedad para almacenar el valor de la calificación
        public int Valor { get; set; }
        //Constructor de la clase calificacion
        public Calificacion(int valor)
        {
            Valor = valor;
        }
    }

    class Programa
    {
        static void Main(string[] args)
        {
            //Se crea la ruta al archivo que contiene los nombres de los estudiantes.
            string path = @"D:\estudiantes.txt";
            //Se crea una lista enlazada para almacenar objetos de tipo estudiante
            LinkedList<Estudiante> estudiantes = new LinkedList<Estudiante>();
            //Lee el archivo
            foreach (string nombre in File.ReadLines(path))
            {
                //Se crea un nuevo objeto con los nombres leidos
                Estudiante estudiante = new Estudiante(nombre);
                //Se comienzan a preparar las calificaciones de los estudiantes
                for (int i = 0; i < 5; i++)
                {
                    //Se le asigna la calificacion obtenida a la lista de calificaciones
                    estudiante.Calificaciones.AddLast(new Calificacion(i * 10));
                }
                //Añade el estudiante obtenido a la lista de estudiantes
                estudiantes.AddLast(estudiante);
            }

            //Se prepara la visualizacion de los datos
            foreach (Estudiante estudiante in estudiantes)
            {
                //Imprime el nombre de los estudiantes
                Console.WriteLine($"Estudiante: {estudiante.Nombre}");
                //Se prepara la visualizacion de las calificaciones de cada estudiante
                foreach (Calificacion calificacion in estudiante.Calificaciones)
                {
                    //Imprime la calificacion
                    Console.WriteLine($"Calificacion: {calificacion.Valor}");
                }
            }
        }
    }
}