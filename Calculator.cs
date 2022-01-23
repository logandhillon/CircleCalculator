using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleCalculator
{
    public partial class Calculator : Form
    {
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
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }
            }
        }

        public static void Calculate(Boolean includeUom, String uom, TextBox radiusInput, TextBox diameterInput, TextBox circumfInput, TextBox areaInput)
        {
            TextBox firstFilledTextBox = GetFirstFilledTextBox(radiusInput, diameterInput, circumfInput, areaInput);
            if (firstFilledTextBox == radiusInput)
            {
                double rad = double.Parse(radiusInput.Text, System.Globalization.CultureInfo.InvariantCulture);
                double dia = rad * 2;
                double cir = dia * 3.14159;
                double area = Math.Pow(rad, 2) * 3.14159;
                ExportNumToTextBox(includeUom, uom, radiusInput, rad, diameterInput, dia, circumfInput, cir, areaInput, area);
            }
        }

        public static void ExportNumToTextBox(Boolean includeUom, String uom, TextBox radiusInput, double rad, TextBox diameterInput, double dia, TextBox circumfInput, double cir, TextBox areaInput, double area)
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
        public static TextBox GetFirstFilledTextBox(TextBox radiusInput, TextBox diameterInput, TextBox circumfInput, TextBox areaInput)
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
    }
}