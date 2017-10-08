namespace BrainsOfTomorrow.MindWave.Core.Domain.Entities
{
    public class SerialConfigurator
    {
        private SerialConfigurator(string comPort, int baudRate, bool saveLog)
        {
            ComPort = comPort;
            BaudRate = baudRate;
            SaveLog = saveLog;
        }

        public string ComPort { get; }
        public int BaudRate { get; }
        public bool SaveLog { get; }

        public static SerialConfigurator GetInstance(string comPort, int baudRate, bool saveLog)
        {
            return new SerialConfigurator(comPort, baudRate, saveLog);
        }
    }
}