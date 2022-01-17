using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaFTP
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcio;

            do
            {
                menu();

                Console.Write("Opcio: ");
                opcio = Console.ReadLine().ToUpper().Trim();

                if (opcio.Length > 1)
                {
                    Console.Write("Torna a introduïr l'opcio: ");
                    opcio = Console.ReadLine().ToUpper().Trim();
                }

                switch (opcio)
                {
                    case "S":
                        break;
                    case "D":
                        break;
                    case "E":
                        break;
                    default:
                        Console.Write("ERROR. OPCIÓ NO DISPONIBLE.");
                        break;
                }
            } while (opcio != "S");
        }



        private static void menu()
        {
            Console.Write("----------------------------------\n");
            Console.Write("S: Sortir\n");
            Console.Write("D: Baixar fitxers des del servidor FTP\n");
            Console.Write("E: Processat de fitxer EDI\n");
            Console.Write("----------------------------------\n");
        }
    }
}