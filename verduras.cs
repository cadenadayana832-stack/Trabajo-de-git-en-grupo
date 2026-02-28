using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_de_git_en_grupo
{
    internal class verduras
    {
        static void Main(string[] args)
        {
            string[] verduras = { "Zanahoria", "Brócoli", "Espinaca", "Tomate", "Pepino" };

            Console.WriteLine("=== LISTA DE VERDURAS ===");

            for (int i = 0; i < verduras.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {verduras[i]}");
            }

            Console.WriteLine("=======================");
            Console.WriteLine($"Total: {verduras.Length} verduras");
            Console.WriteLine("Mi verdura favorita es: " + verduras[0]);
        }
    }
}
