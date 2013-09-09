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
            this.comboBoxMode = new System.Windows.Forms.ToolStripComboBox();
            this.pasteIDLabel = new System.Windows.Forms.ToolStripLabel();
            this.pasteID = new System.Windows.Forms.ToolStripTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.menuFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.putToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getPutPasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.linksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPasteButton,
            this.comboBoxMode,
            this.pasteIDLabel,
            this.pasteID});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newPasteButton
            // 
            this.newPasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newPasteButton.Image = ((System.Drawing.Image)(resources.GetObject("newPasteButton.Image")));
            this.newPasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newPasteButton.Name = "newPasteButton";
            this.newPasteButton.Size = new System.Drawing.Size(23, 22);
            this.newPasteButton.Text = "toolStripButton1";
            this.newPasteButton.ToolTipText = "Get/Put Paste";
            this.newPasteButton.Click += new System.EventHandler(this.doSomething);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Items.AddRange(new object[] {
            "PUT",
            "GET"});
            this.comboBoxMode.MaxLength = 3;
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(75, 25);
            this.comboBoxMode.Text = "PUT";
            this.comboBoxMode.ToolTipText = "Mode";
            this.comboBoxMode.TextUpdate += new System.EventHandler(this.comboBoxMode_TextUpdate);
            // 
            // pasteIDLabel
            // 
            this.pasteIDLabel.Name = "pasteIDLabel";
            this.pasteIDLabel.Size = new System.Drawing.Size(30, 22);
            this.pasteIDLabel.Text = "Title";
            // 
            // pasteID
            // 
            this.pasteID.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pasteID.AutoSize = false;
            this.pasteID.MaxLength = 0;
            this.pasteID.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.pasteID.Name = "pasteID";
            this.pasteID.ShortcutsEnabled = false;
            this.pasteID.Size = new System.Drawing.Size(630, 25);
            this.pasteID.ToolTipText = "Paste ID";
            this.pasteID.Enter += new System.EventHandler(this.comboBoxMode_TextUpdate);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(784, 508);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(784, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // menuFile
            // 
            this.menuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getToolStripMenuItem,
            this.putToolStripMenuItem,
            this.toolStripSeparator2,
            this.modeToolStripMenuItem,
            this.getPutPasteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFile.Name = "menuFile";
            this.menuFile.ShowDropDownArrow = false;
            this.menuFile.Size = new System.Drawing.Size(29, 22);
            this.menuFile.Text = "&File";
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.getToolStripMenuItem.Text = "&Get Paste";
            this.getToolStripMenuItem.Click += new System.EventHandler(this.getToolStripMenuItem_Click);
            // 
            // putToolStripMenuItem
            // 
            this.putToolStripMenuItem.Name = "putToolStripMenuItem";
            this.putToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.putToolStripMenuItem.Text = "Put File";
            this.putToolStripMenuItem.Click += new System.EventHandler(this.putToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modeToolStripMenuItem.Text = "&Switch Mode";
            this.modeToolStripMenuItem.Click += new System.EventHandler(this.modeToolStripMenuItem_Click);
            // 
            // getPutPasteToolStripMenuItem
            // 
            this.getPutPasteToolStripMenuItem.Name = "getPutPasteToolStripMenuItem";
            this.getPutPasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.getPutPasteToolStripMenuItem.Text = "Get/Put &Paste";
            this.getPutPasteToolStripMenuItem.Click += new System.EventHandler(this.doSomething);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.toolStripSeparator1,
            this.linksToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuHelp.Image = ((System.Drawing.Image)(resources.GetObject("menuHelp.Image")));
            this.menuHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.ShowDropDownArrow = false;
            this.menuHelp.Size = new System.Drawing.Size(36, 22);
            this.menuHelp.Text = "&Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // linksToolStripMenuItem
            // 
            this.linksToolStripMenuItem.Name = "linksToolStripMenuItem";
            this.linksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.linksToolStripMenuItem.Text = "&Links";
            this.linksToolStripMenuItem.Click += new System.EventHandler(this.linksToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "main";
            this.Text = "CCBin for Windows";
            this.Load += new System.EventHandler(this.main_Load);
            this.Resize += new System.EventHandler(this.main_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newPasteButton;
        private System.Windows.Forms.ToolStripLabel pasteIDLabel;
        private System.Windows.Forms.ToolStripTextBox pasteID;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripComboBox comboBoxMode;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton menuFile;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getPutPasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton menuHelp;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem linksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem putToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

