using System;
using System.Globalization;
using System.Text;
using ThinkGearNET;

namespace BrainsOfTomorrow.MindWave.Core.Domain.Builders
{
    public class CsvBuilder
    {
        private static readonly string MachineListSeparator;

        static CsvBuilder()
        {
            MachineListSeparator = CultureInfo.CurrentCulture.TextInfo.ListSeparator;
        }

        public static string BuildHeader(IFormatProvider formatProvider)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat(formatProvider, "{0}", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Versão", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Bateria", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Sinal", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Atenção", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Meditação", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Piscada", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Alfa alta", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Alfa baixa", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Beta alta", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Beta baixa", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Gamma alta", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Gamma baixa", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Delta", MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", "Theta", MachineListSeparator);
            return stringBuilder.ToString();
        }

        public static string BuildInformation(IFormatProvider formatProvider, ThinkGearState thinkGearState)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", DateTime.Now.ToString("G", formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Version.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Battery.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.PoorSignal.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Attention.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Meditation.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.BlinkStrength.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Alpha1.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Alpha2.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Beta1.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Beta2.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Gamma1.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Gamma2.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Delta.ToString(formatProvider), MachineListSeparator);
            stringBuilder.AppendFormat(formatProvider, "{0}{1}", thinkGearState.Theta.ToString(formatProvider), MachineListSeparator);
            return stringBuilder.ToString();
        }
    }
}