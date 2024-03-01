using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Main_Screen : Form
    {
        public Main_Screen()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            PartsForm form = new PartsForm();
            form.ShowDialog();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.ShowDialog();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {

        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {

        }

        private void ModifyProductButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {

        }
    }
}
