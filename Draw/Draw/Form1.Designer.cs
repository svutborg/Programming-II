namespace Draw
{
    partial class mainForm
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
            this.shapeDataGridView = new System.Windows.Forms.DataGridView();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.canvasPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.shapeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeDataGridView
            // 
            this.shapeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shapeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shapeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shapeDataGridView.Location = new System.Drawing.Point(606, 49);
            this.shapeDataGridView.Name = "shapeDataGridView";
            this.shapeDataGridView.Size = new System.Drawing.Size(264, 452);
            this.shapeDataGridView.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(870, 43);
            this.controlPanel.TabIndex = 1;
            // 
            // canvasPanel
            // 
            this.canvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.canvasPanel.Location = new System.Drawing.Point(0, 49);
            this.canvasPanel.MinimumSize = new System.Drawing.Size(100, 100);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(600, 452);
            this.canvasPanel.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 500);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.shapeDataGridView);
            this.Name = "mainForm";
            this.Text = "Draw";
            ((System.ComponentModel.ISupportInitialize)(this.shapeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView shapeDataGridView;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel canvasPanel;
    }
}

