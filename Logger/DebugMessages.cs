using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public partial class DebugMessages
    {
        private static DebugMessages instance;

        private bool isFileSave;

        private DebugMessages(bool fs)
        {
            isFileSave = fs;
        }

        public static DebugMessages GetInstance(bool filesave)
        {
            if (instance == null)
            {
                instance = new DebugMessages(filesave);
            }
            return instance;
        }

        public void Log(string message, EnumMessages msg)
        {
            switch (msg)
            {
                case EnumMessages.START:
                    instance.StartMessage(message);
                    break;
                case EnumMessages.LOG:
                    instance.Message(message);
                    break;
                case EnumMessages.ERROR:
                    instance.ErrorMessage(message);
                    break;
            }
        }

        private void StartMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        private void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        private void Message(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }
    }
}
