using System;

namespace Lindra_Market_v3.Tools.ExternalConsole.Models
{
    public class ConsoleHistoryEntry
    {
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public string Command { get; set; } = string.Empty;
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;

        public string FormattedTime => Timestamp.ToString("HH:mm:ss");
    }
}
