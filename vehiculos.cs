
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_de_git_en_grupo
{
    internal class vehiculos
    {
            static void Main(string[] args)
            {
                string[] marcas = { "Toyota", "Chevrolet", "Ford", "BMW", "Mercedes-Benz" };

                Console.WriteLine("=== LISTA DE MARCAS DE CARROS ===");

                for (int i = 0; i < marcas.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {marcas[i]}");
                }

                Console.WriteLine("===============================");
                Console.WriteLine($"Total: {marcas.Length} marcas");

                Console.ReadKey(); // Para que la consola no se cierre
            }
        }
    }


