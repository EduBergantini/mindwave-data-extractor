using System;
using BrainsOfTomorrow.MindWave.Core.Domain.Entities;
using ThinkGearNET;

namespace BrainsOfTomorrow.MindWave.Core.Domain.Controllers.Bases
{
    public abstract class CommunicationControllerBase : IDisposable
    {
        public IntegrationType IntegrationType { get; }

        protected CommunicationControllerBase(IntegrationType integrationType)
        {
            IntegrationType = integrationType;
        }

        public Action<object, EventArgs> DataReceived;

        public abstract bool Connect(SerialConfigurator configurator);
        public abstract void ChangeBlinkState(bool enable);
        public abstract void Disconnect();
        public abstract void Dispose();
    }

    public enum IntegrationType
    {
        Direct,
        Arduino
    }
}