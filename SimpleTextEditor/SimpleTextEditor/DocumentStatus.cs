using System.IO;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    class DocumentStatus
    {
        string fileName = null;
        bool changed = false;
        MainForm mainForm;


        public string FileName
        {
            get { return fileName; }
        }

        public bool Changed {
            get
            {
                return changed;
            }
            set
            {
                changed = value;
                if(value == true)
                {
                    mainForm.Text = "*Simple Text Editor";
                }
                else
                {
                    mainForm.Text = "Simple Text Editor";
                }
            }
        }

        public DocumentStatus(string fileName, MainForm callingForm)
        {
            mainForm = callingForm as MainForm;
            if (File.Exists(fileName))
            {
                this.fileName = fileName;
                callingForm.richTextBox.LoadFile(fileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
