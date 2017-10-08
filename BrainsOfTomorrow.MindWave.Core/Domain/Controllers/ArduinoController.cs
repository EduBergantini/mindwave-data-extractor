using System;
using System.IO.Ports;
using BrainsOfTomorrow.MindWave.Core.Domain.Controllers.Bases;
using BrainsOfTomorrow.MindWave.Core.Domain.Entities;

namespace BrainsOfTomorrow.MindWave.Core.Domain.Controllers
{
    public class ArduinoController : CommunicationControllerBase
    {
        private SerialPort _serialPort;

        public ArduinoController() : base(IntegrationType.Arduino)
        {
        }

        public override bool Connect(SerialConfigurator configurator)
        {
            try
            {
                _serialPort = new SerialPort(configurator.ComPort, configurator.BaudRate, Parity.Even);
                _serialPort.DataReceived += (sender, args) => DataReceived(sender, args);
                _serialPort.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public override void ChangeBlinkState(bool enable)
        {
        }

        public override void Disconnect()
        {
            try
            {
                _serialPort.Close();
                _serialPort.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public override void Dispose()
        {
            Disconnect();
        }
    }
}