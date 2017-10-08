using System;
using System.IO;
using BrainsOfTomorrow.MindWave.Core.Loggers.Bases;

namespace BrainsOfTomorrow.MindWave.Core.Loggers
{
    public class CsvLog : StreamWriterLog
    {
        public CsvLog(string csvHeader) 
            : base(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"info_{DateTime.Now:yyyyMMddHHmmss}.csv"))
        {
            RegisterLog(csvHeader);
        }
    }
}