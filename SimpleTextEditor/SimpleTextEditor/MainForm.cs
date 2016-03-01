using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace SimpleTextEditor
{
    public partial class MainForm : Form
    {
        DocumentStatus DS;
        public MainForm()
        {
            InitializeComponent();
            DS = new DocumentStatus(null, this);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            DS.Changed = true;
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
    }
}
