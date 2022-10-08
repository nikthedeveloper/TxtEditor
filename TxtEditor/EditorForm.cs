using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logger;

namespace TxtEditor
{
    public partial class EditorForm : Form
    {

        static DebugMessages msgs = DebugMessages.GetInstance(false);

        string filePath;
        string fileName;
        string fileText;

        public EditorForm()
        {
            InitializeComponent();
            msgs.Log("Запущена форма", EnumMessages.START);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            msgs.Log("Кнопка закрыть", EnumMessages.LOG);
            //this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            msgs.Log("Кнопка создать", EnumMessages.LOG);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            msgs.Log("Кнопка открыть", EnumMessages.LOG);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            msgs.Log("Кнопка сохранить", EnumMessages.LOG);
        }

        private void saveHowButton_Click(object sender, EventArgs e)
        {
            msgs.Log("Кнопка сохранить как", EnumMessages.LOG);
            //SaveFileDialog save = new SaveFileDialog();
            //save.ShowDialog();
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            msgs.Log("Кнопка шрифтов", EnumMessages.LOG);
            //FontDialog fd = new FontDialog();
            //fd.ShowDialog();
        }

    }
}
