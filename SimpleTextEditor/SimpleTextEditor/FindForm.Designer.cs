namespace SimpleTextEditor
{
    partial class FindForm
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
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.ReplaceAllButton = new System.Windows.Forms.Button();
            this.ReplaceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matchCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.wholeWordOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.FindAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(90, 12);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(143, 20);
            this.FindTextBox.TabIndex = 0;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(239, 12);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 20);
            this.FindButton.TabIndex = 1;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(239, 67);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(75, 23);
            this.ReplaceButton.TabIndex = 2;
            this.ReplaceButton.Text = "Replace";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // ReplaceAllButton
            // 
            this.ReplaceAllButton.Location = new System.Drawing.Point(239, 97);
            this.ReplaceAllButton.Name = "ReplaceAllButton";
            this.ReplaceAllButton.Size = new System.Drawing.Size(75, 23);
            this.ReplaceAllButton.TabIndex = 3;
            this.ReplaceAllButton.Text = "Replace All";
            this.ReplaceAllButton.UseVisualStyleBackColor = true;
            this.ReplaceAllButton.Click += new System.EventHandler(this.ReplaceAllButton_Click);
            // 
            // ReplaceTextBox
            // 
            this.ReplaceTextBox.Location = new System.Drawing.Point(90, 40);
            this.ReplaceTextBox.Name = "ReplaceTextBox";
            this.ReplaceTextBox.Size = new System.Drawing.Size(143, 20);
            this.ReplaceTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Replace with:";
            // 
            // matchCaseCheckBox
            // 
            this.matchCaseCheckBox.AutoSize = true;
            this.matchCaseCheckBox.Location = new System.Drawing.Point(15, 101);
            this.matchCaseCheckBox.Name = "matchCaseCheckBox";
            this.matchCaseCheckBox.Size = new System.Drawing.Size(82, 17);
            this.matchCaseCheckBox.TabIndex = 7;
            this.matchCaseCheckBox.Text = "Match case";
            this.matchCaseCheckBox.UseVisualStyleBackColor = true;
            this.matchCaseCheckBox.CheckedChanged += new System.EventHandler(this.matchCaseCheckBox_CheckedChanged);
            // 
            // wholeWordOnlyCheckBox
            // 
            this.wholeWordOnlyCheckBox.AutoSize = true;
            this.wholeWordOnlyCheckBox.Location = new System.Drawing.Point(103, 101);
            this.wholeWordOnlyCheckBox.Name = "wholeWordOnlyCheckBox";
            this.wholeWordOnlyCheckBox.Size = new System.Drawing.Size(105, 17);
            this.wholeWordOnlyCheckBox.TabIndex = 8;
            this.wholeWordOnlyCheckBox.Text = "Whole word only";
            this.wholeWordOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // FindAllButton
            // 
            this.FindAllButton.Location = new System.Drawing.Point(239, 38);
            this.FindAllButton.Name = "FindAllButton";
            this.FindAllButton.Size = new System.Drawing.Size(75, 23);
            this.FindAllButton.TabIndex = 9;
            this.FindAllButton.Text = "Find All";
            this.FindAllButton.UseVisualStyleBackColor = true;
            this.FindAllButton.Click += new System.EventHandler(this.FindAllButton_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 153);
            this.Controls.Add(this.FindAllButton);
            this.Controls.Add(this.wholeWordOnlyCheckBox);
            this.Controls.Add(this.matchCaseCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplaceTextBox);
            this.Controls.Add(this.ReplaceAllButton);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FindTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FindForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindForm_FormClosed);
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.Button ReplaceAllButton;
        private System.Windows.Forms.TextBox ReplaceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox matchCaseCheckBox;
        private System.Windows.Forms.CheckBox wholeWordOnlyCheckBox;
        private System.Windows.Forms.Button FindAllButton;
    }
}