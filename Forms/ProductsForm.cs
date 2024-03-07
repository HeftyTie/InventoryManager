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

        private readonly string request;
        private readonly Main_Screen mainForm;

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

            // Disable SaveButton initially
            SaveButton.Enabled = false;
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

            if (ProductLabel.Text == "Add Product")
            {
                inventory.AddProduct(newProduct);
            }
            else if (ProductLabel.Text == "Modify Product")
            {
                int productID = Int32.Parse(productIdTextBox.Text);
                inventory.UpdateProduct(productID, newProduct);
            }

            this.Close();
            mainForm.RefreshDataGrid();
            mainForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }
    }
}
