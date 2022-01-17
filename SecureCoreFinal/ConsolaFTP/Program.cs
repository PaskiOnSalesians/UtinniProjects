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
                        download();
                        break;
                    case "E":
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

            // **SEQUENCIA PER BAIXAR EL FITXER**


            //FtpWebRequest ftpRequest;
            //ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://myftp/myfile.txt")
            //strUser = "Josep";
            //strPassword = "12345";
            //ftpRequest.Credentials = new NetworkCredential(strUser, strPassword);

            //ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;

            //FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();

            //Stream responseStream = response.GetResponseStream();
            //StreamReader reader = new StreamReader(responseStream);
            //string contingut = reader.ReadToEnd();
            //File.WriteAllText("FitxerDescarregat.txt", contingut);

            //Console.WriteLine($"Download Complete, status {response.StatusDescription}");
            //reader.Close();
            //response.Close();


            // **SEQUENCIA PER BAIXAR RENOMBRAR EL FITXER**
            //rename();
        }

        public void nomfitxer (string Fitxer)
        {
            //trobem fitxers que tenen data i hora. per tant es buscara fer un for invers per tal que sol agafi l'extensio i el nom del fitxer

            //{
            //    char[] charArray = text.ToCharArray();
            //    string reverse = String.Empty;
            //    for (int i = charArray.Length - 1; i >= 0; i--)
            //    {
            //        reverse += charArray[i];
            //    }
            //    return reverse;
            //}



        }

        public void rename(string currentFileNameAndPath, string newFileName)
        {
            //try
            //{
            //    /* Create an FTP Request */
            //    ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + currentFileNameAndPath);
            //    /* Log in to the FTP Server with the User Name and Password Provided */
            //    ftprequest.credentials = new networkcredential(user, pass);
            //    /* when in doubt, use these options */
            //    ftprequest.usebinary = true;
            //    ftprequest.usepassive = false;
            //    ftprequest.keepalive = false;
            //    ftprequest.proxy = null;
            //    /* specify the type of ftp request */
            //    ftprequest.method = webrequestmethods.ftp.rename;
            //    /* rename the file */
            //    ftprequest.renameto = newfilename;
            //    /* establish return communication with the ftp server */
            //    ftpresponse = (ftpwebresponse)ftprequest.getresponse();
            //    /* resource cleanup */
            //    ftpresponse.close();
            //    ftprequest = null;
            //}
            //catch (exception ex)
            //{
            //    messagebox.show(ex.tostring());
            //}

            //return;
        }
    }
}