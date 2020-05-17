using System;
using System.IO;
using AsyncOperations.LanguageExtensions;
using static System.IO.File;

namespace AsyncOperations.Classes
{

    public static class Exceptions
    {
        /// <summary>
        /// Write Exception information to UnhandledException.txt in the executable folder.
        /// </summary>
        /// <param name="exception"></param>
        public static void Write(Exception exception)
        {
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UnhandledException.txt");
            if (Exists(fileName))
            {
                var contents = ReadAllText(fileName);
                var current = exception.ToLogString(Environment.StackTrace);
                var data = $"{contents}{Environment.NewLine}{current}{Environment.NewLine}";
                WriteAllText(fileName, data);
            }
            else
            {
                WriteAllText(fileName, exception.ToLogString(Environment.StackTrace) + Environment.NewLine);
            }
        }
    }
}
