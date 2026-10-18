using System;
using System.Collections.Generic;
namespace LİSTEDE_ARAMA
{
    internal class Program
    {
        static bool NumaraVarMi(List<string> liste, string aranan)
        {
            foreach (string numara in liste)
            {
                if (numara == aranan)
                {
                    return true;
                }
            }

            return false;
        }
        static void Main(string[] args)
        {

       List<string> numaralar = new List<string> { "19", "25", "36", "49" };

        Console.WriteLine(NumaraVarMi(numaralar, "19"));
        Console.WriteLine(NumaraVarMi(numaralar, "49"));
        Console.WriteLine(NumaraVarMi(numaralar, "1000"));

        List<string> bosListe = new List<string>();
        Console.WriteLine(NumaraVarMi(bosListe, "19"));



        }
    }
}
