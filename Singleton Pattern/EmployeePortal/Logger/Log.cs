using System;
using System.IO;
using System.Text;
using context = System.Web.HttpContext;

namespace Logger
{
    public class Log : ILog
    {
        private Log()
        {
        }
        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());

        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        public void LogException(string message)
        {
            
            string fileName = "Exception" + DateTime.Today.ToString("dd-MM-yy") + ".txt";

            string filepath = AppDomain.CurrentDomain.BaseDirectory;
            if(!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(filepath + "/Log/Error.txt",false))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }

        }
    }
}
