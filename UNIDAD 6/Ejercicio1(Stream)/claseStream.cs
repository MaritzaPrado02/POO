using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Stream_
{
    class claseStream
    {
        public void metodoStream()
        {
            using (Stream ms = new MemoryStream())
            {
                using (Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read))
                {
                    fs.CopyTo(ms);
                }

                ms.Seek(0, SeekOrigin.Begin);

                using (StreamReader sr = new StreamReader(ms))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }

                using (Stream fs = new FileStream("./archivo.txt", FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("Hola");
                        sw.WriteLine("Otra linea");
                        sw.WriteLine("Y otra");
                    }
                }
            }
            /*using (Stream fs = new FileStream("./escribirarchivo.txt",FileMode.Create,FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Hola otra vez, esto es un archivo escrito desde C#");
                }
            }*/
            /*Stream fs = new FileStream("./archivo.txt", FileMode.Open, FileAccess.Read);

            
            //Obtenemos el número de bytes
            long quantity = fs.Length;
            Console.WriteLine("El archivo tiene una longitud de " + quantity + " bytes");

            fs.Close();*/

           
            /*StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Hola, esto es un archivo escrito desde C#");

            sw.Close();*/

      
            //LEER UN ARCHIVO
            //un byte una letra
            /*fs.Seek(7, SeekOrigin.Begin);

            StreamReader sr = new StreamReader(fs);

            string todo = sr.ReadToEnd();
            Console.WriteLine(todo);*/

            /*IMPRIME HASTA QUE TERMINE EL CONTENIDO DEL FICHERO
             * while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }*/


            /*string line = sr.ReadLine();
            Console.WriteLine(line);

             PARA CADA LINEA
             * line = sr.ReadLine();
            Console.WriteLine(line);

            line = sr.ReadLine();
            Console.WriteLine(line);*/



            /*IMPRIMIR EN PANTALLA CON CICLO WHILE
               int     valor = 0;
            while (valor != -1)
            {
                valor = fs.ReadByte();
                while (valor != -1)
                {
                    Console.WriteLine($"{(char)valor}");
                }
            }*/


            /*
            //IMPRIMIR EN PANTALLA CON CICLO FOR
            for (long count = 0; count < quantity; count++)
                {
                    fs.Seek(count, SeekOrigin.Begin);
                    int valor = fs.ReadByte();
                    Console.WriteLine($"Posición {count}: {(char)valor}");
                }
            

            //Cerrar el sistema
            //sr.Close();
            fs.Close();*/
        }
    }
}
