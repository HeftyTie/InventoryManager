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
        public PartsForm()
        {
            InitializeComponent();

            using (var _connection = new SQLiteConnection("Data Source=Data/Inventory.db;Version=3;"))
            {
                _connection.Open();
                string selectSql = "SELECT PartID FROM [Part]";
                using (var command = new SQLiteCommand(selectSql, _connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int partId = Convert.ToInt32(reader["PartID"]) + 1;
                        partIdTextBox.Text = partId.ToString(); 
                    }
                }
            }

            InHouseRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            OutsourcedRadioButton.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(InHouseRadioButton.Checked)
            {
                partIdOrNameLabel.Text = "Machine ID";
                partIdOrNameLabel.Location = new Point(49, 254);
            }
            else if (OutsourcedRadioButton.Checked)
            {
                partIdOrNameLabel.Text = "Company Name";
                partIdOrNameLabel.Location = new Point(17, 254);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
