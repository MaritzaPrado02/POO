using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Bidimensional1_2_
{
    //Array de arrays(array de dos dimensiones)
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter archivo;

            archivo = new StreamWriter("ArchivoBidimensional(1(2)).txt");


            int[][] notas; //Array de dos dimensiones
            notas = new int[3][]; //Serán 3 bloques de datos
            notas[0] = new int[10]; //10 notas en un grupo
            notas[1] = new int[15]; //15 notas en otro grupo
            notas[2] = new int[12]; //12 notas en el ultimo

            //Damos valores de ejemplo
            for (int i = 0; i < notas.Length; i++)
            {
                for (int j = 0; j < notas[i].Length; j++)
                {
                    notas[i][j] = i + j;
                }
            }

            var cadena = "";
            //Y mostramos esos valores 
            for (int i = 0; i < notas.Length; i++)
            {
               
                for (int j = 0; j < notas[i].Length; j++)
                {
                    Console.Write(" " +  notas[i][j]);
                    cadena += " " + notas[i][j];
                }
                cadena += "\n";
                Console.WriteLine();
            }
            archivo.WriteLine(cadena);

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

                            leerArchivo = new StreamReader("ArchivoBidimensional(1(2)).txt");

                            Console.WriteLine(leerArchivo.ReadToEnd());
                            break;
                        }
                    case "2":
                        {
                            Process.Start("ArchivoBidimensional(1(2)).txt");
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
