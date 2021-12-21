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
        public void FtpWebRequest()
        {
            FtpWebRequest ftpRequest;
            ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://myftp//myfile.txt")
        }

        static void Main(string[] args)
        {

        }
    }
}
