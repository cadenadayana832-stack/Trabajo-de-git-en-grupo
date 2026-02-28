using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_de_git_en_grupo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Manzana", "Pera", "Uva", "Mango", "Fresa" };

            Console.WriteLine("=== LISTA DE FRUTAS ===");

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {frutas[i]}");
            }

            Console.WriteLine("=======================");
            Console.WriteLine($"Total: {frutas.Length} frutas");

        }
    }
}
