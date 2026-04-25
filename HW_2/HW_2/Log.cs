namespace HW_2
{
    public static class Log
    {
        private const string LogPath = "system_log.txt";
        public static void WriteLog(string message)
        {
            using (StreamWriter writer = File.AppendText(LogPath))
            {
                string logEntry = $"{DateTime.Now}: {message}";
                writer.WriteLine(logEntry);
            }
        }
    }
}
