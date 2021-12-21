using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFTP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Console Settings

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Utinni FTP Service";

            #endregion

            #region FTP

            string user, password;

            FtpWebRequest ftpRequest;
            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://myftp//myfile.txt");

            user = "Josep";
            password = "12345";
            ftpRequest.Credentials = new NetworkCredential(user, password);

            #endregion 
        }
    }
}
