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
    class ConsoleApp
    {
        
        static DataSet dts;
        const string pathedi = "../RAREDI_2.edi";
        const string ediFileServer = "ftp://51.83.97.10:21//home/utinni/ftp/RAREDI_2.edi";
        const string directoryServer = "ftp://51.83.97.10:21//home/utinni/ftp/";

        [STAThread]
        static void Main(string[] args)
        {
            string opcio, msgProcessat;
            bool correctOrder;


            Welcome();
            do
            {
                Menu();

                Console.Write("Opcio: ");
                opcio = Console.ReadLine().ToUpper().Trim();

                Console.Title = "Utinni Console";

                if (opcio.Length > 1)
                {
                    Console.Write("Torna a introduïr l'opcio: ");
                    opcio = Console.ReadLine().ToUpper().Trim();
                }

                switch (opcio)
                {
                    case "P":
                        UploadFile();
                        break;
                    case "B":
                        DownloadFile();
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
                    case "C":
                        Console.Clear();
                        break;
                    case "S":
                        break;
                    default:
                        Console.Write("ERROR. OPCIÓ NO DISPONIBLE.\n");
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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{grupo}");

            String text = File.ReadAllText(Application.StartupPath + "\\..\\resources\\ascii_console.txt");
            Console.WriteLine(text);
        }

        private static void Menu()
        {
            Console.WriteLine("*-----------------------------------------*");
            Console.WriteLine("|                 MAIN MENU               |");
            Console.WriteLine("*-----------------------------------------*");
            Console.WriteLine("|  P: Pujar fitxers al servidor FTP       |");
            Console.WriteLine("|  B: Baixar fitxers des del servidor FTP |");
            Console.WriteLine("|  E: Processat de fitxer EDI             |");
            Console.WriteLine("|  V: Veure el fitxer processat           |");
            Console.WriteLine("|  C: Neteja la consola                   |");
            Console.WriteLine("|  S: Sortir                              |");
            Console.WriteLine("*-----------------------------------------*");
        }

        #region FTP - Download | Upload | Move
        private static void UploadFile()
        {
            FtpWebRequest ftpReqUp;
            string username, password, filepath;

            try
            {
                using (OpenFileDialog openFiles = new OpenFileDialog())
                {
                    openFiles.InitialDirectory = Application.StartupPath + "\\..\\resources\\";
                    openFiles.Filter = "edi files (*.edi)|*.edi|All Files(*.*)|*.*";
                    openFiles.FilterIndex = 1;
                    openFiles.RestoreDirectory = true;

                    if (openFiles.ShowDialog() == DialogResult.OK)
                    {
                        filepath = openFiles.FileName;

                        Console.WriteLine(filepath);

                        FileInfo fileInf = new FileInfo(filepath);
                        ftpReqUp = (FtpWebRequest)WebRequest.Create(ediFileServer);

                        username = "utinni";
                        password = "utinni";

                        ftpReqUp.Credentials = new NetworkCredential(username, password);
                        ftpReqUp.KeepAlive = true;
                        ftpReqUp.UsePassive = false;
                        ftpReqUp.EnableSsl = false;

                        ftpReqUp.Method = WebRequestMethods.Ftp.UploadFile;
                        ftpReqUp.UseBinary = true;

                        StreamReader sr = new StreamReader(filepath);
                        byte[] data = Encoding.UTF8.GetBytes(sr.ReadToEnd());
                        sr.Close();

                        Stream requestStream = ftpReqUp.GetRequestStream();
                        requestStream.Write(data, 0, data.Length);
                        requestStream.Close();
                    }
                }

                Console.WriteLine("File Uploaded!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    "We have some serious problems with the upload, boss!\n" +
                    "This is the Exception:\n\n" + ex.ToString(), "Utinni Devs"
                );
            }
        }

        private static void DownloadFile()
        {
            var files = GetDirectoryFiles(".edi", "utinni", "utinni");
            string folderPC = Application.StartupPath + "\\..\\resources\\";
            string newFolderFtp = "/home/utinni/ftp/Tractats/";

            if(files.Count > 0)
            {
                foreach (string file in files)
                {
                    // Hem de tenir 2 mètodes per millor visualització
                    // File to download | username | password | newFolder
                    GetFile(file, "utinni", "utinni", folderPC + "_downloaded_");
                    MoveFile(file, "utinni", "utinni", newFolderFtp);
                }
            }
            else
            {
                Console.WriteLine("No .edi file available!");
            }
        }

        private static void GetFile(string fileName, string username, string password, string filepath)
        {
            try
            {
                FtpWebRequest req = (FtpWebRequest)WebRequest.Create(directoryServer + fileName);
                req.Credentials = new NetworkCredential(username, password);
                req.Method = WebRequestMethods.Ftp.DownloadFile;

                req.KeepAlive = true;
                req.UsePassive = false;
                req.EnableSsl = false;

                FtpWebResponse rep = (FtpWebResponse)req.GetResponse();

                Stream respStream = rep.GetResponseStream();
                StreamReader sr = new StreamReader(respStream);

                string content = sr.ReadToEnd();

                File.WriteAllText(filepath + fileName, content);
                Console.WriteLine("The file: " + fileName + " has been downloaded on: " + filepath);

                sr.Close();
                rep.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in getting File\n"+ ex.ToString());
            }
            
        }

        private static void MoveFile(string fileName, string username, string password, string newFilepath)
        {
            try
            {
                FtpWebRequest req = (FtpWebRequest)(WebRequest.Create(directoryServer + fileName));
                req.Credentials = new NetworkCredential(username, password);
                req.Method = WebRequestMethods.Ftp.Rename;

                req.RenameTo = newFilepath + fileName;

                req.UseBinary = true;

                FtpWebResponse resp = (FtpWebResponse)req.GetResponse();
                Stream strm = resp.GetResponseStream();

                Console.WriteLine("We've moved the file: " + fileName + " to the new Folder: Tractats");

                strm.Close();
                resp.Close();
                //req.GetResponse().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in moving File\n" + ex.ToString());
            }
        }

        private static List<string> GetDirectoryFiles(string fileNameExtension, string username, string password)
        {
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ediFileServer);
            req.Method = WebRequestMethods.Ftp.ListDirectory;
            req.Credentials = new NetworkCredential(username, password);

            req.EnableSsl = false;

            FtpWebResponse resp = (FtpWebResponse)req.GetResponse();

            Stream respStream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(respStream);

            List<string> files = new List<string>();

            string line = sr.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                string[] fileLine = line.Split(' ');
                string file = fileLine[fileLine.Length - 1];
                if (file.EndsWith(fileNameExtension))
                {
                    files.Add(line);
                }

                line = sr.ReadLine();
            }

            sr.Close();
            resp.Close();

            return files;
        }

        #endregion

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
                Console.WriteLine("\n              VEURE COMANDA             ");
                Console.WriteLine("------------------------------------------");
                while (linia != null)
                {
                    Console.WriteLine(linia);
                    linia = sr.ReadLine();
                }
                Console.WriteLine("------------------------------------------");
            }
            catch (Exception)
            {
                Console.WriteLine("NO S'HA POGUT VISUALITZAR");
            }
        }


    }
}