using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Bidimensional1_1_
{
    //Array de 2 dimensiones "rectangulares" 
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter archivo;

            archivo = new StreamWriter("ArchivoBidimensional(1).txt");

            int[,] notas1 = new int[2, 2]; // 2 bloques de 2 datos 
            notas1[0, 0] = 1;
            notas1[0, 1] = 2;
            notas1[1, 0] = 3;
            notas1[1, 1] = 4;

            int[,] notas2 = //2 bloques de 10 datos prefijados
            {
                {1,2,3,4,5,6,7,8,9,10 }, {11,12,13,14,15,16,17,18,19,20}
            };


            Console.WriteLine("La nota 1 del segundo alumno del grupo 1 es {0}: " + notas1[0,1]);
            Console.WriteLine("La nota 2 del tercer alumno del grupo 1 es {0}: " + notas2[0, 2]);

            archivo.WriteLine("La nota 1 del segundo alumno del grupo 1 es {0}: " + notas1[0, 1] + "\nLa nota 2 del tercer alumno del grupo 1 es {0}: " + notas2[0, 2]);

            archivo.Close();

            Console.WriteLine("\nLos datos se han guardado en el archivo");


            Console.WriteLine("\n¿Que desea hacer?");
            Console.WriteLine("Ingrese el número de lo que desea hacer");
            Console.WriteLine("\n1)Leer archivo con lo datos");
            Console.WriteLine("2)Abrir el archivo con lo datos");
            Console.WriteLine("3)Nada más");

            string caseSwitch;

            caseSwitch = Console.ReadLine();
            switch (caseSwitch)
            {
                case "1":
                    {
                        TextReader leerArchivo;

                        leerArchivo = new StreamReader("ArchivoBidimensional(1).txt");

                        Console.WriteLine(leerArchivo.ReadToEnd());
                        break;
                    }
                case "2":
                    {
                        Process.Start("ArchivoBidimensional(1).txt");
                        break;
                    }
                case "3":
                    {
                        Environment.Exit(0);
                        break;
                    }
                default:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
          
            Console.ReadKey();
        }
    }
}
