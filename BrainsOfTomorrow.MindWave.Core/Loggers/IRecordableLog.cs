using System;

namespace BrainsOfTomorrow.MindWave.Core.Loggers
{
    public interface IRecordableLog : IDisposable
    {
        void RegisterLog(string register);
    }
}