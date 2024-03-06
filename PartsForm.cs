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
        private readonly string request;

        public PartsForm(string request, int partID)
        {
            InitializeComponent();

            this.request = request;
            using (var _connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
            {
                _connection.Open();

                string selectSql;
                if (request == "Add")
                {
                    selectSql = "SELECT MAX(PartID) FROM [Part]";
                    using (var command = new SQLiteCommand(selectSql, _connection))
                    {
                        var maxPartId = command.ExecuteScalar();
                        int partId = maxPartId == DBNull.Value ? 1 : Convert.ToInt32(maxPartId) + 1;
                        partIdTextBox.Text = partId.ToString();
                    }
                }
                else if (request == "Modify")
                {
                    selectSql = $"SELECT * FROM [Part] WHERE PartID = @partID";
                    using (var command = new SQLiteCommand(selectSql, _connection))
                    {
                        command.Parameters.AddWithValue("@partID", partID);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                partIdTextBox.Text = reader.GetInt32(reader.GetOrdinal("PartID")).ToString();
                                partNameTextBox.Text = reader.GetString(reader.GetOrdinal("Name"));
                                partInventoryTextBox.Text = reader["InStock"] == DBNull.Value ? "" : reader["InStock"].ToString();
                                partPriceCostTextBox.Text = reader.GetDecimal(reader.GetOrdinal("Price")).ToString();
                                partMaxTextBox.Text = reader.GetInt32(reader.GetOrdinal("Max")).ToString();
                                partMinTextBox.Text = reader.GetInt32(reader.GetOrdinal("Min")).ToString();

                                if (reader["MachineID"] != DBNull.Value)
                                {
                                    partIdOrNameTextBox.Text = reader["MachineID"].ToString();
                                }
                                else if (!string.IsNullOrEmpty(reader["CompanyName"].ToString()))
                                {
                                    partIdOrNameTextBox.Text = reader["CompanyName"].ToString();
                                }
                            }
                        }
                    }
                }
            }

            // Make partIdTextBox read-only
            partIdTextBox.ReadOnly = true;

            // Attach event handlers
            InHouseRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            OutsourcedRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            partNameTextBox.KeyPress += StringValidation;
            partInventoryTextBox.KeyPress += IntValidation;
            partPriceCostTextBox.KeyPress += DecimalValidation;
            partMaxTextBox.KeyPress += IntValidation;
            partMinTextBox.KeyPress += IntValidation;
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

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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