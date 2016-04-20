namespace p2p_messenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBoxIP = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBoxPort = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonConnect = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxRecieve = new System.Windows.Forms.RichTextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelListener = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxIP,
            this.toolStripTextBoxPort,
            this.toolStripButtonConnect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(511, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBoxIP
            // 
            this.toolStripTextBoxIP.Name = "toolStripTextBoxIP";
            this.toolStripTextBoxIP.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxIP.ToolTipText = "IP-Address";
            // 
            // toolStripTextBoxPort
            // 
            this.toolStripTextBoxPort.Name = "toolStripTextBoxPort";
            this.toolStripTextBoxPort.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxPort.Text = "1337";
            this.toolStripTextBoxPort.ToolTipText = "Port";
            // 
            // toolStripButtonConnect
            // 
            this.toolStripButtonConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonConnect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonConnect.Image")));
            this.toolStripButtonConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnect.Name = "toolStripButtonConnect";
            this.toolStripButtonConnect.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonConnect.Text = "Connect";
            this.toolStripButtonConnect.Click += new System.EventHandler(this.toolStripButtonConnect_Click);
            // 
            // richTextBoxRecieve
            // 
            this.richTextBoxRecieve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRecieve.Location = new System.Drawing.Point(0, 28);
            this.richTextBoxRecieve.Name = "richTextBoxRecieve";
            this.richTextBoxRecieve.Size = new System.Drawing.Size(511, 192);
            this.richTextBoxRecieve.TabIndex = 1;
            this.richTextBoxRecieve.Text = "";
            this.richTextBoxRecieve.TextChanged += new System.EventHandler(this.richTextBoxRecieve_TextChanged);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSend.Location = new System.Drawing.Point(0, 226);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(511, 20);
            this.textBoxSend.TabIndex = 2;
            this.textBoxSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelListener});
            this.statusStrip1.Location = new System.Drawing.Point(0, 247);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(511, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelListener
            // 
            this.toolStripStatusLabelListener.Name = "toolStripStatusLabelListener";
            this.toolStripStatusLabelListener.Size = new System.Drawing.Size(0, 17);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 269);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.richTextBoxRecieve);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMain";
            this.Text = "P2P Messenger";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxIP;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPort;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnect;
        private System.Windows.Forms.RichTextBox richTextBoxRecieve;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelListener;
    }
}

