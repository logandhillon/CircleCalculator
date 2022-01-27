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
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFormulasButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uomLabel = new System.Windows.Forms.Label();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.circumfLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.uomInput = new System.Windows.Forms.ComboBox();
            this.radiusInput = new System.Windows.Forms.NumericUpDown();
            this.diameterInput = new System.Windows.Forms.NumericUpDown();
            this.areaInput = new System.Windows.Forms.NumericUpDown();
            this.circumfInput = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circumfInput)).BeginInit();
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(307, 28);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
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
            this.importJSON.Size = new System.Drawing.Size(200, 26);
            this.importJSON.Text = "JSON Document";
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
            this.exportTXT.Click += new System.EventHandler(this.exportTXT_Click);
            // 
            // exportJSON
            // 
            this.exportJSON.Name = "exportJSON";
            this.exportJSON.Size = new System.Drawing.Size(224, 26);
            this.exportJSON.Text = "JSON Document";
            this.exportJSON.Click += new System.EventHandler(this.exportJSON_Click);
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
            this.clearFormButton.Size = new System.Drawing.Size(187, 26);
            this.clearFormButton.Text = "Clear";
            this.clearFormButton.Click += new System.EventHandler(this.clearFormButton_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton,
            this.sendFeedbackToolStripMenuItem,
            this.toolStripSeparator1,
            this.openFormulasButton});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(245, 26);
            this.aboutButton.Text = "About Circle Calculator";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.sendFeedbackToolStripMenuItem.Text = "Send Feedback";
            this.sendFeedbackToolStripMenuItem.Click += new System.EventHandler(this.sendFeedbackToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // openFormulasButton
            // 
            this.openFormulasButton.Name = "openFormulasButton";
            this.openFormulasButton.Size = new System.Drawing.Size(245, 26);
            this.openFormulasButton.Text = "Formulas";
            this.openFormulasButton.Click += new System.EventHandler(this.formulasToolStripMenuItem_Click);
            // 
            // uomLabel
            // 
            this.uomLabel.AutoSize = true;
            this.uomLabel.Location = new System.Drawing.Point(12, 37);
            this.uomLabel.Name = "uomLabel";
            this.uomLabel.Size = new System.Drawing.Size(129, 16);
            this.uomLabel.TabIndex = 1;
            this.uomLabel.Text = "Unit of Measurement";
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(12, 98);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(50, 16);
            this.radiusLabel.TabIndex = 3;
            this.radiusLabel.Text = "Radius";
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Location = new System.Drawing.Point(12, 151);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(62, 16);
            this.diameterLabel.TabIndex = 5;
            this.diameterLabel.Text = "Diameter";
            // 
            // circumfLabel
            // 
            this.circumfLabel.AutoSize = true;
            this.circumfLabel.Location = new System.Drawing.Point(159, 98);
            this.circumfLabel.Name = "circumfLabel";
            this.circumfLabel.Size = new System.Drawing.Size(93, 16);
            this.circumfLabel.TabIndex = 7;
            this.circumfLabel.Text = "Circumference";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(157, 151);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(36, 16);
            this.areaLabel.TabIndex = 9;
            this.areaLabel.Text = "Area";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(87, 203);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(128, 28);
            this.calculateButton.TabIndex = 17;
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
            this.uomInput.Location = new System.Drawing.Point(15, 57);
            this.uomInput.Margin = new System.Windows.Forms.Padding(4);
            this.uomInput.Name = "uomInput";
            this.uomInput.Size = new System.Drawing.Size(126, 24);
            this.uomInput.TabIndex = 12;
            // 
            // radiusInput
            // 
            this.radiusInput.DecimalPlaces = 2;
            this.radiusInput.Location = new System.Drawing.Point(15, 118);
            this.radiusInput.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.radiusInput.Name = "radiusInput";
            this.radiusInput.Size = new System.Drawing.Size(127, 22);
            this.radiusInput.TabIndex = 13;
            // 
            // diameterInput
            // 
            this.diameterInput.DecimalPlaces = 2;
            this.diameterInput.Location = new System.Drawing.Point(15, 170);
            this.diameterInput.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.diameterInput.Name = "diameterInput";
            this.diameterInput.Size = new System.Drawing.Size(127, 22);
            this.diameterInput.TabIndex = 15;
            // 
            // areaInput
            // 
            this.areaInput.DecimalPlaces = 2;
            this.areaInput.Location = new System.Drawing.Point(160, 170);
            this.areaInput.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.areaInput.Name = "areaInput";
            this.areaInput.Size = new System.Drawing.Size(127, 22);
            this.areaInput.TabIndex = 16;
            // 
            // circumfInput
            // 
            this.circumfInput.DecimalPlaces = 2;
            this.circumfInput.Location = new System.Drawing.Point(160, 117);
            this.circumfInput.Maximum = new decimal(new int[] {
            -1,
            2147483647,
            0,
            0});
            this.circumfInput.Name = "circumfInput";
            this.circumfInput.Size = new System.Drawing.Size(127, 22);
            this.circumfInput.TabIndex = 14;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CheckFileExists = true;
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "circle_calculator_results";
            this.saveFileDialog.Filter = "Text Document (*.txt)|*.txt|All files (*.*)|*.*";
            this.saveFileDialog.Title = "Export Circle Calculator Results to TXT Document";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 246);
            this.Controls.Add(this.areaInput);
            this.Controls.Add(this.circumfInput);
            this.Controls.Add(this.diameterInput);
            this.Controls.Add(this.radiusInput);
            this.Controls.Add(this.uomInput);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.circumfLabel);
            this.Controls.Add(this.diameterLabel);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.uomLabel);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Circle Calculator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radiusInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diameterInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circumfInput)).EndInit();
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
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.Label circumfLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox uomInput;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown radiusInput;
        private System.Windows.Forms.NumericUpDown diameterInput;
        private System.Windows.Forms.NumericUpDown areaInput;
        private System.Windows.Forms.NumericUpDown circumfInput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

