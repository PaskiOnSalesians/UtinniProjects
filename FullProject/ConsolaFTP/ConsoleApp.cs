﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;

using AccesDades;

namespace ConsolaFTP
{
    class ConsoleApp
    {
        const string pathedi = "../RAREDI_2.edi";
        const string ediFileServer = "ftp://51.83.97.10:21//home/utinni/ftp/RAREDI_2.edi";
        const string directoryServer = "ftp://51.83.97.10:21//home/utinni/ftp/";

        static List<string> orderTable = new List<string>();
        static List<string> orderInfo = new List<string>();
        static List<string> orderDetails = new List<string>();

        static Dades _data = new Dades();

        [STAThread]
        static void Main(string[] args)
        {
            string opcio, msgProcessat = "";
            bool correctOrder = true;


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
                        correctOrder = ProcessatEDI();
                        if (correctOrder)
                        {
                            ComandesInserts();
                            Insert2();
                            Insert3();
                            msgProcessat = "El processat a tingut éxit!\n";
                        }
                        else
                        {
                            msgProcessat = "El fitxer no s'ha processat correctament\n";
                        }
                        Console.WriteLine(msgProcessat);
                        break;
                    case "V":
                        Veure();
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

        private static bool ProcessatEDI()
        {
            List<string[]> comandes = new List<string[]>();

            StreamReader sr = new StreamReader(Application.StartupPath + "/../resources/_downloaded_RAREDI_2.edi");

            sr.ReadLine();
            string line = sr.ReadLine();

            while (!string.IsNullOrEmpty(line))
            {
                string[] comanda = line.Split('|');
                comandes.Add(comanda);
                line = sr.ReadLine();
            }

            for (int i = 0; i < comandes.Count; i++)
            {
                for (int j = 0; j < comandes[i].Length; j++)
                {
                    if (comandes[i][j] == "ORD")
                    {
                        orderTable.Add(comandes[i][j + 1]); // Pedido - Orders.codeOrder
                        orderTable.Add(comandes[i][j + 2]); // Tipos - Priority.CodePriority - Orders.IdPriority
                    }
                    if (comandes[i][j] == "DTM") 
                    {
                        orderTable.Add(comandes[i][j + 1]); // Fecha - Orders.dateOrder
                    }
                    if (comandes[i][j] == "NADMS")
                    {
                        orderInfo.Add(comandes[i][j + 1]); // Area operativa - OperationalAreas.CodeOperationalArea - OrderInfo.idOperationalArea
                        orderInfo.Add(comandes[i][j + 2]); // Emisor - Agencies.CodeAgency - OrderInfo.idAgency
                    }
                    if (comandes[i][j] == "NADMR")
                    {
                        orderTable.Add(comandes[i][j + 1]); // Receptor - Factories.codeFactory - Orders.IdFactory
                    }
                    if (comandes[i][j] == "LIN")
                    {
                        orderDetails.Add(comandes[i][j + 1]); // Planeta de destino - Planets.CodePlanets - OrdersDetail.idPlanet
                        orderDetails.Add(comandes[i][j + 2]); // Codigo - Referencies.codeReference - OrdersDetail.idReference
                        orderDetails.Add(comandes[i][j + 3]); // Tipo de codigo - 
                    }
                    if (comandes[i][j] == "QTYLIN")
                    {
                        if(comandes[i][j + 1] == "21")
                        {
                            orderDetails.Add(comandes[i][j + 2]); // Cantidad
                        }
                        else
                        {
                            orderDetails.Add("-" + comandes[i][j + 2]); // Cantidad
                        }
                    }
                    if (comandes[i][j] == "DTMLIN")
                    {
                        orderDetails.Add(comandes[i][j + 1]); // Fecha entrega
                    }
                }
            }

            if(comandes.Count > 0)
            {
                return true;
            }

            return false;
        }

        private static void ComandesInserts()
        {
            DataSet idPrioridad;
            DataSet idFact;

            idPrioridad = _data.PortarPerConsulta("select idPriority from Priority where CodePriority = '" + orderTable[1] + "'", "Priority");
            idFact = _data.PortarPerConsulta("select idFactory from Factories where codeFactory = '" + orderTable[3] + "'", "Factories");
            
            //DateTime fecha = DateTime.ParseExact(orderTable[2], "YYYYMMDD", CultureInfo.InvariantCulture);

            _data.Executar("" +
                "insert into Orders(codeOrder,              dateOrder,              IdPriority,                                         IdFactory) " +
                "values (       " + orderTable[0] + "," +   "2020-05-27" + "," +    idPrioridad.Tables[0].Rows[0]["idPriority"] + "," + idFact.Tables[0].Rows[0]["idFactory"] + ");"
            );

            Console.WriteLine("Updated Orders!\n");
        }

        private static void Insert2()
        {
            DataSet idOrder = new DataSet();
            DataSet idPlanet = new DataSet();
            DataSet idReference = new DataSet();

            idOrder = _data.PortarPerConsulta("select idOrder from [Orders] where codeOrder = '" + orderTable[0] + "' order by dateOrder desc", "Orders");
            idPlanet = _data.PortarPerConsulta("select idPlanet from [Planets] where CodePlanet = '" + orderDetails[0] + "'", "Planets");
            idReference = _data.PortarPerConsulta("select idReference from [References] where codeReference = '" + orderDetails[1] + "'", "References");

            _data.Executar(
                "insert into OrdersDetail(idOrder,                                      idPlanet,                                       idReference,                                            Quantity,                           DeliveryDate)" +
                "values(              " + "484" + "," +  idPlanet.Tables[0].Rows[0]["idPlanet"] + "," +  idReference.Tables[0].Rows[0]["idReference"] + "," +    int.Parse(orderDetails[3]) + "," +  "2020-05-27" + ");"
            );

            Console.WriteLine("Updated OrderDetails!\n");
        }

        private static void Insert3()
        {
            DataSet idOperationalArea;
            DataSet idAgency;
            DataSet idOrder;

            idOperationalArea = _data.PortarPerConsulta("select idOperationalArea from OperationalAreas where CodeOperationalArea = '" + orderInfo[0] + "'");
            idAgency = _data.PortarPerConsulta("select idAgency from Agencies where CodeAgency = '" + orderInfo[1] + "'");
            idOrder = _data.PortarPerConsulta("select idOrder from Orders where codeOrder = '" + orderTable[0] + "'");

            _data.Executar("" +
                "insert into OrderInfo(idOrder, idAgency, idOperationalArea)" +
                "values(484," + idAgency.Tables[0].Rows[0]["idAgency"] + "," + idOperationalArea.Tables[0].Rows[0]["idOperationalArea"] + ");"
            );

            Console.WriteLine("Updated OrderInfo!\n");
        }

        private static void Veure()
        {
            try
            {
                //DataSet dts = new DataSet();

                //dts = _data.PortarPerConsulta("select top 1 * from Orders order by idOrder asc", "Orders");

                int idOrder = 484; //int.Parse(dts.Tables[0].Columns[0].ToString()); // Rows[0]["idOrder"]

                Application.EnableVisualStyles();
                CrystalLlistat llistat = new CrystalLlistat();

                llistat.agafarid(idOrder);
                Application.Run(llistat);
            }
            catch (Exception)
            {

                Console.WriteLine("NO S'HA POGUT VISUALITZAR");
            }
        }
    }
}
