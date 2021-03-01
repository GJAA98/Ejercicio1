using System;

namespace Practica_de_array_y_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] numeros = new float[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Inserte un numero:");                
                string valor = Console.ReadLine();                
                numeros[i] = float.Parse(valor);
            }

            Console.WriteLine("Resultado:");
            float sumatoria = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Numero " + i + ":" + numeros[i]);
                sumatoria += numeros[i];
            }
            float media = sumatoria / 4;
            Console.WriteLine("Media aritmentica:"+ media);            
        }
    }
}
