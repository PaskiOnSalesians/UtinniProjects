using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;


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
                        download();
                        break;
                    case "E":
                        //edi();
                        break;
                    default:
                        Console.Write("ERROR. OPCIÓ NO DISPONIBLE.\n");
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
        private static void download()
        {
            //Ruta de classe
            string rutadades = "ftp://g1@10.0.1.220//home//g1";

            //Ruta servidor propi
            //string rutaprincipal = "";

            List<string> ruta = AgafarRuta();
            foreach (var document in ruta)
            {
                try
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(rutadades + "//" + document);

                    //Ruta de classe
                    request.Credentials = new NetworkCredential("g1", "12345aA");

                    //Ruta servidor propi
                    //request.Credentials = new NetworkCredential("g1", "12345aA");

                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(responseStream);
                    string contingut = reader.ReadToEnd();
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



        public void nomfitxer (string Fitxer) //Canviar una mica? ni que sigui variables
        {
            Stack<char> vomiton = new Stack<char>();
            string lineacortada = "";
            char caracter = 'h';

            for (int i = Fitxer.Length; i > 0; i--)
            {
                if (caracter != ' ')
                {
                    caracter = Fitxer[i - 1];
                    vomiton.Push(caracter);
                }
                else
                {
                    i = 0;
                }

            }
            foreach (var item in vomiton)
            {
                lineacortada += item;
            }

            return lineacortada.Trim();

        }


        private static List<string> AgafarRuta()
        {
            List<string> rutas = new List<string>();
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://10.0.1.220//home//g1");
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            // This example assumes the FTP site uses anonymous logon.
            //Ruta Classe
            request.Credentials = new NetworkCredential("g1", "12345aA");

            ////Ruta servidor propi
            //request.Credentials = new NetworkCredential("g1", "12345aA");

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string linea = reader.ReadLine();

            while (linea != null)
            {
                if (!linea.StartsWith("d"))
                {

                    rutas.Add(nomfitxer(linea));

                }
                if (!linea.StartsWith("d"))
                {
                    Console.WriteLine($"\nDirectory List Complete, status {response.StatusDescription}");
                }
                else
                {
                    Console.WriteLine("\nThere arent files to download");
                }
                linea = reader.ReadLine();
            }


            reader.Close();
            response.Close();
            return rutas;

        }


        public void rename(string linea)
        {
            FtpWebRequest ftpRequest = null;
            FtpWebResponse ftpResponse = null;
            try
            {
                //ruta classe
                ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://g1@10.0.1.220//home//g1" + "//" + linea );

                //ruta servidor propi
                //ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://g1@10.0.1.220//home//g1" + "//" + linea );


                ftpRequest.Credentials = new NetworkCredential("g1", "12345aA");
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                ftpRequest.RenameTo = ".//Tractats" + "//" + linea;
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                ftpResponse.Close();
                ftpRequest = null;
                Console.WriteLine(linea + " moved to 'Tractats'\n");
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
    }
}