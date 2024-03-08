using InventoryManager.Classes;
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
    public partial class ProductsForm : Form
    {
        readonly Methods Methods = new Methods();
        readonly Inventory inventory = new Inventory();
        private Product product = new Product();

        private readonly string request;
        private readonly Main_Screen mainForm;

        public ProductsForm()
        {
        }

        public ProductsForm(string request, int productID, Main_Screen mainForm)
        {
            InitializeComponent();

            this.request = request;
            this.mainForm = mainForm;

            List<TextBox> list = new List<TextBox>
            {
                productIdTextBox,
                productNameTextBox,
                productInventoryTextBox,
                productPriceCostTextBox,
                productMaxTextBox,
                productMinTextBox,
            };

            Methods.PopulateUserInputFields(request, productID, list, ProductLabel);

            // Make productIdTextBox read-only
            productIdTextBox.ReadOnly = true;

            // Attach event handlers
            productNameTextBox.KeyPress += Validations.StringValidation;
            productInventoryTextBox.KeyPress += Validations.IntValidation;
            productPriceCostTextBox.KeyPress += Validations.DecimalValidation;
            productMaxTextBox.KeyPress += Validations.IntValidation;
            productMinTextBox.KeyPress += Validations.IntValidation;
            productInventoryTextBox.TextChanged += (sender, e) => Validations.ValidateMinMaxInventory(productMinTextBox, productMaxTextBox, productInventoryTextBox);
            productMaxTextBox.TextChanged += (sender, e) => Validations.ValidateMinMaxInventory(productMinTextBox, productMaxTextBox, productInventoryTextBox);
            productMinTextBox.TextChanged += (sender, e) => Validations.ValidateMinMaxInventory(productMinTextBox, productMaxTextBox, productInventoryTextBox);
            candidatePartSearchTextBox.KeyPress += Validations.IntValidation;

            // Note: We are using a List<Control> here because the foreach loop was not working
            // Create a list to hold all TextBox controls
            List<Control> controls = new List<Control>();

            // Add TextBox controls to the list
            controls.Add(productNameTextBox);
            controls.Add(productInventoryTextBox);
            controls.Add(productPriceCostTextBox);
            controls.Add(productMaxTextBox);
            controls.Add(productMinTextBox);

            // Attach event handlers to each TextBox control
            foreach (TextBox textBox in controls.OfType<TextBox>())
            {
                textBox.TextChanged += (sender, e) => Validations.ValidateTextBoxes(Controls, SaveButton);
            }

            candidatePartsGridView.CellClick += (s, cellEventArgs) =>
            {
                if (cellEventArgs.RowIndex >= 0)
                {
                    candidatePartsGridView.Rows[cellEventArgs.RowIndex].Selected = true;
                }
            };

            associatedPartsGridView.CellClick += (s, cellEventArgs) =>
            {
                if (cellEventArgs.RowIndex >= 0)
                {
                    associatedPartsGridView.Rows[cellEventArgs.RowIndex].Selected = true;
                }
            };

            // Disable SaveButton initially
            SaveButton.Enabled = false;

            RefreshProductsFormDataGrid();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                Name = productNameTextBox.Text,
                InStock = Int32.Parse(productInventoryTextBox.Text),
                Price = decimal.Parse(productPriceCostTextBox.Text),
                Max = Int32.Parse(productMaxTextBox.Text),
                Min = Int32.Parse(productMinTextBox.Text)
            };

            int productID = Int32.Parse(productIdTextBox.Text);
            if (ProductLabel.Text == "Add Product")
            {
                inventory.AddProduct(newProduct);
            }
            else if (ProductLabel.Text == "Modify Product")
            {
                inventory.UpdateProduct(productID, newProduct);
            }

            product.SaveAssociatedPartsToDB(productID, productNameTextBox.Text);
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

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int partID = Int32.Parse(candidatePartSearchTextBox.Text);
                Part part = product.LookupAssociatedPart(partID);
                int rowIndex = -1;
                if (part != null)
                {
                    candidatePartsGridView.Rows.Clear();
                    if (part is Inhouse inhousePart)
                    {
                        rowIndex = candidatePartsGridView.Rows.Add(inhousePart.PartID, inhousePart.Name, inhousePart.Price, inhousePart.InStock, inhousePart.Min, inhousePart.Max, inhousePart.MachineID);
                    }
                    else if (part is Outsourced outsourcedPart)
                    {
                        rowIndex = candidatePartsGridView.Rows.Add(outsourcedPart.PartID, outsourcedPart.Name, outsourcedPart.Price, outsourcedPart.InStock, outsourcedPart.Min, outsourcedPart.Max, outsourcedPart.CompanyName);
                    }
                    if (rowIndex != -1)
                    {
                        candidatePartsGridView.Rows[rowIndex].Selected = true;
                    }
                    candidatePartSearchTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("No part found with the provided ID.", "Part Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid part ID. Please enter a valid integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void partAddButton_Click(object sender, EventArgs e)
        {

            
            // Ensure there is at least one row selected
            if (candidatePartsGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = candidatePartsGridView.SelectedRows[0];

                int PartID = Convert.ToInt32(selectedRow.Cells["candidatePartID"].Value);
                string name = selectedRow.Cells["candidatePartName"].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells["candidatePartPrice"].Value);
                int inStock = Convert.ToInt32(selectedRow.Cells["candidatePartInventory"].Value);
                int min = Convert.ToInt32(selectedRow.Cells["candidatePartMin"].Value);
                int max = Convert.ToInt32(selectedRow.Cells["candidatePartMax"].Value);

                bool partExists = false;
                foreach (DataGridViewRow row in associatedPartsGridView.Rows)
                {
                    if (row.Cells["associatedPartID"].Value != null && Convert.ToInt32(row.Cells["associatedPartID"].Value) == PartID)
                    {
                        partExists = true;
                        break;
                    }
                }

                if (!partExists)
                {
                    if (selectedRow.Cells["candidatePartMachineID"].Value != null)
                    {
                        // Inhouse part
                        int machineID = Convert.ToInt32(selectedRow.Cells["candidatePartMachineID"].Value);
                        Inhouse inhousePart = new Inhouse
                        {
                            PartID = PartID,
                            Name = name,
                            Price = price,
                            InStock = inStock,
                            Min = min,
                            Max = max,
                            MachineID = machineID
                        };
                        product.AddAssociatedPart(inhousePart);
                        associatedPartsGridView.Rows.Add(inhousePart.PartID, inhousePart.Name, inhousePart.Price, inhousePart.InStock, inhousePart.Min, inhousePart.Max, inhousePart.MachineID);
                        //Refresh datagrid in case of search
                        RefreshProductsFormDataGrid();
                    }
                    else if (selectedRow.Cells["candidatePartCompanyName"].Value != null)
                    {
                        // Outsourced part
                        string companyName = selectedRow.Cells["candidatePartCompanyName"].Value.ToString();
                        Outsourced outsourcedPart = new Outsourced
                        {
                            PartID = PartID,
                            Name = name,
                            Price = price,
                            InStock = inStock,
                            Min = min,
                            Max = max,
                            CompanyName = companyName,
                        };
                        product.AddAssociatedPart(outsourcedPart);
                        associatedPartsGridView.Rows.Add(outsourcedPart.PartID, outsourcedPart.Name, outsourcedPart.Price, outsourcedPart.InStock, outsourcedPart.Min, outsourcedPart.Max, outsourcedPart.CompanyName);
                        //Refresh datagrid in case of search
                        RefreshProductsFormDataGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void productDeleteButton_Click(object sender, EventArgs e)
        {
            // Ensure there is at least one row selected
            if (associatedPartsGridView.SelectedRows.Count > 0)
            {
                int rowIndex = associatedPartsGridView.SelectedRows[0].Index;
                int partID = Convert.ToInt32(associatedPartsGridView.SelectedRows[0].Cells["associatedPartID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to remove this part from product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        product.RemoveAssociatedPart(partID);
                        associatedPartsGridView.Rows.RemoveAt(rowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable to remove part. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove part.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshProductsFormDataGrid()
        {
            // Clear existing rows in DataGridViews
            candidatePartsGridView.Rows.Clear();

            // Populate from the database
            inventory.PopulatePartsFromDatabase();

            // Populate candidatePartsGridView
            foreach (var part in inventory.AllParts)
            {
                if (part is Inhouse inhousePart)
                {
                    candidatePartsGridView.Rows.Add(inhousePart.PartID, inhousePart.Name, inhousePart.Price, inhousePart.InStock, inhousePart.Min, inhousePart.Max, inhousePart.MachineID);
                }
                else if (part is Outsourced outsourcedPart)
                {
                    candidatePartsGridView.Rows.Add(outsourcedPart.PartID, outsourcedPart.Name, outsourcedPart.Price, outsourcedPart.InStock, outsourcedPart.Min, outsourcedPart.Max, outsourcedPart.CompanyName);
                }
            }
        }
    }
}