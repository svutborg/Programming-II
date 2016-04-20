namespace SimpleTextEditor
{
    partial class ProfanityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfanityForm));
            this.FilterToolStrip = new System.Windows.Forms.ToolStrip();
            this.ApplyFilterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.FilterCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.FilterToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilterToolStrip
            // 
            this.FilterToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ApplyFilterToolStripButton});
            this.FilterToolStrip.Location = new System.Drawing.Point(0, 0);
            this.FilterToolStrip.Name = "FilterToolStrip";
            this.FilterToolStrip.Size = new System.Drawing.Size(319, 25);
            this.FilterToolStrip.TabIndex = 1;
            // 
            // ApplyFilterToolStripButton
            // 
            this.ApplyFilterToolStripButton.CheckOnClick = true;
            this.ApplyFilterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ApplyFilterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ApplyFilterToolStripButton.Image")));
            this.ApplyFilterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApplyFilterToolStripButton.Name = "ApplyFilterToolStripButton";
            this.ApplyFilterToolStripButton.Size = new System.Drawing.Size(81, 22);
            this.ApplyFilterToolStripButton.Text = "Activate filter";
            this.ApplyFilterToolStripButton.Click += new System.EventHandler(this.ApplyFilterToolStripButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddTextBox.Location = new System.Drawing.Point(204, 25);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(106, 13);
            this.AddTextBox.TabIndex = 6;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(204, 44);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(106, 23);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(204, 73);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(106, 23);
            this.RemoveButton.TabIndex = 14;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // FilterCheckedListBox
            // 
            this.FilterCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilterCheckedListBox.CheckOnClick = true;
            this.FilterCheckedListBox.FormattingEnabled = true;
            this.FilterCheckedListBox.Items.AddRange(new object[] {
            "Hello",
            "ABC",
            "dude"});
            this.FilterCheckedListBox.Location = new System.Drawing.Point(8, 25);
            this.FilterCheckedListBox.Name = "FilterCheckedListBox";
            this.FilterCheckedListBox.Size = new System.Drawing.Size(190, 255);
            this.FilterCheckedListBox.TabIndex = 15;
            this.FilterCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.FilterCheckedListBox_ItemCheck);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(204, 257);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(106, 23);
            this.OkButton.TabIndex = 16;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ProfanityForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 289);
            this.ControlBox = false;
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.FilterCheckedListBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddTextBox);
            this.Controls.Add(this.FilterToolStrip);
            this.Name = "ProfanityForm";
            this.Text = "Profanity";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ProfanityForm_Load);
            this.FilterToolStrip.ResumeLayout(false);
            this.FilterToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip FilterToolStrip;
        private System.Windows.Forms.ToolStripButton ApplyFilterToolStripButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.CheckedListBox FilterCheckedListBox;
        private System.Windows.Forms.Button OkButton;
    }
}