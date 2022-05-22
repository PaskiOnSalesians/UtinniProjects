using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Data;
using System.Windows.Forms;

namespace ConsolaFTP
{
    class Console
    {
        
        static DataSet dts;
        const string pathedi = "../RAREDI_2.edi";

        [STAThread]
        static void Main(string[] args)
        {
            string opcio, msgProcessat;
            bool correctOrder;


            Welcome();
            do
            {
                Menu();

                System.Console.Write("Opcio: ");
                opcio = System.Console.ReadLine().ToUpper().Trim();

                System.Console.Title = "Utinni Console";

                if (opcio.Length > 1)
                {
                    System.Console.Write("Torna a introduïr l'opcio: ");
                    opcio = System.Console.ReadLine().ToUpper().Trim();
                }

                switch (opcio)
                {
                    case "P":
                        UploadFilesAsync();
                        break;
                    case "D":
                        DownloadFiles();
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
                        System.Console.WriteLine(msgProcessat);
                        break;
                    case "V":
                        veure();
                        break;
                    case "S":
                        break;
                    default:
                        System.Console.Write("ERROR. OPCIÓ NO DISPONIBLE.\n");
                        break;
                }
            } while (opcio != "S");
        }

        private static void Welcome()
        {
            string grupo = "" +
                "██╗   ██╗████████╗██╗███╗   ██╗███╗   ██╗██╗\n" +
                "██║   ██║╚══██╔══╝██║████╗  ██║████╗  ██║██║\n" +
                "██║   ██║   ██║   ██║██╔██╗ ██║██╔██╗ ██║██║\n" +
                "██║   ██║   ██║   ██║██║╚██╗██║██║╚██╗██║██║\n" +
                "╚██████╔╝   ██║   ██║██║ ╚████║██║ ╚████║██║\n" +
                " ╚═════╝    ╚═╝   ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚═╝\n";

            System.Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.Write($"{grupo}");
            System.Console.Write("               ____==========_______\n");
            System.Console.Write("    _--____   |    | ''  ' ''|      \\\n");
            System.Console.Write("   /  )8}  ^^^| 0  |  =     |  o  0  |\n");
            System.Console.Write(" </_ +-==B vvv|''  |  =     | '  '' ' | \n");
            System.Console.Write("    \\_____/   |____|________|________|\n");
            System.Console.Write("             (_(  )\\________/___(  )__)\n");
            System.Console.Write("               |\\  \\            /  /\\\n");
            System.Console.Write("               | \\  \\          /  /\\ \\\n");
            System.Console.Write("                | |\\  \\        /  /  \\ \\\n");
            System.Console.Write("               (  )(  )       (  \\   (  )\n");
            System.Console.Write("                \\  / /        \\  \\   \\  \\\n");
            System.Console.Write("                 \\|  |\\        \\  \\  |  |\n");
            System.Console.Write("                  |  | )____    \\  \\ \\  )___\n");
            System.Console.Write("                  (  )  /  /    (  )  (/  /\n");
            System.Console.Write("                 /___\\ /__/     /___\\ /__/\n");
        }

        private static void Menu()
        {
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("P: Pujar fitxers al servidor FTP");
            System.Console.WriteLine("B: Baixar fitxers des del servidor FTP");
            System.Console.WriteLine("E: Processat de fitxer EDI");
            System.Console.WriteLine("V: Veure el fitxer processat");
            System.Console.WriteLine("S: Sortir");
            System.Console.WriteLine("----------------------------------");
        }

        private static void UploadFilesAsync()
        {
            FtpWebRequest ftpReqUp;
            string username, password, filepath = string.Empty, fileContent = string.Empty;
            string path;

            try
            {
                using (OpenFileDialog openFiles = new OpenFileDialog())
                {
                    openFiles.InitialDirectory = Path.GetFullPath(Application.StartupPath + "\\..\\resources");
                    openFiles.Filter = "edi files (*.edi)|*.edi|All Files(*.*)|*.*";
                    openFiles.FilterIndex = 1;
                    openFiles.RestoreDirectory = true;

                    if (openFiles.ShowDialog() == DialogResult.OK)
                    {
                        filepath = openFiles.FileName;

                        ftpReqUp = (FtpWebRequest)WebRequest.Create("ftp://51.83.97.10//home//utinni//ftp//" + filepath);

                        username = "utinni";
                        password = "utinni";

                        ftpReqUp.Credentials = new NetworkCredential(username, password);

                        ftpReqUp.Method = WebRequestMethods.Ftp.UploadFile;

                        path = Path.GetFullPath(Application.StartupPath + filepath);

                        byte[] content = File.ReadAllBytes(path);
                        ftpReqUp.ContentLength = content.Length;
                        Stream stream = ftpReqUp.GetRequestStream();
                        stream.Write(content, 0, content.Length);
                        stream.Close();
                    }

                    System.Console.WriteLine("File Uploaded!");
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "We have some serious problems with the upload, boss!\n" +
                    "This is the Exception:\n" + ex.ToString(), "Utinni Devs"
                );
            }
        }

        private static void DownloadFiles()
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
                    System.Console.WriteLine($"Download Complete, status {response.StatusDescription}");
                    reader.Close();
                    response.Close();
                    rename(document);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString()); ;

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
            string tallarlinea = ""; // linia tallada
            char c = 'h'; // caracter

            for (int i = file.Length; i > 0; i--)
            {
                if (c != ' ')
                {
                    c = file[i - 1];
                    charStack.Push(c);
                }
                else
                {
                    i = 0;
                }

            }
            foreach (var item in charStack)
            {
                tallarlinea += item;
            }

            return tallarlinea.Trim();
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
                    System.Console.WriteLine($"\nDirectory List Complete, status {response.StatusDescription}.");
                }
                else
                {
                    System.Console.WriteLine("\nThere aren't files to download.");
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
                System.Console.WriteLine(linea + " moved to 'Tractats'.\n");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
    }
}