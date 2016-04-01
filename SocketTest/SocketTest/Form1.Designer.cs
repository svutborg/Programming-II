namespace SocketTest
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBoxReply = new System.Windows.Forms.RichTextBox();
            this.textBoxRequest = new System.Windows.Forms.TextBox();
            this.textBoxServerAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxConnect = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxReply
            // 
            this.richTextBoxReply.Location = new System.Drawing.Point(12, 66);
            this.richTextBoxReply.Name = "richTextBoxReply";
            this.richTextBoxReply.Size = new System.Drawing.Size(361, 246);
            this.richTextBoxReply.TabIndex = 0;
            this.richTextBoxReply.Text = "";
            // 
            // textBoxRequest
            // 
            this.textBoxRequest.Location = new System.Drawing.Point(66, 40);
            this.textBoxRequest.Name = "textBoxRequest";
            this.textBoxRequest.Size = new System.Drawing.Size(307, 20);
            this.textBoxRequest.TabIndex = 1;
            // 
            // textBoxServerAddress
            // 
            this.textBoxServerAddress.Location = new System.Drawing.Point(98, 13);
            this.textBoxServerAddress.Name = "textBoxServerAddress";
            this.textBoxServerAddress.Size = new System.Drawing.Size(194, 20);
            this.textBoxServerAddress.TabIndex = 2;
            this.textBoxServerAddress.Text = "time.windows.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Request";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Server Address";
            // 
            // checkBoxConnect
            // 
            this.checkBoxConnect.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxConnect.Location = new System.Drawing.Point(296, 10);
            this.checkBoxConnect.Name = "checkBoxConnect";
            this.checkBoxConnect.Size = new System.Drawing.Size(75, 24);
            this.checkBoxConnect.TabIndex = 5;
            this.checkBoxConnect.Text = "Connect";
            this.checkBoxConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxConnect.UseVisualStyleBackColor = true;
            this.checkBoxConnect.CheckedChanged += new System.EventHandler(this.checkBoxConnect_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 324);
            this.Controls.Add(this.checkBoxConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxServerAddress);
            this.Controls.Add(this.textBoxRequest);
            this.Controls.Add(this.richTextBoxReply);
            this.Name = "FormMain";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.RichTextBox richTextBoxReply;
        private System.Windows.Forms.TextBox textBoxRequest;
        private System.Windows.Forms.TextBox textBoxServerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxConnect;
    }
}

