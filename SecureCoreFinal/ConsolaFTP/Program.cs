using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using System.Data;

namespace ConsolaFTP
{
    class Program
    {
        static DataSet dts;
        const string pathedi = "../RAREDI_2.edi";
        static void Main(string[] args)
        {
            string opcio, msgProcessat;
            bool correctOrder;

            bienvenida();
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
                        download();
                        break;
                    case "E":
                        correctOrder = processat();
                        if (correctOrder)
                        {
                            msgProcessat = "El processat a tingut éxit!\n";
                        }
                        else
                        {
                            msgProcessat = "El fitxer no s'ha processat correctament\n";
                        }

                        Console.WriteLine(msgProcessat);
                        break;
                    case "V":
                        veure();
                        break;
                    default:
                        Console.Write("ERROR.\n");
                        break;
                }
            } while (opcio != "S");
        }

        private static void bienvenida()
        {
            string grupo = "██╗   ██╗████████╗██╗███╗   ██╗███╗   ██╗██╗\n██║   ██║╚══██╔══╝██║████╗  ██║████╗  ██║██║\n██║   ██║   ██║   ██║██╔██╗ ██║██╔██╗ ██║██║\n██║   ██║   ██║   ██║██║╚██╗██║██║╚██╗██║██║\n╚██████╔╝   ██║   ██║██║ ╚████║██║ ╚████║██║\n ╚═════╝    ╚═╝   ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚═╝\n";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{grupo}");
            Console.Write("               ____==========_______\n");
            Console.Write("    _--____   |    | ''  ' ''|      \\\n");
            Console.Write("   /  )8}  ^^^| 0  |  =     |  o  0  |\n");
            Console.Write(" </_ +-==B vvv|''  |  =     | '  '' ' | \n");
            Console.Write("    \\_____/   |____|________|________|\n");
            Console.Write("             (_(  )\\________/___(  )__)\n");
            Console.Write("               |\\  \\            /  /\\\n");
            Console.Write("               | \\  \\          /  /\\ \\\n");
            Console.Write("                | |\\  \\        /  /  \\ \\\n");
            Console.Write("               (  )(  )       (  \\   (  )\n");
            Console.Write("                \\  / /        \\  \\   \\  \\\n");
            Console.Write("                 \\|  |\\        \\  \\  |  |\n");
            Console.Write("                  |  | )____    \\  \\ \\  )___\n");
            Console.Write("                  (  )  /  /    (  )  (/  /\n");
            Console.Write("                 /___\\ /__/     /___\\ /__/\n");
        }

        private static void menu()
        {
            Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.Write("D: Baixar fitxers des del servidor FTP\n");
            Console.Write("E: Processat de fitxer EDI\n");
            Console.Write("V: Veure el fitxer processat\n");
            Console.Write("S: Sortir\n");
            Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }

        private static void download()
        {
            //Ruta de classe
            //string rutadades = "ftp://g1@10.0.1.220//home//g1";

            //Ruta servidor propi
            string rutaDades = "ftp://51.83.97.10//home//utinni//ftp";

            List<string> ruta = AgafarRuta();
            foreach (string document in ruta)
            {
                try
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(rutaDades + "//" + document);

                    //Ruta de classe
                    //request.Credentials = new NetworkCredential("g1", "12345aA");

                    //Ruta servidor propi
                    request.Credentials = new NetworkCredential("utinni", "utinni");

                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);
                    string contingut = reader.ReadToEnd();

                    // Has de fer una carpeta temp a la unitat 'C:\'
                    File.WriteAllText("C:\\temp\\" + document, contingut);
                    Console.WriteLine($"Download Complete, status {response.StatusDescription}");
                    reader.Close();
                    response.Close();
                    rename(document);
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR");

                }
            }
        }

        private static bool processat()
        {
            bool a = false;
            string b = "ORD";
            
            switch (b)
            {
                case "ORD":

                    break;

                case "DTM":

                    break;
                case "NADMS":

                    break;
                case "NADMR":

                    break;
                case "LIN":

                    break;
                default:

                    break;
            }

            return a;
        }

        private static void veure()
        {
            try
            {
                StreamReader sr = new StreamReader(pathedi);
                string linia;

                linia = sr.ReadLine();
                System.Console.WriteLine("\n              VEURE COMANDA             ");
                System.Console.WriteLine("------------------------------------------");
                while (linia != null)
                {
                    System.Console.WriteLine(linia);
                    linia = sr.ReadLine();
                }
                System.Console.WriteLine("------------------------------------------");
            }
            catch (Exception)
            {
                System.Console.WriteLine("NO S'HA POGUT VISUALITZAR");
            }
        }

        public static string filename (string file)
        {
            Stack<char> charStack = new Stack<char>();
            string cutline = ""; // linia tallada
            char character = 'h'; // caracter

            for (int i = file.Length; i > 0; i--)
            {
                if (character != ' ')
                {
                    character = file[i - 1];
                    charStack.Push(character);
                }
                else
                {
                    i = 0;
                }

            }
            foreach (var item in charStack)
            {
                cutline += item;
            }

            return cutline.Trim();
        }


        private static List<string> AgafarRuta()
        {
            List<string> rutas = new List<string>();
            // Get the object used to communicate with the server.

            // Escola
            //FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://10.0.1.220//home//g1");

            // Server
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://51.83.97.10//home//utinni//ftp//");
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            //Ruta Classe
            //request.Credentials = new NetworkCredential("g1", "12345aA");

            // Server
            request.Credentials = new NetworkCredential("utinni", "utinni");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string line = reader.ReadLine();

            while (line != null)
            {
                if (!line.StartsWith("d"))
                {

                    rutas.Add(filename(line));

                }
                if (!line.StartsWith("d"))
                {
                    Console.WriteLine($"\nDirectory List Complete, status {response.StatusDescription}.");
                }
                else
                {
                    Console.WriteLine("\nThere aren't files to download.");
                }
                line = reader.ReadLine();
            }

            reader.Close();
            response.Close();
            return rutas;
        }


        public static void rename(string linea)
        {
            FtpWebRequest ftpRequest = null;
            FtpWebResponse ftpResponse = null;
            try
            {
                //ruta classe
                //ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://g1@10.0.1.220//home//g1" + "//" + linea );

                //ruta servidor propi
                ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://51.83.97.10//home//utinni//ftp//" + linea );

                // Escola
                //ftpRequest.Credentials = new NetworkCredential("g1", "12345aA");

                // Server
                ftpRequest.Credentials = new NetworkCredential("utinni", "utinni");

                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                ftpRequest.RenameTo = ".//Tractats//" + linea;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpResponse.Close();
                ftpRequest = null;
                Console.WriteLine(linea + " moved to 'Tractats'.\n");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}