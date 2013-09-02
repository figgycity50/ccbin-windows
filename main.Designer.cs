namespace CCBin
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newPasteButton = new System.Windows.Forms.ToolStripButton();
            this.pasteIDLabel = new System.Windows.Forms.ToolStripLabel();
            this.pasteID = new System.Windows.Forms.ToolStripTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPasteButton,
            this.pasteIDLabel,
            this.pasteID});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newPasteButton
            // 
            this.newPasteButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.newPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newPasteButton.Image = ((System.Drawing.Image)(resources.GetObject("newPasteButton.Image")));
            this.newPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newPasteButton.Name = "newPasteButton";
            this.newPasteButton.Size = new System.Drawing.Size(23, 22);
            this.newPasteButton.Text = "toolStripButton1";
            this.newPasteButton.ToolTipText = "Upload Paste";
            this.newPasteButton.Click += new System.EventHandler(this.newPaste);
            // 
            // pasteIDLabel
            // 
            this.pasteIDLabel.Name = "pasteIDLabel";
            this.pasteIDLabel.Size = new System.Drawing.Size(49, 22);
            this.pasteIDLabel.Text = "Paste ID";
            // 
            // pasteID
            // 
            this.pasteID.MaxLength = 6;
            this.pasteID.Name = "pasteID";
            this.pasteID.ShortcutsEnabled = false;
            this.pasteID.Size = new System.Drawing.Size(680, 25);
            this.pasteID.ToolTipText = "Paste ID";
            this.pasteID.Leave += new System.EventHandler(this.getPaste);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(784, 536);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "CCBin for Windows";
            this.Load += new System.EventHandler(this.main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newPasteButton;
        private System.Windows.Forms.ToolStripLabel pasteIDLabel;
        private System.Windows.Forms.ToolStripTextBox pasteID;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

