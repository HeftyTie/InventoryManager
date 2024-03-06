namespace InventoryManager
{
    partial class ProductsForm
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
            this.ProductLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.productMinTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productMaxTextBox = new System.Windows.Forms.TextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.productPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productInventoryTextBox = new System.Windows.Forms.TextBox();
            this.productInventoryLabel = new System.Windows.Forms.Label();
            this.productPriceCostLabel = new System.Windows.Forms.Label();
            this.productIdTextBix = new System.Windows.Forms.TextBox();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.partAddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(6, 7);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(115, 24);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "Add Product";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.productMinTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.ProductLabel);
            this.splitContainer1.Panel1.Controls.Add(this.productNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.productMaxTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.productIdLabel);
            this.splitContainer1.Panel1.Controls.Add(this.productPriceCostTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.productNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.productInventoryTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.productInventoryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.productPriceCostLabel);
            this.splitContainer1.Panel1.Controls.Add(this.productIdTextBix);
            this.splitContainer1.Panel1.Controls.Add(this.productMaxLabel);
            this.splitContainer1.Panel1.Controls.Add(this.productMinLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.associatedPartsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.productSearchTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.productSearchButton);
            this.splitContainer1.Panel2.Controls.Add(this.partAddButton);
            this.splitContainer1.Panel2.Controls.Add(this.CancelButton);
            this.splitContainer1.Panel2.Controls.Add(this.SaveButton);
            this.splitContainer1.Panel2.Controls.Add(this.productDeleteButton);
            this.splitContainer1.Panel2.Controls.Add(this.candidatePartsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(896, 537);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // productMinTextBox
            // 
            this.productMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinTextBox.Location = new System.Drawing.Point(232, 293);
            this.productMinTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productMinTextBox.Name = "productMinTextBox";
            this.productMinTextBox.Size = new System.Drawing.Size(76, 26);
            this.productMinTextBox.TabIndex = 48;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(100, 196);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(111, 26);
            this.productNameTextBox.TabIndex = 44;
            // 
            // productMaxTextBox
            // 
            this.productMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxTextBox.Location = new System.Drawing.Point(100, 293);
            this.productMaxTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productMaxTextBox.Name = "productMaxTextBox";
            this.productMaxTextBox.Size = new System.Drawing.Size(76, 26);
            this.productMaxTextBox.TabIndex = 47;
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.Location = new System.Drawing.Point(68, 163);
            this.productIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(26, 20);
            this.productIdLabel.TabIndex = 37;
            this.productIdLabel.Text = "ID";
            // 
            // productPriceCostTextBox
            // 
            this.productPriceCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceCostTextBox.Location = new System.Drawing.Point(100, 261);
            this.productPriceCostTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productPriceCostTextBox.Name = "productPriceCostTextBox";
            this.productPriceCostTextBox.Size = new System.Drawing.Size(111, 26);
            this.productPriceCostTextBox.TabIndex = 46;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productNameLabel.Location = new System.Drawing.Point(43, 196);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(51, 20);
            this.productNameLabel.TabIndex = 38;
            this.productNameLabel.Text = "Name";
            // 
            // productInventoryTextBox
            // 
            this.productInventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInventoryTextBox.Location = new System.Drawing.Point(100, 228);
            this.productInventoryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productInventoryTextBox.Name = "productInventoryTextBox";
            this.productInventoryTextBox.Size = new System.Drawing.Size(111, 26);
            this.productInventoryTextBox.TabIndex = 45;
            // 
            // productInventoryLabel
            // 
            this.productInventoryLabel.AutoSize = true;
            this.productInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productInventoryLabel.Location = new System.Drawing.Point(22, 228);
            this.productInventoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productInventoryLabel.Name = "productInventoryLabel";
            this.productInventoryLabel.Size = new System.Drawing.Size(74, 20);
            this.productInventoryLabel.TabIndex = 39;
            this.productInventoryLabel.Text = "Inventory";
            // 
            // productPriceCostLabel
            // 
            this.productPriceCostLabel.AutoSize = true;
            this.productPriceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productPriceCostLabel.Location = new System.Drawing.Point(6, 261);
            this.productPriceCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productPriceCostLabel.Name = "productPriceCostLabel";
            this.productPriceCostLabel.Size = new System.Drawing.Size(89, 20);
            this.productPriceCostLabel.TabIndex = 40;
            this.productPriceCostLabel.Text = "Price / Cost";
            // 
            // productIdTextBix
            // 
            this.productIdTextBix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdTextBix.Location = new System.Drawing.Point(100, 159);
            this.productIdTextBix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productIdTextBix.Name = "productIdTextBix";
            this.productIdTextBix.Size = new System.Drawing.Size(111, 26);
            this.productIdTextBix.TabIndex = 43;
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productMaxLabel.Location = new System.Drawing.Point(53, 293);
            this.productMaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productMaxLabel.Name = "productMaxLabel";
            this.productMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.productMaxLabel.TabIndex = 41;
            this.productMaxLabel.Text = "Max";
            // 
            // productMinLabel
            // 
            this.productMinLabel.AutoSize = true;
            this.productMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productMinLabel.Location = new System.Drawing.Point(195, 293);
            this.productMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productMinLabel.Name = "productMinLabel";
            this.productMinLabel.Size = new System.Drawing.Size(34, 20);
            this.productMinLabel.TabIndex = 42;
            this.productMinLabel.Text = "Min";
            // 
            // associatedPartsLabel
            // 
            this.associatedPartsLabel.AutoSize = true;
            this.associatedPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associatedPartsLabel.Location = new System.Drawing.Point(4, 254);
            this.associatedPartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.associatedPartsLabel.Name = "associatedPartsLabel";
            this.associatedPartsLabel.Size = new System.Drawing.Size(257, 20);
            this.associatedPartsLabel.TabIndex = 11;
            this.associatedPartsLabel.Text = "Parts Associated With This Product";
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchTextBox.Location = new System.Drawing.Point(338, 13);
            this.productSearchTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(226, 26);
            this.productSearchTextBox.TabIndex = 10;
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(270, 13);
            this.productSearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(56, 24);
            this.productSearchButton.TabIndex = 9;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            // 
            // partAddButton
            // 
            this.partAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partAddButton.Location = new System.Drawing.Point(512, 226);
            this.partAddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.partAddButton.Name = "partAddButton";
            this.partAddButton.Size = new System.Drawing.Size(52, 32);
            this.partAddButton.TabIndex = 8;
            this.partAddButton.Text = "Add";
            this.partAddButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(503, 488);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(60, 32);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.SaveButton.Location = new System.Drawing.Point(439, 488);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 32);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDeleteButton.Location = new System.Drawing.Point(503, 444);
            this.productDeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(60, 32);
            this.productDeleteButton.TabIndex = 5;
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.UseVisualStyleBackColor = true;
            // 
            // candidatePartsLabel
            // 
            this.candidatePartsLabel.AutoSize = true;
            this.candidatePartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatePartsLabel.Location = new System.Drawing.Point(4, 35);
            this.candidatePartsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.candidatePartsLabel.Name = "candidatePartsLabel";
            this.candidatePartsLabel.Size = new System.Drawing.Size(144, 20);
            this.candidatePartsLabel.TabIndex = 2;
            this.candidatePartsLabel.Text = "All Candidate Parts";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 276);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(562, 162);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(562, 162);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 537);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(912, 576);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(912, 576);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox productMinTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productMaxTextBox;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.TextBox productPriceCostTextBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productInventoryTextBox;
        private System.Windows.Forms.Label productInventoryLabel;
        private System.Windows.Forms.Label productPriceCostLabel;
        private System.Windows.Forms.TextBox productIdTextBix;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.Button productDeleteButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button partAddButton;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.Label associatedPartsLabel;
    }
}