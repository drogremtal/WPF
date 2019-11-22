using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Singleton
{
    class Logger : Singleton<Logger>
    {
        string LogFilePath = "log.txt";
        StreamWriter stream;
        
        Logger()
        {
            stream = new StreamWriter(LogFilePath);
        }        
 
        public void WriteLogErrorMsg(string msg)
        {
            stream.WriteLine(DateTime.Now + msg + ";");
        }

        public void WriteLogErrorMsg(Exception exception)
        {
            stream.WriteLine(DateTime.Now + exception.ToString() + ";");
        }
    }
}
