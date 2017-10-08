using System;
using System.Globalization;
using System.Text;
using BrainsOfTomorrow.MindWave.Core.Loggers.Entities.Enums;

namespace BrainsOfTomorrow.MindWave.Core.Loggers.Entities
{
    public class Log
    {
        public Guid Id { get; private set; }
        public DateTime Date { get; private set; }
        public string Message { get; private set; }
        public ErrorType Type { get; private set; }

        public static Log RegisterSuccess(string message, params object[] parameters)
        {
            return Register(ErrorType.Success, message, parameters);
        }

        public static Log RegisterInformation(string message, params object[] parameters)
        {
            return Register(ErrorType.Information, message, parameters);
        }

        public static Log RegisterWarning(string message, params object[] parameters)
        {
            return Register(ErrorType.Warning, message, parameters);
        }

        public static Log RegisterError(string message, params object[] parameters)
        {
            return Register(ErrorType.Error, message, parameters);
        }

        public static Log RegisterException(Exception exception)
        {
            return Register(ErrorType.Critical, exception.ToString());
        }

        private static Log Register(ErrorType errorType, string message, params object[] parameters)
        {
            return new Log
            {
                Date = DateTime.Now,
                Id = Guid.NewGuid(),
                Message = string.Format(message, parameters),
                Type = errorType
            };
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"[{Id}][{Date.ToString("dd/MM/yyyy HH:mm:ss:ffff", new CultureInfo("pt-BR"))}] {Type} - {Message}");
            return builder.ToString();
        }
    }
}