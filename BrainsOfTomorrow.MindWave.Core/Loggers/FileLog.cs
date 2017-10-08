using System;
using System.IO;
using BrainsOfTomorrow.MindWave.Core.Loggers.Bases;

namespace BrainsOfTomorrow.MindWave.Core.Loggers
{
    public class FileLog : StreamWriterLog
    {
        public FileLog() 
            : base(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"rawData_{DateTime.Now:yyyyMMddHHmmss}.log"))
        {
        }
    }
}