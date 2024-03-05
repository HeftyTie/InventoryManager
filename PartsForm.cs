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
        private SQLiteConnection _connection;
        private Product _product;
        public PartsForm()
        {
            InitializeComponent();

            _product = new Product();
            _connection = new SQLiteConnection("Data Source=.\\Data\\Inventory.db;Version=3;");

            _connection.Open();
            string selectsql = "SELECT last_insertrowid();";
            using (var command = new SQLiteCommand(selectsql)) {
                int partId = Convert.ToInt32(command.ExecuteScalar());  
                partIdTextBox.Text = partId.ToString();
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _connection.Open();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
