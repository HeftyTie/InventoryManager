using InventoryManager.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Main_Screen : Form
    {
        public Main_Screen()
        {
            InitializeComponent();
        }

        private void Main_Screen_Load(object sender, EventArgs e)
        {
            Methods methods = new Methods();
            List<Part> parts = methods.PopulatePartsDataGridView();
            List<Product> products = methods.PopulateProductsDataGridView();

            foreach (var part in parts)
            {
                if (part is Inhouse inhousePart)
                {
                    partsDataGridView.Rows.Add(inhousePart.PartID, inhousePart.Name, inhousePart.Price, inhousePart.InStock, inhousePart.Min, inhousePart.Max, inhousePart.MachineID);
                }
                else if (part is Outsourced outsourcedPart)
                {
                    partsDataGridView.Rows.Add(outsourcedPart.PartID, outsourcedPart.Name, outsourcedPart.Price, outsourcedPart.InStock, outsourcedPart.Min, outsourcedPart.Max, outsourcedPart.CompanyName);
                }
            }

            foreach(var product in products)
            {
                productsDataGridView.Rows.Add(product.ProductID, product.Name, product.Price, product.InStock, product.Min, product.Max);

            }
        }


        private void AddPartButton_Click(object sender, EventArgs e)
        {
            PartsForm form = new PartsForm("Add", 2);
            form.ShowDialog();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (partsDataGridView.SelectedRows.Count > 0)
            {
                int partId = Convert.ToInt32(partsDataGridView.SelectedRows[0].Cells[0].Value);
                PartsForm form = new PartsForm("Modify", partId);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.ShowDialog();
        }


        private void ModifyProductButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
