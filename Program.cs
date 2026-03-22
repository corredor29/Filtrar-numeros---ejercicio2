using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int [] Arreglo= {10,3,5,3,10};
        int [] Repetidos = ObtenerRepetidos(Arreglo);
        Console.WriteLine("Numeros repetidos");
        foreach (int Num in Repetidos)
        {
            Console.WriteLine(Num);
        }
    }
    static int[] ObtenerRepetidos(int[] Arreglo)
    {
        Dictionary<int,int> Conteo = new Dictionary<int,int>();
        List<int> Resultado = new List<int>();

        foreach (int Num in Arreglo)
        {
            if (Conteo.ContainsKey(Num))
                Conteo [Num] ++;
            else 
                Conteo[Num] = 1;
        }
        foreach (var Par in Conteo)
        {
            if (Par.Value > 1)
                Resultado.Add(Par.Key);
        }
        return Resultado.ToArray();

    }
}