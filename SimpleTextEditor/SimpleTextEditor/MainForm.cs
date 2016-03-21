using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;


namespace SimpleTextEditor
{
    public partial class MainForm : Form
    {
        private delegate void ProfanityChecker();
        DocumentStatus DS;
        public List<string> ProfaneWords { get; set; } = new List<string>();
        private bool ProfanityActive { get; set; } = false;
        ProfanityForm FilterForm = null;
        
        Thread FilterThread;

        public MainForm()
        {
            InitializeComponent();
            DS = new DocumentStatus(null, this);
            FilterForm = new ProfanityForm(this);
            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
        }

        public void ActivateFilter(bool state)
        {
            ProfanityActive = state;
            ThreadStart FM = new ThreadStart(FilterMethod);
            FilterThread = new Thread(FM);
            if (state)
            {
                FilterThread.Start();
            }
            else
            {
                FilterThread.Abort();
            }
        }

        private void FilterMethod()
        {
            ProfanityChecker PF = new ProfanityChecker(ProfanityFilter);
            while (ProfanityActive)
            {
                this.Invoke(PF);
                Thread.Sleep(200);
            }
        }

        private void ProfanityFilter()
        {
            foreach (string s in ProfaneWords)
            {
                int pos = richTextBox.SelectionStart;
                richTextBox.Text = richTextBox.Text.Replace(s, new string('*', s.Length));
                richTextBox.SelectionStart = pos;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            DS.Changed = true;
        }

        private DialogResult SaveChanges()
        {
            if (DS.Changed)
            {
                return MessageBox.Show("Do you want to save your changes to this document?",
                    "Save changes?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }
            return DialogResult.No;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult SC = SaveChanges();
            if (SC == DialogResult.Yes)
            {
                saveToolStripMenuItem_Click(sender, e);
            }
            if ((DS.Changed == false)||(SC == DialogResult.No))
            {
                richTextBox.Clear();
                DS = new DocumentStatus(null, this);
                DS.Changed = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            if (SaveChanges() == DialogResult.No)
            {
                DS = new DocumentStatus(openFileDialog.FileName, this);
                DS.Changed = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DS.FileName != null)
            {
                richTextBox.SaveFile(DS.FileName, RichTextBoxStreamType.PlainText);
                DS.Changed = false;
            }
            else
            {
                saveFileDialog.ShowDialog();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            richTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
            DS.Changed = false;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindForm find = new FindForm(this);
            find.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string[] GetText()
        {
            return richTextBox.Lines;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanUndo)
            {
                richTextBox.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.CanRedo)
            {
                richTextBox.Redo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, richTextBox.SelectedText);
            richTextBox.Text = richTextBox.Text.Remove(richTextBox.SelectionStart, richTextBox.SelectedText.Length);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, richTextBox.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int pos = richTextBox.SelectionStart;
            richTextBox.Text = richTextBox.Text.Insert(pos, Clipboard.GetText());
            richTextBox.SelectionStart = pos + Clipboard.GetText().Length;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is version " + Application.ProductVersion + " of Simple Text Editor", 
                "About Simple Text Editor...", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information, 
                MessageBoxDefaultButton.Button1);
        }

        private void profinityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterForm.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            FilterThread.Abort();
        }
    }
}
