namespace CircleCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.exportJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.importRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.importJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uomLabel = new System.Windows.Forms.Label();
            this.uomInput = new System.Windows.Forms.TextBox();
            this.openFormulasButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newWindowButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFormButton = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowButton,
            this.toolStripSeparator2,
            this.importRoot,
            this.exportRoot});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportRoot
            // 
            this.exportRoot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportTXT,
            this.exportJSON});
            this.exportRoot.Name = "exportRoot";
            this.exportRoot.Size = new System.Drawing.Size(274, 26);
            this.exportRoot.Text = "Export";
            // 
            // exportTXT
            // 
            this.exportTXT.Name = "exportTXT";
            this.exportTXT.Size = new System.Drawing.Size(224, 26);
            this.exportTXT.Text = "TXT Document";
            // 
            // exportJSON
            // 
            this.exportJSON.Name = "exportJSON";
            this.exportJSON.Size = new System.Drawing.Size(224, 26);
            this.exportJSON.Text = "JSON Document";
            this.exportJSON.Click += new System.EventHandler(this.cIRCDocumentToolStripMenuItem_Click);
            // 
            // importRoot
            // 
            this.importRoot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importJSON});
            this.importRoot.Name = "importRoot";
            this.importRoot.Size = new System.Drawing.Size(274, 26);
            this.importRoot.Text = "Import";
            // 
            // importJSON
            // 
            this.importJSON.Name = "importJSON";
            this.importJSON.Size = new System.Drawing.Size(224, 26);
            this.importJSON.Text = "JSON Document";
            this.importJSON.Click += new System.EventHandler(this.cIRCDocumentToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton,
            this.toolStripSeparator1,
            this.openFormulasButton});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(245, 26);
            this.aboutButton.Text = "About Circle Calculator";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // uomLabel
            // 
            this.uomLabel.AutoSize = true;
            this.uomLabel.Location = new System.Drawing.Point(12, 37);
            this.uomLabel.Name = "uomLabel";
            this.uomLabel.Size = new System.Drawing.Size(129, 16);
            this.uomLabel.TabIndex = 1;
            this.uomLabel.Text = "Unit of Measurement";
            this.uomLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // uomInput
            // 
            this.uomInput.Location = new System.Drawing.Point(15, 56);
            this.uomInput.Name = "uomInput";
            this.uomInput.Size = new System.Drawing.Size(126, 22);
            this.uomInput.TabIndex = 2;
            // 
            // openFormulasButton
            // 
            this.openFormulasButton.Name = "openFormulasButton";
            this.openFormulasButton.Size = new System.Drawing.Size(245, 26);
            this.openFormulasButton.Text = "Formulas";
            this.openFormulasButton.Click += new System.EventHandler(this.formulasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // newWindowButton
            // 
            this.newWindowButton.Name = "newWindowButton";
            this.newWindowButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowButton.Size = new System.Drawing.Size(274, 26);
            this.newWindowButton.Text = "New Window";
            this.newWindowButton.Click += new System.EventHandler(this.newWindowButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(271, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearFormButton});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearFormButton
            // 
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.clearFormButton.Size = new System.Drawing.Size(224, 26);
            this.clearFormButton.Text = "Clear";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uomInput);
            this.Controls.Add(this.uomLabel);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Calculator";
            this.Text = "Circle Calculator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportRoot;
        private System.Windows.Forms.ToolStripMenuItem exportTXT;
        private System.Windows.Forms.ToolStripMenuItem exportJSON;
        private System.Windows.Forms.ToolStripMenuItem importRoot;
        private System.Windows.Forms.ToolStripMenuItem importJSON;
        private System.Windows.Forms.Label uomLabel;
        private System.Windows.Forms.TextBox uomInput;
        private System.Windows.Forms.ToolStripMenuItem openFormulasButton;
        private System.Windows.Forms.ToolStripMenuItem newWindowButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFormButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

