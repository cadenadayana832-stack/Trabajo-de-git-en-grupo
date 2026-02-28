using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_de_git_en_grupo
{
    internal class Zapatos
    {
        public Zapatos() {
            string[] zapatos = { "Nike", "Adidas", "Puma", "Reebok", "Vans" };

            Console.WriteLine("=== LISTA DE MARCAS DE ZAPATOS ===");

            for (int i = 0; i < zapatos.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {zapatos[i]}");
            }

            Console.WriteLine("==================================");
            Console.WriteLine($"Total: {zapatos.Length} marcas");
            Console.WriteLine("Marca Zapatos");
        }
    }
}
