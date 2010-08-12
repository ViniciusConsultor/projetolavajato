using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HenryCorporation.Lavajato.DataAccess;
using HenryCorporation.Lavajato.DomainModel;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] placas = { "ggg1234567", "ggg12345", "ggg87547855", "ggg-8754" };
            for (int i = 0; i < placas.Length; i++)
                VerificaPlaca(placas[i]);

            Console.ReadKey();
        }

        private static void VerificaPlaca(string placaBackup)
        {

            int index = placaBackup.IndexOfAny(new char[] { '-', '.', ',', '_' });
            if (index > -1)
            {
                placaBackup =placaBackup.Remove(index, 1);
                Console.WriteLine("Caracter retirado " + placaBackup);
            }



            if (placaBackup.Length > 7)
                placaBackup = placaBackup.Remove(7, placaBackup.Length - 7);

            Console.WriteLine("Tamanho da placa " + placaBackup);

            string letras = "";
            string numeros = "";

            if (placaBackup.Length >= 3)
                letras = placaBackup.Substring(0, 3);

            Console.WriteLine("Letras da placa " + letras.ToUpper());

            if (placaBackup.Length > 3 && placaBackup.Length >= 7)
                numeros = placaBackup.Substring(3, 4);

            Console.WriteLine("Numeros da placa " + numeros);
            Console.WriteLine("---------------------------------------");

        }
    }
}
