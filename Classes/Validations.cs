using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManager.Classes
{
    public class Validations
    {
        // Allow only digits (0-9) and Backspace
        public static void IntValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Please enter digits only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Allow digits (0-9), decimal point, and Backspace
        public static void DecimalValidation(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit, not a decimal point, and not a Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                // If not, handle the key press event
                e.Handled = true;
                MessageBox.Show("Please enter digits or a decimal point.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If the key is the decimal point, allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
                MessageBox.Show("Only one decimal point is allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Allow only letters and Backspace
        public static void StringValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Please enter letters only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validate minimum, maximum, and inventory values
        public static bool ValidateMinMaxInventory(TextBox minTextBox, TextBox maxTextBox, TextBox inventoryTextBox)
        {
            int min, max, inventory;

            if (int.TryParse(minTextBox.Text, out min) && int.TryParse(maxTextBox.Text, out max) && int.TryParse(inventoryTextBox.Text, out inventory))
            {
                if (min >= max)
                {
                    MessageBox.Show("Minimum value should be less than Maximum value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    minTextBox.Clear();
                    return false;
                }
                else if (inventory < min || inventory > max)
                {
                    MessageBox.Show("Inventory value should be between Minimum and Maximum values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    inventoryTextBox.Clear();
                    return false;
                }
            }

            return true;
        }

        //Validate user fills all textboxes
        public static void ValidateTextBoxes(Control.ControlCollection controls, Button saveButton)
        {
            bool allTextBoxesFilled = controls.OfType<TextBox>().All(textBox => !string.IsNullOrWhiteSpace(textBox.Text));

            saveButton.Enabled = allTextBoxesFilled;
        }

        public static bool ValidateTextBoxes(List<TextBox> textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false; // Return false if any TextBox is null or empty
                }
            }
            return true; // Return true if all TextBoxes are filled
        }
    }
}
