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
            partInventoryTextBox.KeyPress += Validations.IntValidation;
            partPriceCostTextBox.KeyPress += Validations.DecimalValidation;
            partMaxTextBox.KeyPress += Validations.IntValidation;
            partMinTextBox.KeyPress += Validations.IntValidation;
            partInventoryTextBox.TextChanged += (sender, e) => Validations.ValidateMinMaxInventory(partMinTextBox, partMaxTextBox, partInventoryTextBox);
            partMaxTextBox.TextChanged += (sender, e) => Validations.ValidateMinMaxInventory(partMinTextBox, partMaxTextBox, partInventoryTextBox);
            partMinTextBox.TextChanged += (sender, e) => Validations.ValidateMinMaxInventory(partMinTextBox, partMaxTextBox, partInventoryTextBox);
            foreach (TextBox textBox in Controls.OfType<TextBox>())
            {
                textBox.TextChanged += (sender, e) => Validations.ValidateTextBoxes(Controls, SaveButton);
            }

            // Disable SaveButton initially
            SaveButton.Enabled = false;

            string text = partIdOrNameTextBox.Text;
            if (int.TryParse(text, out _))
            {
                InHouseRadioButton.Checked = true;
            }
            else
            {
                OutsourcedRadioButton.Checked = true;
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();

            int partID = Int32.Parse(partIdTextBox.Text);
            string partName = partNameTextBox.Text;
            int inStock = Int32.Parse(partInventoryTextBox.Text);
            decimal price = decimal.Parse(partPriceCostTextBox.Text);
            int max = Int32.Parse(partMaxTextBox.Text);
            int min = Int32.Parse(partMinTextBox.Text);

            Part newPart;
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
                if(request == "Add Part")
                {
                    inventory.AddPart(newPart);
                }
                else if (request == "Modify Part")
                {
                    inventory.UpdatePart(partID, newPart);
                }
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
                if (request == "Add Part")
                {
                    inventory.AddPart(newPart);
                }
                else if(request == "Modify Part")
                {
                    inventory.UpdatePart(partID, newPart);
                }
            }

            this.Close();
            mainForm.RefreshDataGrid();
            mainForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.RefreshDataGrid();
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
                partIdOrNameTextBox.KeyPress -= Validations.StringValidation;
                partIdOrNameTextBox.KeyPress += Validations.IntValidation;
            }
            else if (OutsourcedRadioButton.Checked)
            {
                partIdOrNameLabel.Text = "Company Name";
                partIdOrNameLabel.Location = new Point(17, 254);
                if (partIdOrNameTextBox.Text.GetType() != typeof(string))
                {
                    partIdOrNameTextBox.Text = "";
                }
                partIdOrNameTextBox.KeyPress -= Validations.IntValidation;
                partIdOrNameTextBox.KeyPress += Validations.StringValidation;
            }
        }
    }
}