using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class FindForm : Form
    {
        private MainForm mainForm = null;
        private RichTextBox TB = null;
        private int index;
        private StringComparison CompareCase;

        public FindForm(MainForm callingForm)
        {
            mainForm = callingForm as MainForm;
            TB = mainForm.richTextBox;
            index = 0;
            InitializeComponent();
            matchCaseCheckBox_CheckedChanged(this, EventArgs.Empty);
        }

        private void FindForm_Load(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int len = FindTextBox.Text.Length;
            index = FindNext(FindTextBox.Text, index);
            
            if(index != -1)
            {
                TB.Select(index, len);
            }
            else
            {
                TB.DeselectAll();
            }
            index++;
        }

        private int FindNext(string text, int startIndex)
        {
            if ((text != "")&&(index != -1))
            {
                return TB.Text.IndexOf(text, startIndex, CompareCase);
            }
            return -1;
        }

        private void FindForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FindAllButton_Click(object sender, EventArgs e)
        {
            int len = FindTextBox.Text.Length;
            index = 0;
            TB.SelectAll();
            TB.SelectionBackColor = Color.Transparent;
            TB.DeselectAll();

            while((index = FindNext(FindTextBox.Text, index)) != -1)
            {
                TB.Select(index, len);
                TB.SelectionBackColor = Color.LightBlue;
                index++;
            }
        }

        private void matchCaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(matchCaseCheckBox.Checked)
            {
                CompareCase = StringComparison.CurrentCulture;
            }
            else
            {
                CompareCase = StringComparison.CurrentCultureIgnoreCase;
            }
            index = 0;
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            if (FindTextBox.Text != "")
            {
                index = FindNext(FindTextBox.Text, index);
            }
            if (index != -1)
            {
                TB.Select(index, FindTextBox.Text.Length);
                TB.SelectedText = TB.SelectedText.Replace(TB.SelectedText, ReplaceTextBox.Text);
            }
        }

        private void ReplaceAllButton_Click(object sender, EventArgs e)
        {
            if (FindTextBox.Text != "")
            {
                TB.Text = TB.Text.Replace(FindTextBox.Text, ReplaceTextBox.Text);
            }
        }
    }
}
