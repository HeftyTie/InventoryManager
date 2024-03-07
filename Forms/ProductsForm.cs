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
                addOrModifyTextBox
            };

            Methods.PopulateUserInputFields(request, productID, list, ProductLabel);
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

    }
}
