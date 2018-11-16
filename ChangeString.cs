using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ChangeString
{
    static Char[] abecedario = "abcdefghijklmnñopqrstuvwxyz".ToCharArray();

    static void Main(string[] args)
    {
        Console.Write("Entrada: ");
        String cadena = Console.ReadLine();
        Console.WriteLine("Salida: " + Build(cadena));
    }

    static string Build(string cadena)
    {
        String resultado = "";
        int posicion;
        Char caracter;

        for (int i = 0; i < cadena.Length; i++)
        {
            caracter = cadena[i];
            if (abecedario.Contains(caracter))
            {
                posicion = Array.IndexOf(abecedario, caracter);
                if (posicion == abecedario.Length - 1)
                    caracter = abecedario[0];
                else
                    caracter = abecedario[posicion + 1];
            }
            resultado += caracter;
        }
        return resultado;
    }
}
