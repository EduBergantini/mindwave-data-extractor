using System.IO;

namespace BrainsOfTomorrow.MindWave.Core.Loggers.Bases
{
    public abstract class StreamWriterLog : IRecordableLog
    {
        private readonly StreamWriter _streamWritter;

        protected StreamWriterLog(string filePath)
        {
            _streamWritter = new StreamWriter(filePath);
        }

        public void RegisterLog(string register)
        {
            _streamWritter.WriteLine(register);
            _streamWritter.Flush();
        }

        public void Dispose()
        {
            _streamWritter?.Dispose();
        }
    }
}