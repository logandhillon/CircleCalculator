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
            this.newWindowButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.importRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.importJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.exportRoot = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.exportJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFormButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFormulasButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uomLabel = new System.Windows.Forms.Label();
            this.uomInput = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(230, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newWindowButton
            // 
            this.newWindowButton.Name = "newWindowButton";
            this.newWindowButton.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowButton.Size = new System.Drawing.Size(220, 22);
            this.newWindowButton.Text = "New Window";
            this.newWindowButton.Click += new System.EventHandler(this.newWindowButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // importRoot
            // 
            this.importRoot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importJSON});
            this.importRoot.Name = "importRoot";
            this.importRoot.Size = new System.Drawing.Size(220, 22);
            this.importRoot.Text = "Import";
            // 
            // importJSON
            // 
            this.importJSON.Name = "importJSON";
            this.importJSON.Size = new System.Drawing.Size(180, 22);
            this.importJSON.Text = "JSON Document";
            this.importJSON.Click += new System.EventHandler(this.cIRCDocumentToolStripMenuItem1_Click);
            // 
            // exportRoot
            // 
            this.exportRoot.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportTXT,
            this.exportJSON});
            this.exportRoot.Name = "exportRoot";
            this.exportRoot.Size = new System.Drawing.Size(220, 22);
            this.exportRoot.Text = "Export";
            // 
            // exportTXT
            // 
            this.exportTXT.Name = "exportTXT";
            this.exportTXT.Size = new System.Drawing.Size(161, 22);
            this.exportTXT.Text = "TXT Document";
            // 
            // exportJSON
            // 
            this.exportJSON.Name = "exportJSON";
            this.exportJSON.Size = new System.Drawing.Size(161, 22);
            this.exportJSON.Text = "JSON Document";
            this.exportJSON.Click += new System.EventHandler(this.cIRCDocumentToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearFormButton});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearFormButton
            // 
            this.clearFormButton.Name = "clearFormButton";
            this.clearFormButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Delete)));
            this.clearFormButton.Size = new System.Drawing.Size(180, 22);
            this.clearFormButton.Text = "Clear";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton,
            this.toolStripSeparator1,
            this.openFormulasButton});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(197, 22);
            this.aboutButton.Text = "About Circle Calculator";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // openFormulasButton
            // 
            this.openFormulasButton.Name = "openFormulasButton";
            this.openFormulasButton.Size = new System.Drawing.Size(197, 22);
            this.openFormulasButton.Text = "Formulas";
            this.openFormulasButton.Click += new System.EventHandler(this.formulasToolStripMenuItem_Click);
            // 
            // uomLabel
            // 
            this.uomLabel.AutoSize = true;
            this.uomLabel.Location = new System.Drawing.Point(9, 30);
            this.uomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uomLabel.Name = "uomLabel";
            this.uomLabel.Size = new System.Drawing.Size(105, 13);
            this.uomLabel.TabIndex = 1;
            this.uomLabel.Text = "Unit of Measurement";
            this.uomLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // uomInput
            // 
            this.uomInput.Location = new System.Drawing.Point(11, 46);
            this.uomInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uomInput.Name = "uomInput";
            this.uomInput.Size = new System.Drawing.Size(96, 20);
            this.uomInput.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 96);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Radius";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 139);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Diameter";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 96);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Circumference";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 139);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(96, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Area";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(65, 165);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(96, 23);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 200);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uomInput);
            this.Controls.Add(this.uomLabel);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateButton;
    }
}

