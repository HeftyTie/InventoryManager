using InventoryManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class PartsForm : Form
    {
        readonly Methods methods = new Methods();

        private readonly string request;
        private readonly Main_Screen mainForm;

        public PartsForm(string request, int partID, Main_Screen mainForm)
        {
            InitializeComponent();
            
            this.request = request;
            this.mainForm = mainForm;

            List<TextBox> list = new List<TextBox>
            {
                partIdTextBox,
                partNameTextBox,
                partInventoryTextBox,
                partPriceCostTextBox,
                partMaxTextBox,
                partMinTextBox,
                partIdOrNameTextBox
            };

            methods.PopulateUserInputFields(request, partID, list, PartLabel);

            // Make partIdTextBox read-only
            partIdTextBox.ReadOnly = true;

            // Attach event handlers
            InHouseRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            OutsourcedRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            partNameTextBox.KeyPress += StringValidation;
            partInventoryTextBox.KeyPress += IntValidation;
            partInventoryTextBox.TextChanged += (sender, e) => ValidateMinMaxInventory();
            partPriceCostTextBox.KeyPress += DecimalValidation;
            partMaxTextBox.KeyPress += IntValidation;
            partMaxTextBox.TextChanged += (sender, e) => ValidateMinMaxInventory();
            partMinTextBox.KeyPress += IntValidation;
            partMinTextBox.TextChanged += (sender, e) => ValidateMinMaxInventory();
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.TextChanged += TextBox_TextChanged;
                }
            }

            // Disable SaveButton initially
            SaveButton.Enabled = false;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            int partID = Int32.Parse(partIdTextBox.Text);
            string partName = partNameTextBox.Text;
            int inStock = Int32.Parse(partInventoryTextBox.Text);
            decimal price = decimal.Parse(partPriceCostTextBox.Text);
            int max = Int32.Parse(partMaxTextBox.Text);
            int min = Int32.Parse(partMinTextBox.Text);

            Part newPart = null;

            if (int.TryParse(partIdOrNameTextBox.Text, out int machineID))
            {
                newPart = new Inhouse
                {
                    Name = partName,
                    InStock = inStock,
                    Price = price,
                    Max = max,
                    Min = min,
                    MachineID = machineID
                };
            }
            else if (partIdOrNameTextBox.Text is string companyName)
            {
                newPart = new Outsourced
                {
                    Name = partName,
                    InStock = inStock,
                    Price = price,
                    Max = max,
                    Min = min,
                    CompanyName = companyName
                };
            }

            Inventory inventory = new Inventory();

           

            this.Close();
            mainForm.RefreshDataGrid();
            mainForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (InHouseRadioButton.Checked)
            {
                partIdOrNameLabel.Text = "Machine ID";
                partIdOrNameLabel.Location = new Point(49, 254);
                if (!int.TryParse(partIdOrNameTextBox.Text, out _))
                {
                    partIdOrNameTextBox.Text = "";
                }
                partIdOrNameTextBox.KeyPress -= StringValidation;
                partIdOrNameTextBox.KeyPress += IntValidation;
            }
            else if (OutsourcedRadioButton.Checked)
            {
                partIdOrNameLabel.Text = "Company Name";
                partIdOrNameLabel.Location = new Point(17, 254);
                if (partIdOrNameTextBox.Text is string)
                {
                    partIdOrNameTextBox.Text = "";
                }
                partIdOrNameTextBox.KeyPress -= IntValidation;
                partIdOrNameTextBox.KeyPress += StringValidation;
            }
        }

        // Allow only digits (0-9) and Backspace
        private void IntValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show(this, "Please enter digits only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Allow digits (0-9), decimal point, and Backspace
        private void DecimalValidation(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit, not a decimal point, and not a Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                // If not, handle the key press event
                e.Handled = true;
                MessageBox.Show(this, "Please enter digits or a decimal point.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If the key is the decimal point, allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
                MessageBox.Show(this, "Only one decimal point is allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Allow only letters and Backspace
        private void StringValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show(this, "Please enter letters only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidateMinMaxInventory()
        {
            int min, max, inventory;

            if (int.TryParse(partMinTextBox.Text, out min) && int.TryParse(partMaxTextBox.Text, out max) && int.TryParse(partInventoryTextBox.Text, out inventory))
            {
                if (min >= max)
                {
                    MessageBox.Show("Minimum value should be less than Maximum value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    partMinTextBox.Clear();
                }
                else if (inventory < min || inventory > max)
                {
                    MessageBox.Show("Inventory value should be between Minimum and Maximum values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    partInventoryTextBox.Clear();
                }
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            bool allTextBoxesFilled = true;

            foreach (Control control in Controls)
            {
                if (control is TextBox textBox && textBox.Visible && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    allTextBoxesFilled = false;
                    break;
                }
            }

            SaveButton.Enabled = allTextBoxesFilled;
        }
    }
}