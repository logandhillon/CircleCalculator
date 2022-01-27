using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleCalculator
{
    public partial class Calculator : Form
    {
        public static string dirParameter = AppDomain.CurrentDomain.BaseDirectory + @"\file.txt";

        public Calculator()
        {
            InitializeComponent();
        }

        private void formulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulasForm = new FormulaPage();
            formulasForm.ShowDialog();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutPage();
            aboutForm.ShowDialog();
        }

        private void newWindowButton_Click(object sender, EventArgs e)
        {
            var calcForm = new Calculator();
            calcForm.Show();
        }

        public static void ClearForm(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is NumericUpDown)
                {
                    NumericUpDown NumericUpDown = (NumericUpDown)control;
                    NumericUpDown.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    comboBox.Text = null;
                }
            }
        }

        public static void Calculate(Boolean includeUom, String uom, NumericUpDown radiusInput, NumericUpDown diameterInput, NumericUpDown circumfInput, NumericUpDown areaInput)
        {
            NumericUpDown firstFilledTextBox = GetFirstFilledTextBox(radiusInput, diameterInput, circumfInput, areaInput);
            if (firstFilledTextBox == radiusInput)
            {
                double rad = double.Parse(radiusInput.Text, System.Globalization.CultureInfo.InvariantCulture);
                double dia = rad * 2;
                double cir = Math.Round(dia * 3.14159, 2);
                double area = Math.Round(Math.Pow(rad, 2) * 3.14159, 2);
                ExportNumToTextBox(includeUom, uom, radiusInput, rad, diameterInput, dia, circumfInput, cir, areaInput, area);
            }
            else if (firstFilledTextBox == diameterInput)
            {
                double dia = double.Parse(diameterInput.Text, System.Globalization.CultureInfo.InvariantCulture);
                double rad = dia / 2;
                double cir = Math.Round(dia * 3.14159, 2);
                double area = Math.Round(Math.Pow(rad, 2) * 3.14159, 2);
                ExportNumToTextBox(includeUom, uom, radiusInput, rad, diameterInput, dia, circumfInput, cir, areaInput, area);
            }
            else if (firstFilledTextBox == circumfInput)
            {
                double cir = double.Parse(circumfInput.Text, System.Globalization.CultureInfo.InvariantCulture);
                double dia = Math.Round(cir / 3.14159, 2);
                double rad = Math.Round(dia / 2, 2);
                double area = Math.Round(Math.Pow(rad, 2) * 3.14159, 2);
                ExportNumToTextBox(includeUom, uom, radiusInput, rad, diameterInput, dia, circumfInput, cir, areaInput, area);
            }
            else if (firstFilledTextBox == areaInput)
            {
                double area = double.Parse(areaInput.Text, System.Globalization.CultureInfo.InvariantCulture);
                double rad = Math.Round(Math.Sqrt(area / 3.14159), 2);
                double dia = rad * 2;
                double cir = Math.Round(dia * 3.14159, 2);
                ExportNumToTextBox(includeUom, uom, radiusInput, rad, diameterInput, dia, circumfInput, cir, areaInput, area);
            }
        }

        public static void ExportNumToTextBox(Boolean includeUom, String uom, NumericUpDown radiusInput, double rad, NumericUpDown diameterInput, double dia, NumericUpDown circumfInput, double cir, NumericUpDown areaInput, double area)
        {
            if (includeUom)
            {
                if (!String.IsNullOrWhiteSpace(uom))
                {
                    radiusInput.Text = rad.ToString() + " " + uom;
                    diameterInput.Text = dia.ToString() + " " + uom;
                    circumfInput.Text = cir.ToString() + " " + uom;
                    areaInput.Text = area.ToString() + " " + uom;
                }
                else
                {
                    System.Media.SystemSounds.Beep.Play();
                    // Asterisk (Information(i))
                    // Exclamation (Warning /!\)
                    // Hand (aka Critical Stop - Error (X))
                    // Question (?)
                    // Beep (aka Default Beep)
                }
            }
            else
            {
                radiusInput.Text = rad.ToString();
                diameterInput.Text = dia.ToString();
                circumfInput.Text = cir.ToString();
                areaInput.Text = area.ToString();
            }
        }
        public static NumericUpDown GetFirstFilledTextBox(NumericUpDown radiusInput, NumericUpDown diameterInput, NumericUpDown circumfInput, NumericUpDown areaInput)
        {
            if (!String.IsNullOrWhiteSpace(radiusInput.Text))
            {
                return radiusInput;
            }
            else if (!String.IsNullOrWhiteSpace(diameterInput.Text))
            {
                return diameterInput;
            }
            else if (!String.IsNullOrWhiteSpace(circumfInput.Text))
            {
                return circumfInput;
            }
            else if (!String.IsNullOrWhiteSpace(areaInput.Text))
            {
                return areaInput;
            }
            else
            {
                return null;
            }
        }

        private void clearFormButton_Click(object sender, EventArgs e)
        {
            Calculator.ClearForm(this);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Calculate(false, uomInput.Text, radiusInput, diameterInput, circumfInput, areaInput);
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/LDMGamingYT/CircleCalculator/issues/new/choose");
            Process.Start(sInfo);
        }

        private void exportTXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "unknown.txt";
            savefile.Filter = "Text Document (*.txt)|*.txt|Rich Text Document (*.rtf)|*.rtf|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName, false, System.Text.Encoding.Unicode))
                {
                    sw.WriteLine("*THIS DOCUMENT WAS EXPORTED USING LDM'S CIRCLE CALCULATOR*");
                    sw.WriteLine();
                    sw.WriteLine("The dimensions of your exported circle are:");
                    sw.WriteLine("Radius: " + radiusInput.Text);
                    sw.WriteLine("Diameter: " + diameterInput.Text);
                    sw.WriteLine("Circumference: " + circumfInput.Text);
                    sw.WriteLine("Area: " + areaInput.Text);
                }
            }
        }

        public static void exportConfigStyle(NumericUpDown radiusInput, NumericUpDown diameterInput, NumericUpDown circumfInput, NumericUpDown areaInput)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "unknown.txt";
            savefile.Filter = "JavaScript Object Notation (*.json)|*.json|All files (*.*)|*.*";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName, false, System.Text.Encoding.Unicode))
                {
                    sw.WriteLine("*THIS DOCUMENT WAS EXPORTED USING LDM'S CIRCLE CALCULATOR*");
                    sw.WriteLine();
                    sw.WriteLine("The dimensions of your exported circle are:");
                    sw.WriteLine("Radius: " + radiusInput.Text);
                    sw.WriteLine("Diameter: " + diameterInput.Text);
                    sw.WriteLine("Circumference: " + circumfInput.Text);
                    sw.WriteLine("Area: " + areaInput.Text);
                }
            }
        }

        private void exportJSON_Click(object sender, EventArgs e)
        {
            //exportConfigStyle(radiusInput, diameterInput, circumfInput, areaInput);
        }
    }
}