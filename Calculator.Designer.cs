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
            this.radiusInput = new System.Windows.Forms.TextBox();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.diameterInput = new System.Windows.Forms.TextBox();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.circumfInput = new System.Windows.Forms.TextBox();
            this.circumfLabel = new System.Windows.Forms.Label();
            this.areaInput = new System.Windows.Forms.TextBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.uomInput = new System.Windows.Forms.ComboBox();
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
            this.importJSON.Size = new System.Drawing.Size(161, 22);
            this.importJSON.Text = "JSON Document";
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
            this.clearFormButton.Size = new System.Drawing.Size(148, 22);
            this.clearFormButton.Text = "Clear";
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
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
            // 
            // radiusInput
            // 
            this.radiusInput.Location = new System.Drawing.Point(11, 96);
            this.radiusInput.Margin = new System.Windows.Forms.Padding(2);
            this.radiusInput.Name = "radiusInput";
            this.radiusInput.Size = new System.Drawing.Size(96, 20);
            this.radiusInput.TabIndex = 4;
            this.radiusInput.TextChanged += new System.EventHandler(this.radiusInput_TextChanged);
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(9, 80);
            this.radiusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(40, 13);
            this.radiusLabel.TabIndex = 3;
            this.radiusLabel.Text = "Radius";
            // 
            // diameterInput
            // 
            this.diameterInput.Location = new System.Drawing.Point(11, 139);
            this.diameterInput.Margin = new System.Windows.Forms.Padding(2);
            this.diameterInput.Name = "diameterInput";
            this.diameterInput.Size = new System.Drawing.Size(96, 20);
            this.diameterInput.TabIndex = 6;
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Location = new System.Drawing.Point(9, 123);
            this.diameterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(49, 13);
            this.diameterLabel.TabIndex = 5;
            this.diameterLabel.Text = "Diameter";
            // 
            // circumfInput
            // 
            this.circumfInput.Location = new System.Drawing.Point(121, 96);
            this.circumfInput.Margin = new System.Windows.Forms.Padding(2);
            this.circumfInput.Name = "circumfInput";
            this.circumfInput.Size = new System.Drawing.Size(96, 20);
            this.circumfInput.TabIndex = 8;
            // 
            // circumfLabel
            // 
            this.circumfLabel.AutoSize = true;
            this.circumfLabel.Location = new System.Drawing.Point(119, 80);
            this.circumfLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.circumfLabel.Name = "circumfLabel";
            this.circumfLabel.Size = new System.Drawing.Size(75, 13);
            this.circumfLabel.TabIndex = 7;
            this.circumfLabel.Text = "Circumference";
            // 
            // areaInput
            // 
            this.areaInput.Location = new System.Drawing.Point(120, 139);
            this.areaInput.Margin = new System.Windows.Forms.Padding(2);
            this.areaInput.Name = "areaInput";
            this.areaInput.Size = new System.Drawing.Size(96, 20);
            this.areaInput.TabIndex = 10;
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(118, 123);
            this.areaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(29, 13);
            this.areaLabel.TabIndex = 9;
            this.areaLabel.Text = "Area";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(65, 165);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(96, 23);
            this.calculateButton.TabIndex = 11;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // uomInput
            // 
            this.uomInput.FormattingEnabled = true;
            this.uomInput.Items.AddRange(new object[] {
            "km",
            "m",
            "cm",
            "mm",
            "μm",
            "nm",
            "dm",
            "dam",
            "mi",
            "in",
            "ft",
            "yd"});
            this.uomInput.Location = new System.Drawing.Point(11, 46);
            this.uomInput.Name = "uomInput";
            this.uomInput.Size = new System.Drawing.Size(121, 21);
            this.uomInput.TabIndex = 12;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 200);
            this.Controls.Add(this.uomInput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.areaInput);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.circumfInput);
            this.Controls.Add(this.circumfLabel);
            this.Controls.Add(this.diameterInput);
            this.Controls.Add(this.diameterLabel);
            this.Controls.Add(this.radiusInput);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.uomLabel);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolStripMenuItem openFormulasButton;
        private System.Windows.Forms.ToolStripMenuItem newWindowButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearFormButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox radiusInput;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TextBox diameterInput;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.TextBox circumfInput;
        private System.Windows.Forms.Label circumfLabel;
        private System.Windows.Forms.TextBox areaInput;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox uomInput;
    }
}

