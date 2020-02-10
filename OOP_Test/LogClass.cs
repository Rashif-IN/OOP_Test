using System;
using System.Collections.Generic;
using System.IO;

namespace OOP_Test

{
    public interface ILog
    {
        DateTime Date { get; set; }
        string Message { get; set; }
    }

    public static class Log_
    {
        public static List<Log> _Log = new List<Log>(); 
        public static void SaveAllLog()
        {
            var lines = new List<string>();
            
            foreach (var X in _Log)
            {
                lines.Add($"{X.Date} INFO: {X.Message}");
            }
            File.WriteAllLines(@"/Users/user/Projects/OOP_Test/OOP_Test/app.log", lines);
        }

        public static void PopulateLog(string msg)
        {
            DateTime date = DateTime.Now;
            _Log.Add(new Log { Date = date, Message = msg });
        }
    }

    public class Log : ILog
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
