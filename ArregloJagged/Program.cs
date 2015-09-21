using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            int salones = 0;
            int n = 0;
            int m = 0;
            string valor = "";

            float suma = 0.0f;
            float promedio = 0.0f;

            float minima = 10.0f;
            float maxima = 0.0f;

            Console.WriteLine("Cantidad de salones: ");
            valor = Console.ReadLine();
            salones = Convert.ToInt32(valor);

            float[][] calif = new float[salones][];

            for(n = 0; n < salones; n++)
            {
                Console.Write("Cantidad de alumnos: ");
                valor = Console.ReadLine();
                cantidad = Convert.ToInt32(valor);

                calif[n] = new float[cantidad];
            }
            for(n = 0;n < salones;n++)
            {
                Console.WriteLine("Salon {0} ",n);
                for(m = 0;m < calif[n].GetLength(0);m++)
                {
                    Console.Write("Calificacion: ");
                    valor = Console.ReadLine();
                    calif[n][m] = Convert.ToSingle(valor);

                    if (maxima < calif[n][m])
                        maxima = calif[n][m];
                    if (minima > calif[n][m])
                        minima = calif[n][m];

                    suma += calif[n][m];
                    promedio = suma / cantidad;
                }
            }
            Console.WriteLine("---Informacion---");
            for(n = 0;n < salones; n++)
            {
                Console.WriteLine("Salon {0}",n);
                for(m = 0;m < calif[n].GetLength(0);m++)
                {
                    Console.WriteLine("El alumno {0} tiene {1}",m,calif[n][m]);
                }
            }
            Console.WriteLine("Promedio: {0} ",promedio);
            Console.WriteLine("Maxima: {0} ",maxima);
            Console.WriteLine("Minima: {0} ",minima);
            Console.ReadKey();

        }
    }
}
