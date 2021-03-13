/// ETML
/// Autor : Sébastien Duruz
/// Date : 12.03.2021
/// Description : Log class, log different informations from projects events, can be called anywhere.

using System;
using System.IO;

namespace sebduruz_indexTestProject.Logging
{
    /// <summary>
    /// Class Log
    /// </summary>
    public static class Log
    {
        /// <summary>
        /// Attributs
        /// </summary>
        private static string _lastLog;
        private static readonly string _filePath = Path.Combine(Environment.CurrentDirectory, "log.txt");

        /// <summary>
        /// LogLevel Enum
        /// </summary>
        private enum LogLevel
        {
            INFO,
            WARNING,
            ERROR,
            CRITICAL,
        }

        /// <summary>
        /// Create a log save it into _lastLog
        /// </summary>
        /// <param name="type">The log level</param>
        /// <param name="logMessage">The message to log</param>
        public static void CreateLog(byte type, string logMessage)
        {
            _lastLog = $" [{DateTime.Now}] [{(LogLevel)type}] [{logMessage}]"; //Create the log message
            PrintLog();
            WriteLogFile();
        }

        /// <summary>
        /// Print the lastLog message onto console
        /// </summary>
        private static void PrintLog()
        {
            Console.WriteLine(_lastLog);
        }

        /// <summary>
        /// Write Log onto file
        /// </summary>
        private static void WriteLogFile()
        {
            File.AppendAllText(_filePath, $"{_lastLog}{Environment.NewLine}"); //Add a line to the file with the log message
        }
    }
}
