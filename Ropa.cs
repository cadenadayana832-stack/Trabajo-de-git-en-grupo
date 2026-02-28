using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_de_git_en_grupo
{
    internal class Ropa
    {
        static void Main()
        {
            string[] prendas = { "Camisa", "Pantalón", "Vestido", "Chaqueta" };

            Console.WriteLine("=== TIENDA DE ROPA ===");

            for (int i = 0; i < prendas.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {prendas[i]}");
            }

            Console.WriteLine($"Total: {prendas.Length} prendas");
        }
    }

}
