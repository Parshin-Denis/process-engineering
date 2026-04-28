using System;
using System.IO;
using System.Windows.Forms;

namespace Process_Engineering
{
    internal class Logger
    {
        private const string errorLogParh = "Log\\";
        private const string cgDialogPath = "Log\\CG\\";
        private const string mesLogPath = "Log\\MES\\";
        public static void logError(string message)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                File.AppendAllText($"{errorLogParh}log{dateTime.DayOfYear}.txt", $"{dateTime} {message} {Environment.NewLine}");
            }
            catch
            {
                MessageBox.Show("Ошибка записи в файл ERROR LOG");
            }
        }

        public static void logMes(string message)
        {
            try
            {
                DateTime dateTime = DateTime.Now;
                File.AppendAllText($"{mesLogPath}log{dateTime.DayOfYear}.txt", $"{dateTime} {message} {Environment.NewLine}");
            }
            catch
            {
                MessageBox.Show("Ошибка записи в файл MES LOG");
            }
        }
    }
}
