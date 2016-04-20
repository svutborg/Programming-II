using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class ProfanityForm : Form
    {
        private MainForm MF = null;

        public ProfanityForm(MainForm callingForm)
        {
            MF = callingForm as MainForm;
            InitializeComponent();
        }

        private void ProfanityForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(AddTextBox.Text != "")
            {
                bool ExistsInCollection = false;
                foreach(string s in FilterCheckedListBox.Items)
                {
                    if (AddTextBox.Text == s)
                    {
                        ExistsInCollection = true;
                    }
                }
                if(!ExistsInCollection)
                {
                    FilterCheckedListBox.Items.Add(AddTextBox.Text);
                }                
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(FilterCheckedListBox.SelectedIndex >= 0)
            {
                FilterCheckedListBox.Items.RemoveAt(FilterCheckedListBox.SelectedIndex);
            }
        }

        private void UpdateProfanityList()
        {
            MF.ProfaneWords.Clear();
            foreach(string word in FilterCheckedListBox.CheckedItems)
            {
                MF.ProfaneWords.Add(word);
            }
            //MF.ProfaneWords = FilterCheckedListBox.CheckedItems.Cast<CheckedListBox.CheckedItemCollection>().Select(item => item.ToString()).ToList();
        }

        private void ApplyFilterToolStripButton_Click(object sender, EventArgs e)
        {
            if(ApplyFilterToolStripButton.Checked)
            {
                ApplyFilterToolStripButton.Text = "Deactivate filter";
                UpdateProfanityList();
                MF.ActivateFilter(true);
            }
            else
            {
                ApplyFilterToolStripButton.Text = "Activate filter";
                MF.ProfaneWords = new List<string>();
                MF.ActivateFilter(false);
            }
        }

        private void FilterCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpdateProfanityList();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            UpdateProfanityList();
            this.Hide();
        }
    }
}
