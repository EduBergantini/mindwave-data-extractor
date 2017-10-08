using BrainsOfTomorrow.MindWave.Core.Domain.Controllers.Bases;
using BrainsOfTomorrow.MindWave.Core.Domain.Entities;
using ThinkGearNET;

namespace BrainsOfTomorrow.MindWave.Core.Domain.Controllers
{
    public class ThinkGearController : CommunicationControllerBase
    {
        private readonly ThinkGearWrapper _gearWrapper;
        public ThinkGearController()
            :base(IntegrationType.Direct)
        {
            _gearWrapper = new ThinkGearWrapper();
            _gearWrapper.ThinkGearChanged += OnThinkGearChanged;
        }

        private void OnThinkGearChanged(object sender, ThinkGearChangedEventArgs e)
        {
            DataReceived?.Invoke(sender, e);
        }

        public override bool Connect(SerialConfigurator configurator)
        {
            return _gearWrapper.Connect(configurator.ComPort, configurator.BaudRate, true, configurator.SaveLog);
        }

        public override void ChangeBlinkState(bool enable)
        {
            _gearWrapper.EnableBlinkDetection(enable);
        }

        public override void Disconnect()
        {
            _gearWrapper.Disconnect();
        }

        public override void Dispose()
        {
            Disconnect();
        }
    }
}