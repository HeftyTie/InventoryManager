namespace InventoryManager
{
    partial class PartsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PartLabel = new System.Windows.Forms.Label();
            this.InHouseRadioButton = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadioButton = new System.Windows.Forms.RadioButton();
            this.partIdLabel = new System.Windows.Forms.Label();
            this.partNameLabel = new System.Windows.Forms.Label();
            this.partInventoryLabel = new System.Windows.Forms.Label();
            this.partPriceCostLabel = new System.Windows.Forms.Label();
            this.partMaxLabel = new System.Windows.Forms.Label();
            this.partIdOrNameLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.partMinLabel = new System.Windows.Forms.Label();
            this.partIdTextBox = new System.Windows.Forms.TextBox();
            this.partNameTextBox = new System.Windows.Forms.TextBox();
            this.partInventoryTextBox = new System.Windows.Forms.TextBox();
            this.partPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.partMaxTextBox = new System.Windows.Forms.TextBox();
            this.partIdOrNameTextBox = new System.Windows.Forms.TextBox();
            this.partMinTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PartLabel
            // 
            this.PartLabel.AutoSize = true;
            this.PartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartLabel.Location = new System.Drawing.Point(9, 7);
            this.PartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartLabel.Name = "PartLabel";
            this.PartLabel.Size = new System.Drawing.Size(79, 20);
            this.PartLabel.TabIndex = 18;
            this.PartLabel.Text = "Add Parts";
            // 
            // InHouseRadioButton
            // 
            this.InHouseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InHouseRadioButton.Location = new System.Drawing.Point(126, 6);
            this.InHouseRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.InHouseRadioButton.Name = "InHouseRadioButton";
            this.InHouseRadioButton.Size = new System.Drawing.Size(90, 24);
            this.InHouseRadioButton.TabIndex = 19;
            this.InHouseRadioButton.TabStop = true;
            this.InHouseRadioButton.Text = "In-House";
            this.InHouseRadioButton.UseVisualStyleBackColor = true;
            // 
            // OutsourcedRadioButton
            // 
            this.OutsourcedRadioButton.AutoSize = true;
            this.OutsourcedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutsourcedRadioButton.Location = new System.Drawing.Point(220, 7);
            this.OutsourcedRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.OutsourcedRadioButton.Name = "OutsourcedRadioButton";
            this.OutsourcedRadioButton.Size = new System.Drawing.Size(104, 22);
            this.OutsourcedRadioButton.TabIndex = 20;
            this.OutsourcedRadioButton.TabStop = true;
            this.OutsourcedRadioButton.Text = "Outsourced";
            this.OutsourcedRadioButton.UseVisualStyleBackColor = true;
            // 
            // partIdLabel
            // 
            this.partIdLabel.AutoSize = true;
            this.partIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partIdLabel.Location = new System.Drawing.Point(116, 89);
            this.partIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partIdLabel.Name = "partIdLabel";
            this.partIdLabel.Size = new System.Drawing.Size(26, 20);
            this.partIdLabel.TabIndex = 21;
            this.partIdLabel.Text = "ID";
            // 
            // partNameLabel
            // 
            this.partNameLabel.AutoSize = true;
            this.partNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partNameLabel.Location = new System.Drawing.Point(91, 121);
            this.partNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partNameLabel.Name = "partNameLabel";
            this.partNameLabel.Size = new System.Drawing.Size(51, 20);
            this.partNameLabel.TabIndex = 22;
            this.partNameLabel.Text = "Name";
            // 
            // partInventoryLabel
            // 
            this.partInventoryLabel.AutoSize = true;
            this.partInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partInventoryLabel.Location = new System.Drawing.Point(70, 154);
            this.partInventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partInventoryLabel.Name = "partInventoryLabel";
            this.partInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.partInventoryLabel.TabIndex = 23;
            this.partInventoryLabel.Text = "Inventory";
            // 
            // partPriceCostLabel
            // 
            this.partPriceCostLabel.AutoSize = true;
            this.partPriceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partPriceCostLabel.Location = new System.Drawing.Point(54, 186);
            this.partPriceCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partPriceCostLabel.Name = "partPriceCostLabel";
            this.partPriceCostLabel.Size = new System.Drawing.Size(89, 20);
            this.partPriceCostLabel.TabIndex = 24;
            this.partPriceCostLabel.Text = "Price / Cost";
            // 
            // partMaxLabel
            // 
            this.partMaxLabel.AutoSize = true;
            this.partMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partMaxLabel.Location = new System.Drawing.Point(101, 219);
            this.partMaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partMaxLabel.Name = "partMaxLabel";
            this.partMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.partMaxLabel.TabIndex = 25;
            this.partMaxLabel.Text = "Max";
            // 
            // partIdOrNameLabel
            // 
            this.partIdOrNameLabel.AutoSize = true;
            this.partIdOrNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partIdOrNameLabel.Location = new System.Drawing.Point(49, 254);
            this.partIdOrNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partIdOrNameLabel.Name = "partIdOrNameLabel";
            this.partIdOrNameLabel.Size = new System.Drawing.Size(90, 20);
            this.partIdOrNameLabel.TabIndex = 26;
            this.partIdOrNameLabel.Text = "Machine ID";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(240, 304);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 32);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(315, 304);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(60, 32);
            this.CancelButton.TabIndex = 28;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // partMinLabel
            // 
            this.partMinLabel.AutoSize = true;
            this.partMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.partMinLabel.Location = new System.Drawing.Point(260, 219);
            this.partMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partMinLabel.Name = "partMinLabel";
            this.partMinLabel.Size = new System.Drawing.Size(34, 20);
            this.partMinLabel.TabIndex = 29;
            this.partMinLabel.Text = "Min";
            // 
            // partIdTextBox
            // 
            this.partIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partIdTextBox.Location = new System.Drawing.Point(148, 84);
            this.partIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partIdTextBox.Name = "partIdTextBox";
            this.partIdTextBox.Size = new System.Drawing.Size(111, 26);
            this.partIdTextBox.TabIndex = 30;
            // 
            // partNameTextBox
            // 
            this.partNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNameTextBox.Location = new System.Drawing.Point(148, 121);
            this.partNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partNameTextBox.Name = "partNameTextBox";
            this.partNameTextBox.Size = new System.Drawing.Size(111, 26);
            this.partNameTextBox.TabIndex = 31;
            // 
            // partInventoryTextBox
            // 
            this.partInventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partInventoryTextBox.Location = new System.Drawing.Point(148, 154);
            this.partInventoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partInventoryTextBox.Name = "partInventoryTextBox";
            this.partInventoryTextBox.Size = new System.Drawing.Size(111, 26);
            this.partInventoryTextBox.TabIndex = 32;
            // 
            // partPriceCostTextBox
            // 
            this.partPriceCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partPriceCostTextBox.Location = new System.Drawing.Point(148, 186);
            this.partPriceCostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partPriceCostTextBox.Name = "partPriceCostTextBox";
            this.partPriceCostTextBox.Size = new System.Drawing.Size(111, 26);
            this.partPriceCostTextBox.TabIndex = 33;
            // 
            // partMaxTextBox
            // 
            this.partMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMaxTextBox.Location = new System.Drawing.Point(148, 219);
            this.partMaxTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partMaxTextBox.Name = "partMaxTextBox";
            this.partMaxTextBox.Size = new System.Drawing.Size(76, 26);
            this.partMaxTextBox.TabIndex = 34;
            // 
            // partIdOrNameTextBox
            // 
            this.partIdOrNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partIdOrNameTextBox.Location = new System.Drawing.Point(148, 251);
            this.partIdOrNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partIdOrNameTextBox.Name = "partIdOrNameTextBox";
            this.partIdOrNameTextBox.Size = new System.Drawing.Size(111, 26);
            this.partIdOrNameTextBox.TabIndex = 35;
            // 
            // partMinTextBox
            // 
            this.partMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partMinTextBox.Location = new System.Drawing.Point(298, 219);
            this.partMinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.partMinTextBox.Name = "partMinTextBox";
            this.partMinTextBox.Size = new System.Drawing.Size(76, 26);
            this.partMinTextBox.TabIndex = 36;
            // 
            // PartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 375);
            this.Controls.Add(this.partMinTextBox);
            this.Controls.Add(this.partIdOrNameTextBox);
            this.Controls.Add(this.partMaxTextBox);
            this.Controls.Add(this.partPriceCostTextBox);
            this.Controls.Add(this.partInventoryTextBox);
            this.Controls.Add(this.partNameTextBox);
            this.Controls.Add(this.partIdTextBox);
            this.Controls.Add(this.partMinLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.partIdOrNameLabel);
            this.Controls.Add(this.partMaxLabel);
            this.Controls.Add(this.partPriceCostLabel);
            this.Controls.Add(this.partInventoryLabel);
            this.Controls.Add(this.partNameLabel);
            this.Controls.Add(this.partIdLabel);
            this.Controls.Add(this.OutsourcedRadioButton);
            this.Controls.Add(this.InHouseRadioButton);
            this.Controls.Add(this.PartLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(416, 414);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(416, 414);
            this.Name = "PartsForm";
            this.Text = "Parts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PartLabel;
        private System.Windows.Forms.RadioButton InHouseRadioButton;
        private System.Windows.Forms.RadioButton OutsourcedRadioButton;
        private System.Windows.Forms.Label partIdLabel;
        private System.Windows.Forms.Label partNameLabel;
        private System.Windows.Forms.Label partInventoryLabel;
        private System.Windows.Forms.Label partPriceCostLabel;
        private System.Windows.Forms.Label partMaxLabel;
        private System.Windows.Forms.Label partIdOrNameLabel;
        private System.Windows.Forms.Button SaveButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label partMinLabel;
        private System.Windows.Forms.TextBox partIdTextBox;
        private System.Windows.Forms.TextBox partNameTextBox;
        private System.Windows.Forms.TextBox partInventoryTextBox;
        private System.Windows.Forms.TextBox partPriceCostTextBox;
        private System.Windows.Forms.TextBox partMaxTextBox;
        private System.Windows.Forms.TextBox partIdOrNameTextBox;
        private System.Windows.Forms.TextBox partMinTextBox;
    }
}