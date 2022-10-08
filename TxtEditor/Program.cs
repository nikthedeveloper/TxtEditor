using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logger;

namespace TxtEditor
{
    static class Program
    {

        static DebugMessages msgs = DebugMessages.GetInstance(false);
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            msgs.Log("Приложение запущено", EnumMessages.START);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EditorForm());
        }
    }
}
