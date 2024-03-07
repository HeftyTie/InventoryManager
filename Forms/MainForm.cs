using InventoryManager.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO.Ports;
using System.Windows.Forms;

namespace InventoryManager
{
    public partial class Main_Screen : Form
    {
        Inventory inventory = new Inventory(); 

        public Main_Screen()
        {
            InitializeComponent();
        }

        private void Main_Screen_Load(object sender, EventArgs e)
        {
            // Refresh data grid
            RefreshDataGrid();

            // Setup CellClick event handler
            partsDataGridView.ClearSelection();
            partsDataGridView.CellClick += (s, cellEventArgs) =>
            {
                if (cellEventArgs.RowIndex >= 0)
                {
                    partsDataGridView.Rows[cellEventArgs.RowIndex].Selected = true;
                }
            };

            productsDataGridView.ClearSelection();
            productsDataGridView.CellClick += (s, cellEventArgs) =>
            {
                if (cellEventArgs.RowIndex >= 0)
                {
                    productsDataGridView.Rows[cellEventArgs.RowIndex].Selected = true;
                }
            };
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            PartsForm form = new PartsForm("Add Part", 0, this);
            this.Hide();
            form.ShowDialog();
        }

        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (partsDataGridView.SelectedRows.Count > 0)
            {
                int partId = Convert.ToInt32(partsDataGridView.SelectedRows[0].Cells[0].Value);
                PartsForm form = new PartsForm("Modify Part", partId, this);
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (partsDataGridView.SelectedRows.Count > 0)
            {

                Part deletePart = new Inhouse 
                {
                    PartID = Convert.ToInt32(partsDataGridView.SelectedRows[0].Cells["PartID"].Value),
                    Name = Convert.ToString(partsDataGridView.SelectedRows[0].Cells["PartName"].Value),
                    Price = Convert.ToDecimal(partsDataGridView.SelectedRows[0].Cells["PartPrice"].Value),
                    InStock = Convert.ToInt32(partsDataGridView.SelectedRows[0].Cells["PartInStock"].Value),
                    Min = Convert.ToInt32(partsDataGridView.SelectedRows[0].Cells["PartMin"].Value),
                    Max = Convert.ToInt32(partsDataGridView.SelectedRows[0].Cells["PartMax"].Value)
                };

                DialogResult result = MessageBox.Show("Are you sure you want to delete this part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        inventory.DeletePart(deletePart);
                        RefreshDataGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete part. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainPartsSearchButton_Click(object sender, EventArgs e)
        {
            var part = mainPartsSearchButton.Text;

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm("Add Product", 0, this);
            form.ShowDialog();
        }


        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (productsDataGridView.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(productsDataGridView.SelectedRows[0].Cells[0].Value);
                ProductsForm form = new ProductsForm("Modify Product", productId, this);
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to modify.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (productsDataGridView.SelectedRows.Count > 0)
            {
                int removeProduct = Convert.ToInt32(productsDataGridView.SelectedRows[0].Cells["ProductID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        inventory.RemoveProduct(removeProduct);
                        RefreshDataGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to delete part. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshDataGrid()
        {
            // Clear existing rows in DataGridViews
            partsDataGridView.Rows.Clear();
            productsDataGridView.Rows.Clear();

            // Populate parts and products from the database
            inventory.PopulatePartsFromDatabase();
            inventory.PopulateProductsFromDatabase();

            // Populate partsDataGridView
            foreach (var part in inventory.AllParts)
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

            // Populate productsDataGridView
            foreach (var product in inventory.Products)
            {
                productsDataGridView.Rows.Add(product.ProductID, product.Name, product.Price, product.InStock, product.Min, product.Max);
            }

            this.Update();
        }


    }
}
