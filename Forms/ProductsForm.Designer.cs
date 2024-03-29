﻿using System.Windows.Forms;

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
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productMaxLabel = new System.Windows.Forms.Label();
            this.productMinLabel = new System.Windows.Forms.Label();
            this.associatedPartsLabel = new System.Windows.Forms.Label();
            this.candidatePartSearchTextBox = new System.Windows.Forms.TextBox();
            this.productSearchButton = new System.Windows.Forms.Button();
            this.partAddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.candidatePartsLabel = new System.Windows.Forms.Label();
            this.associatedPartsGridView = new System.Windows.Forms.DataGridView();
            this.candidatePartsGridView = new System.Windows.Forms.DataGridView();
            this.associatedPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartMachineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associatedPartCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartMachineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidatePartCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsGridView)).BeginInit();
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
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
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
            this.splitContainer1.Panel1.Controls.Add(this.productIdTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.productMaxLabel);
            this.splitContainer1.Panel1.Controls.Add(this.productMinLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.associatedPartsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.candidatePartSearchTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.productSearchButton);
            this.splitContainer1.Panel2.Controls.Add(this.partAddButton);
            this.splitContainer1.Panel2.Controls.Add(this.CancelButton);
            this.splitContainer1.Panel2.Controls.Add(this.SaveButton);
            this.splitContainer1.Panel2.Controls.Add(this.productDeleteButton);
            this.splitContainer1.Panel2.Controls.Add(this.candidatePartsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.associatedPartsGridView);
            this.splitContainer1.Panel2.Controls.Add(this.candidatePartsGridView);
            this.splitContainer1.Size = new System.Drawing.Size(896, 537);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // productMinTextBox
            // 
            this.productMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMinTextBox.Location = new System.Drawing.Point(222, 295);
            this.productMinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productMinTextBox.Name = "productMinTextBox";
            this.productMinTextBox.Size = new System.Drawing.Size(76, 26);
            this.productMinTextBox.TabIndex = 48;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(100, 196);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(111, 26);
            this.productNameTextBox.TabIndex = 44;
            // 
            // productMaxTextBox
            // 
            this.productMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productMaxTextBox.Location = new System.Drawing.Point(100, 295);
            this.productMaxTextBox.Margin = new System.Windows.Forms.Padding(2);
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
            this.productPriceCostTextBox.Margin = new System.Windows.Forms.Padding(2);
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
            this.productInventoryTextBox.Margin = new System.Windows.Forms.Padding(2);
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
            // productIdTextBox
            // 
            this.productIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdTextBox.Location = new System.Drawing.Point(100, 160);
            this.productIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(111, 26);
            this.productIdTextBox.TabIndex = 43;
            this.productIdTextBox.TabStop = false;
            // 
            // productMaxLabel
            // 
            this.productMaxLabel.AutoSize = true;
            this.productMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productMaxLabel.Location = new System.Drawing.Point(58, 298);
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
            this.productMinLabel.Location = new System.Drawing.Point(184, 298);
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
            // candidatePartSearchTextBox
            // 
            this.candidatePartSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatePartSearchTextBox.Location = new System.Drawing.Point(338, 13);
            this.candidatePartSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.candidatePartSearchTextBox.Name = "candidatePartSearchTextBox";
            this.candidatePartSearchTextBox.Size = new System.Drawing.Size(226, 26);
            this.candidatePartSearchTextBox.TabIndex = 10;
            // 
            // productSearchButton
            // 
            this.productSearchButton.Location = new System.Drawing.Point(268, 14);
            this.productSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.productSearchButton.Name = "productSearchButton";
            this.productSearchButton.Size = new System.Drawing.Size(56, 24);
            this.productSearchButton.TabIndex = 9;
            this.productSearchButton.Text = "Search";
            this.productSearchButton.UseVisualStyleBackColor = true;
            this.productSearchButton.Click += new System.EventHandler(this.productSearchButton_Click);
            // 
            // partAddButton
            // 
            this.partAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partAddButton.Location = new System.Drawing.Point(512, 226);
            this.partAddButton.Margin = new System.Windows.Forms.Padding(2);
            this.partAddButton.Name = "partAddButton";
            this.partAddButton.Size = new System.Drawing.Size(52, 32);
            this.partAddButton.TabIndex = 8;
            this.partAddButton.Text = "Add";
            this.partAddButton.UseVisualStyleBackColor = true;
            this.partAddButton.Click += new System.EventHandler(this.partAddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(503, 488);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(60, 32);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.SaveButton.Location = new System.Drawing.Point(439, 488);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 32);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDeleteButton.Location = new System.Drawing.Point(503, 444);
            this.productDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(60, 32);
            this.productDeleteButton.TabIndex = 5;
            this.productDeleteButton.Text = "Delete";
            this.productDeleteButton.UseVisualStyleBackColor = true;
            this.productDeleteButton.Click += new System.EventHandler(this.productDeleteButton_Click);
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
            // associatedPartsGridView
            // 
            this.associatedPartsGridView.AllowUserToAddRows = false;
            this.associatedPartsGridView.AllowUserToDeleteRows = false;
            this.associatedPartsGridView.AllowUserToResizeColumns = false;
            this.associatedPartsGridView.AllowUserToResizeRows = false;
            this.associatedPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.associatedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.associatedPartID,
            this.associatedPartName,
            this.associatedPartInventory,
            this.associatedPartPrice,
            this.associatedPartMin,
            this.associatedPartMax,
            this.associatedPartMachineID,
            this.associatedPartCompanyName});
            this.associatedPartsGridView.Location = new System.Drawing.Point(8, 276);
            this.associatedPartsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.associatedPartsGridView.Name = "associatedPartsGridView";
            this.associatedPartsGridView.ReadOnly = true;
            this.associatedPartsGridView.RowHeadersVisible = false;
            this.associatedPartsGridView.RowHeadersWidth = 51;
            this.associatedPartsGridView.RowTemplate.Height = 24;
            this.associatedPartsGridView.Size = new System.Drawing.Size(555, 162);
            this.associatedPartsGridView.TabIndex = 1;
            // 
            // candidatePartsGridView
            // 
            this.candidatePartsGridView.AllowUserToAddRows = false;
            this.candidatePartsGridView.AllowUserToDeleteRows = false;
            this.candidatePartsGridView.AllowUserToResizeColumns = false;
            this.candidatePartsGridView.AllowUserToResizeRows = false;
            this.candidatePartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.candidatePartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatePartsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.candidatePartID,
            this.candidatePartName,
            this.candidatePartInventory,
            this.candidatePartPrice,
            this.candidatePartMin,
            this.candidatePartMax,
            this.candidatePartMachineID,
            this.candidatePartCompanyName});
            this.candidatePartsGridView.Location = new System.Drawing.Point(8, 58);
            this.candidatePartsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.candidatePartsGridView.Name = "candidatePartsGridView";
            this.candidatePartsGridView.ReadOnly = true;
            this.candidatePartsGridView.RowHeadersVisible = false;
            this.candidatePartsGridView.RowHeadersWidth = 51;
            this.candidatePartsGridView.RowTemplate.Height = 24;
            this.candidatePartsGridView.Size = new System.Drawing.Size(555, 162);
            this.candidatePartsGridView.TabIndex = 0;
            // 
            // associatedPartID
            // 
            this.associatedPartID.HeaderText = "PartID";
            this.associatedPartID.Name = "associatedPartID";
            this.associatedPartID.ReadOnly = true;
            // 
            // associatedPartName
            // 
            this.associatedPartName.HeaderText = "Name";
            this.associatedPartName.Name = "associatedPartName";
            this.associatedPartName.ReadOnly = true;
            // 
            // associatedPartInventory
            // 
            this.associatedPartInventory.HeaderText = "Inventory";
            this.associatedPartInventory.Name = "associatedPartInventory";
            this.associatedPartInventory.ReadOnly = true;
            // 
            // associatedPartPrice
            // 
            this.associatedPartPrice.HeaderText = "Price";
            this.associatedPartPrice.Name = "associatedPartPrice";
            this.associatedPartPrice.ReadOnly = true;
            // 
            // associatedPartMin
            // 
            this.associatedPartMin.HeaderText = "Min";
            this.associatedPartMin.Name = "associatedPartMin";
            this.associatedPartMin.ReadOnly = true;
            // 
            // associatedPartMax
            // 
            this.associatedPartMax.HeaderText = "Max";
            this.associatedPartMax.Name = "associatedPartMax";
            this.associatedPartMax.ReadOnly = true;
            // 
            // associatedPartMachineID
            // 
            this.associatedPartMachineID.HeaderText = "Machine ID";
            this.associatedPartMachineID.Name = "associatedPartMachineID";
            this.associatedPartMachineID.ReadOnly = true;
            this.associatedPartMachineID.Visible = false;
            // 
            // associatedPartCompanyName
            // 
            this.associatedPartCompanyName.HeaderText = "Company Name";
            this.associatedPartCompanyName.Name = "associatedPartCompanyName";
            this.associatedPartCompanyName.ReadOnly = true;
            this.associatedPartCompanyName.Visible = false;
            // 
            // candidatePartID
            // 
            this.candidatePartID.HeaderText = "PartID";
            this.candidatePartID.Name = "candidatePartID";
            this.candidatePartID.ReadOnly = true;
            // 
            // candidatePartName
            // 
            this.candidatePartName.HeaderText = "Name";
            this.candidatePartName.Name = "candidatePartName";
            this.candidatePartName.ReadOnly = true;
            // 
            // candidatePartInventory
            // 
            this.candidatePartInventory.HeaderText = "Inventory";
            this.candidatePartInventory.Name = "candidatePartInventory";
            this.candidatePartInventory.ReadOnly = true;
            // 
            // candidatePartPrice
            // 
            this.candidatePartPrice.HeaderText = "Price";
            this.candidatePartPrice.Name = "candidatePartPrice";
            this.candidatePartPrice.ReadOnly = true;
            // 
            // candidatePartMin
            // 
            this.candidatePartMin.HeaderText = "Min";
            this.candidatePartMin.Name = "candidatePartMin";
            this.candidatePartMin.ReadOnly = true;
            // 
            // candidatePartMax
            // 
            this.candidatePartMax.HeaderText = "Max";
            this.candidatePartMax.Name = "candidatePartMax";
            this.candidatePartMax.ReadOnly = true;
            // 
            // candidatePartMachineID
            // 
            this.candidatePartMachineID.HeaderText = "Machine ID";
            this.candidatePartMachineID.Name = "candidatePartMachineID";
            this.candidatePartMachineID.ReadOnly = true;
            this.candidatePartMachineID.Visible = false;
            // 
            // candidatePartCompanyName
            // 
            this.candidatePartCompanyName.HeaderText = "Company Name";
            this.candidatePartCompanyName.Name = "candidatePartCompanyName";
            this.candidatePartCompanyName.ReadOnly = true;
            this.candidatePartCompanyName.Visible = false;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 537);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(912, 576);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(912, 576);
            this.Name = "ProductsForm";
            this.Text = "Products Window";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatePartsGridView)).EndInit();
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
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Label productMaxLabel;
        private System.Windows.Forms.Label productMinLabel;
        private System.Windows.Forms.Label candidatePartsLabel;
        private System.Windows.Forms.Button productDeleteButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button partAddButton;
        private System.Windows.Forms.Button productSearchButton;
        private System.Windows.Forms.Label associatedPartsLabel;
        private System.Windows.Forms.TextBox candidatePartSearchTextBox;
        private System.Windows.Forms.DataGridView associatedPartsGridView;
        private System.Windows.Forms.DataGridView candidatePartsGridView;
        private DataGridViewTextBoxColumn associatedPartID;
        private DataGridViewTextBoxColumn associatedPartName;
        private DataGridViewTextBoxColumn associatedPartInventory;
        private DataGridViewTextBoxColumn associatedPartPrice;
        private DataGridViewTextBoxColumn associatedPartMin;
        private DataGridViewTextBoxColumn associatedPartMax;
        private DataGridViewTextBoxColumn associatedPartMachineID;
        private DataGridViewTextBoxColumn associatedPartCompanyName;
        private DataGridViewTextBoxColumn candidatePartID;
        private DataGridViewTextBoxColumn candidatePartName;
        private DataGridViewTextBoxColumn candidatePartInventory;
        private DataGridViewTextBoxColumn candidatePartPrice;
        private DataGridViewTextBoxColumn candidatePartMin;
        private DataGridViewTextBoxColumn candidatePartMax;
        private DataGridViewTextBoxColumn candidatePartMachineID;
        private DataGridViewTextBoxColumn candidatePartCompanyName;
    }
}